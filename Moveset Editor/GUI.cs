using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MeowDSIO;
using MeowDSIO.DataFiles;
using MeowDSIO.DataTypes.TAE;

namespace Moveset_Editor
{
    public partial class GUI : Form
    {

        static string FilePath;
        static ANIBND c0000;
        TAE currentTae
        {
            get
            {
                int index = MovesetBox.SelectedIndex;
                if (index == -1) return null;
                return ((KeyValuePair<int, TAE>)MovesetBox.SelectedItem).Value;
            }
        }
        int currentMoveset
        {
            get
            {
                int index = MovesetBox.SelectedIndex;
                if (index == -1) return -1;
                return ((KeyValuePair<int, TAE>)MovesetBox.SelectedItem).Key;
            }
        }
        AnimHandler activeHandler
        {
            get
            {
                if (AnimBox.SelectedItem == null) return null;
                return (AnimHandler)AnimBox.SelectedItem; 
            }
        }


        public GUI()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FilePath = ofd.FileName;
                    c0000 = DataFile.LoadFromFile<ANIBND>(FilePath);
                    c0000.CreateBackup();
                } catch (Exception ex)
                {
                    MessageBox.Show(@"Error loading ANIBND.\n\n" + ex.ToString());
                    openToolStripMenuItem_Click(sender, e);
                    return;
                }
                RefreshMovesetList(0);

            }
        }

        private void RefreshMovesetList(int index = -1)
        {
            MovesetBox.DataSource = c0000.PlayerTAE.Where(p => p.Key >= 20 && p.Key < 200).ToList();
            MovesetBox.SelectedIndex = index;
            RefreshAnimationList();
        }

        private void RefreshAnimationList()
        {
            int id = activeHandler == null ? -1 : activeHandler.Anim.ID;
            AnimBox.DataSource = null;
            if (currentTae == null) return;
            AnimBox.DisplayMember = "DisplayName";
            var list = currentTae.Animations.Select(a => new AnimHandler(currentMoveset, currentTae, a)).ToList();
            AnimBox.DataSource = list;

            var item = list.FirstOrDefault(a => a.Anim.ID == id);
            if (item != null) AnimBox.SelectedItem = item;
        }

        private void MovesetBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAnimationList();
        }

        private void AnimBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEditor();
        }

        private void RefreshEditor()
        {
            var handler = activeHandler;
            if (handler == null)
            {
                animNameBox.Text = "";
                isReferenceCheckBox.Checked = false;
                refAnimNameBox.Text = "";
                refMovesetBox.Value = -1;
                refIdBox.Value = -1;
            } else
            {
                animNameBox.Text = handler.FullName;
                isReferenceCheckBox.Checked = handler.Anim.IsReference;
                if (handler.Anim.IsReference)
                {
                    isRefBox.Enabled = true;
                    refAnimNameBox.Text = UTIL.GetFullName(handler.Anim.RefAnimID);
                    if (handler.Anim.RefAnimID > -1)
                    {
                        refMovesetBox.Value = Math.Floor((decimal)handler.Anim.RefAnimID / 10000);
                        refIdBox.Value = handler.Anim.RefAnimID % 10000;
                    } else
                    {
                        refMovesetBox.Value = -1;
                        refIdBox.Value = -1;
                    }
                } else
                {
                    isRefBox.Enabled = false;
                    refAnimNameBox.Text = "";
                    refMovesetBox.Value = -1;
                    refIdBox.Value = -1;
                }
            }
        }

        private void isReferenceBox_CheckedChanged(object sender, EventArgs e)
        {
            if (activeHandler == null) isReferenceCheckBox.Checked = false;
            else isRefBox.Enabled = isReferenceCheckBox.Checked;
        }

        private void SaveRefSettings()
        {
            if (activeHandler == null) return;
            int index = AnimBox.SelectedIndex;
            var anim = activeHandler.Anim;
            if (isReferenceCheckBox.Checked)
            {
                int moveset = (int)refMovesetBox.Value;
                int id = (int)refIdBox.Value;
                int newId = moveset * 10000 + id;


                if (newId == anim.RefAnimID) return;
                if (!c0000.PlayerTAE.ContainsKey(moveset))
                {
                    MessageBox.Show("Invalid moveset.");
                    return;
                }
                if (!c0000.PlayerTAE[moveset].AnimationIDs.Contains(id))
                {
                    MessageBox.Show("Animation ID not found in specified moveset.");
                    return;
                }

                anim.IsReference = true;
                anim.RefAnimID = newId;
                anim.EventList = new ObservableCollection<TimeActEventBase>();

                var refAnim = c0000.PlayerTAE[moveset].Animations.Find(a => a.ID == id);
                foreach (var evt in refAnim.EventList)
                {
                    var newEvt = CopyEvent(evt);
                    anim.EventList.Add(newEvt);
                }
                RefreshEditor();
            }
            else
            {
                anim.IsReference = false;
                anim.EventList = activeHandler.OriginalEvents;
                anim.RefAnimID = -1;
            }
        }

        private void SaveRefBtn_Click(object sender, EventArgs e)
        {
            SaveRefSettings();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveRefSettings();
            try
            {
                DataFile.Resave(c0000);
                MessageBox.Show("Save successful");
            } catch (Exception ex)
            {
                MessageBox.Show("Error saving file.\n\n" + ex.ToString());
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveRefSettings();
                    DataFile.SaveToFile(c0000, sfd.FileName);
                } catch (Exception ex)
                {
                    MessageBox.Show(@"Error saving ANIBND.\n\n" + ex.ToString());
                }
            }
        }

        private void saveReferenceSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveRefSettings();
        }

        private void RevertRefBtn_Click(object sender, EventArgs e)
        {
            RefreshEditor();
        }

        private void CloneMovesetBtn_Click(object sender, EventArgs e)
        {
            if (currentTae == null) return;
            string output = "";
            if (DialogResult.OK == InputBox("New Moveset", "Enter ID for new moveset", ref output))
            {
                int newId;
                bool success = int.TryParse(output.Trim(), out newId);
                if (success && newId < 1000 && newId > -1)
                {
                    if (c0000.PlayerTAE.ContainsKey(newId))
                    {
                        MessageBox.Show("Moveset ID already exists.");
                        CloneMovesetBtn_Click(sender, e);
                    } else
                    {
                        int oldId = ((KeyValuePair<int, TAE>)MovesetBox.SelectedItem).Key;
                        string newPath = currentTae.VirtualUri.Replace($@"a{oldId}.tae",$@"a{newId}.tae");
                        var newTae = DataFile.LoadFromBytes<TAE>(DataFile.SaveAsBytes(currentTae, newPath), newPath);
                        c0000.PlayerTAE[newId] = newTae;
                        var sorted = new SortedDictionary<int, TAE>(c0000.PlayerTAE);
                        c0000.PlayerTAE = new Dictionary<int, TAE>(sorted);
                        RefreshMovesetList();
                        MovesetBox.SelectedItem = c0000.PlayerTAE.First(kv => kv.Key == newId);
                    }

                } else
                {
                    MessageBox.Show("Invalid ID.");
                    CloneMovesetBtn_Click(sender, e);
                }
            }
        }

        public DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void DeleteMovesetBtn_Click(object sender, EventArgs e)
        {
            if (currentTae == null) return;
            if (DialogResult.OK == MessageBox.Show("Delete selected moveset?", "Confirm", MessageBoxButtons.OK))
            {
                c0000.PlayerTAE.Remove(currentMoveset);
                RefreshMovesetList();
            }
        }

        private void CloneAnimBtn_Click(object sender, EventArgs e)
        {
            var srcAnim = activeHandler;
            if (srcAnim == null) return;
            string output = "";
            if (DialogResult.OK == InputBox("New Animation", "Enter ID for new animation", ref output))
            {
                int newId;
                bool success = int.TryParse(output.Trim(), out newId);
                if (success)
                {
                    if (currentTae.AnimationIDs.Contains(newId))
                    {
                        MessageBox.Show("Animation ID already exists.");
                        CloneAnimBtn_Click(sender, e);
                        return;
                    }
                    var anim = new AnimationRef();
                    anim.ID = newId;
                    anim.EventList = CloneEventList(srcAnim.OriginalEvents);
                    currentTae.Animations.Add(anim);
                    currentTae.Animations = currentTae.Animations.OrderBy(a => a.ID).ToList();
                    RefreshAnimationList();
                    AnimBox.SelectedIndex = currentTae.Animations.IndexOf(anim);

                } else
                {
                    MessageBox.Show("Invalid ID");
                    CloneAnimBtn_Click(sender, e);

                }
            }
        }

        public static ObservableCollection<TimeActEventBase> CloneEventList(ObservableCollection<TimeActEventBase> source)
        {
            return new ObservableCollection<TimeActEventBase>(source.Select(x => CopyEvent(x)));
        }

        public static TimeActEventBase CopyEvent(TimeActEventBase srcEvent)
        {
            var newEvent = TimeActEventBase.GetNewEvent(srcEvent.EventType, srcEvent.StartTime, srcEvent.EndTime);
            using (var memStream = new MemoryStream())
            {
                srcEvent.WriteParameters(new DSBinaryWriter("", memStream));
                memStream.Position = 0;
                newEvent.ReadParameters(new DSBinaryReader("", memStream));
            }
            return newEvent;
        }

        private void DeleteAnimBtn_Click(object sender, EventArgs e)
        {
            if (activeHandler == null) return;
            if (DialogResult.OK == MessageBox.Show("Delete selected animation?", "Confirm", MessageBoxButtons.OK))
            {
                currentTae.Animations.Remove(activeHandler.Anim);
                RefreshAnimationList();
            }
        }
    }

    public class AnimHandler
    {
        public int MoveSet;
        public TAE TAE;
        public AnimationRef Anim;
        public ObservableCollection<TimeActEventBase> OriginalEvents;
        public int FullID => MoveSet * 10000 + Anim.ID;
        public string DisplayName => Anim.ID + ": " + UTIL.GetName(Anim.ID);
        public string Name => UTIL.GetName(Anim.ID);
        public string FullName => UTIL.GetFullName(FullID);
        public string RefName => Anim.RefAnimID == -1 || !Anim.IsReference ? "" : UTIL.GetName(Anim.RefAnimID % 10000);
        public string FullRefName => Anim.RefAnimID == -1 || !Anim.IsReference ? "" : UTIL.GetFullName(Anim.RefAnimID);

        public AnimHandler(int m, TAE t, AnimationRef a)
        {
            MoveSet = m;
            TAE = t;
            Anim = a;

            OriginalEvents = GUI.CloneEventList(Anim.EventList);

        }
    }

    public static class UTIL
    {

        public static string GetName(int animId)
        {
            if (animId > 10000) return GetFullName(animId);
            string hand = AnimDictionary.GetHand((int)Math.Floor((float)animId / 1000) * 1000);
            string action = hand == "" ? AnimDictionary.GetActionLH(animId % 1000) : AnimDictionary.GetAction(animId % 1000);
            return hand + action;
        }

        public static string GetFullName(int fullAnimId)
        {
            string output = "Moveset " + Math.Floor((float)fullAnimId / 10000) + " : ";
            return output + GetName(fullAnimId % 10000);
        }
    }


    public static class AnimDictionary
    {
        private static Dictionary<int, string> Hands = new Dictionary<int, string>()
        {
            { 3000,"RH " },
            { 4000,"2H " },
            { 5000,"" },
        };
        private static Dictionary<int, string> Actions = new Dictionary<int, string>()
        {
            { 0, "R1 Initial Attack" },
            { 1, "R1 Combo B" },
            { 2, "R1 Combo A" },
            { 30, "Too Heavy" },
            { 40, "R1 Initial Attack Whiff" },
            { 41, "R1 Combo B Whiff" },
            { 42, "R1 Combo A Whiff" },
            { 100, "Kick" },
            { 150, "Deflected 1" },
            { 200, "Deflected 2" },
            { 201, "Riposte 1" },
            { 202, "Riposte 2" },
            { 203, "Riposte 3" },
            { 300, "R2 Initial Attack" },
            { 301, "R2 Combo From R1" },
            { 305, "Trident Dance A" },
            { 306, "Trident Dance B" },
            { 310, "R2 Combo Attack" },
            { 315, "R2 Combo Attack" },
            { 350, "R2 Combo Attack" },
            { 400, "Backstab 1" },
            { 401, "Backstab 2" },
            { 402, "Backstab 3" },
            { 403, "Backstab 4" },
            { 500, "Running Attack" },
            { 540, "Running Attack (Unused)" },
            { 600, "Jumping Attack" },
            { 640, "Jumping Attack" },
            { 800, "Plunging Attack Start" },
            { 801, "Plunging Attack Continue" },
            { 802, "???" },
            { 810, "Pluging Attack Land" },
            { 820, "???" },
            { 822, "Custom Plunge 1" },
            { 824, "Custom Plunge 2" },
            { 826, "Custom Plunge 3" },
            { 900, "Rolling R1" },
            { 940, "Rolling R1 Whiff" },
            { 980, "Hornet Ring Riposte" },
        };
        private static Dictionary<int, string> ActionsLH = new Dictionary<int, string>()
        {
            { 0, "LH Attack" },
            { 2, "LH Attack" },
            { 3, "LH Attack" },
            { 30, "LH Too Heavy" },
            { 40, "LH Attack Whiff" },
            { 42, "LH Attack Whiff" },
            { 43, "LH Attack Whiff" },
            { 100, "LH Special Attack" },
            { 102, "LH Special Attack" },
            { 103, "LH Special Attack" },
            { 130, "LH Special Attack Failed" },
            { 500, "2H Ready Ranged Weapon" },
            { 501, "Crossbow ? 1" },
            { 502, "Crossobw ? 2" },
            { 510, "RH Crossbow Out Of Ammo / Knock Arrow in Bow" },
            { 511, "LH Crossbow Out Of Ammo" },
            { 512, "RH Crossbow Out Of Ammo / Knock Arrow in Bow" },
            { 520, "RH Crossbow Reload / Release Arrow w/o Shooting" },
            { 521, "LH Crossbow Reload" },
            { 522, "RH Crossbow Reload / Release Arrow w/o Shooting" },
        };

        private static string GetDef(Dictionary<int, string> dict, int key, string notFound) => dict.Keys.Contains(key) ? dict[key] : notFound;
        public static string GetHand(int h) => GetDef(Hands, h, " ?H ");
        public static string GetAction(int a) => GetDef(Actions, a, "???"); 
        public static string GetActionLH(int a) => GetDef(ActionsLH, a, null) ?? GetAction(a); 
    }
}
