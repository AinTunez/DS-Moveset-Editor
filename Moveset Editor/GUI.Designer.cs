namespace Moveset_Editor
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteMovesetBtn = new System.Windows.Forms.Button();
            this.CloneMovesetBtn = new System.Windows.Forms.Button();
            this.MovesetBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteAnimBtn = new System.Windows.Forms.Button();
            this.CloneAnimBtn = new System.Windows.Forms.Button();
            this.AnimBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RestoreAnimBackupBtn = new System.Windows.Forms.Button();
            this.RevertRefBtn = new System.Windows.Forms.Button();
            this.SaveRefBtn = new System.Windows.Forms.Button();
            this.isRefBox = new System.Windows.Forms.GroupBox();
            this.refMovesetBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.refAnimNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refIdBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animNameBox = new System.Windows.Forms.TextBox();
            this.isReferenceCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReferenceSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.isRefBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refMovesetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refIdBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.MovesetBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(219, 658);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movesets";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteMovesetBtn);
            this.panel1.Controls.Add(this.CloneMovesetBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 44);
            this.panel1.TabIndex = 5;
            // 
            // DeleteMovesetBtn
            // 
            this.DeleteMovesetBtn.Location = new System.Drawing.Point(101, 6);
            this.DeleteMovesetBtn.Name = "DeleteMovesetBtn";
            this.DeleteMovesetBtn.Size = new System.Drawing.Size(69, 33);
            this.DeleteMovesetBtn.TabIndex = 3;
            this.DeleteMovesetBtn.TabStop = false;
            this.DeleteMovesetBtn.Text = "Delete";
            this.DeleteMovesetBtn.UseVisualStyleBackColor = true;
            this.DeleteMovesetBtn.Click += new System.EventHandler(this.DeleteMovesetBtn_Click);
            // 
            // CloneMovesetBtn
            // 
            this.CloneMovesetBtn.Location = new System.Drawing.Point(34, 6);
            this.CloneMovesetBtn.Name = "CloneMovesetBtn";
            this.CloneMovesetBtn.Size = new System.Drawing.Size(61, 33);
            this.CloneMovesetBtn.TabIndex = 2;
            this.CloneMovesetBtn.TabStop = false;
            this.CloneMovesetBtn.Text = "Clone";
            this.CloneMovesetBtn.UseVisualStyleBackColor = true;
            this.CloneMovesetBtn.Click += new System.EventHandler(this.CloneMovesetBtn_Click);
            // 
            // MovesetBox
            // 
            this.MovesetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovesetBox.DisplayMember = "Key";
            this.MovesetBox.FormattingEnabled = true;
            this.MovesetBox.ItemHeight = 16;
            this.MovesetBox.Location = new System.Drawing.Point(16, 33);
            this.MovesetBox.Name = "MovesetBox";
            this.MovesetBox.Size = new System.Drawing.Size(193, 564);
            this.MovesetBox.TabIndex = 0;
            this.MovesetBox.TabStop = false;
            this.MovesetBox.SelectedIndexChanged += new System.EventHandler(this.MovesetBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.AnimBox);
            this.groupBox1.Location = new System.Drawing.Point(237, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(307, 658);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animations";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteAnimBtn);
            this.panel2.Controls.Add(this.CloneAnimBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 44);
            this.panel2.TabIndex = 5;
            // 
            // DeleteAnimBtn
            // 
            this.DeleteAnimBtn.Location = new System.Drawing.Point(138, 6);
            this.DeleteAnimBtn.Name = "DeleteAnimBtn";
            this.DeleteAnimBtn.Size = new System.Drawing.Size(69, 33);
            this.DeleteAnimBtn.TabIndex = 3;
            this.DeleteAnimBtn.TabStop = false;
            this.DeleteAnimBtn.Text = "Delete";
            this.DeleteAnimBtn.UseVisualStyleBackColor = true;
            this.DeleteAnimBtn.Click += new System.EventHandler(this.DeleteAnimBtn_Click);
            // 
            // CloneAnimBtn
            // 
            this.CloneAnimBtn.Location = new System.Drawing.Point(71, 6);
            this.CloneAnimBtn.Name = "CloneAnimBtn";
            this.CloneAnimBtn.Size = new System.Drawing.Size(61, 33);
            this.CloneAnimBtn.TabIndex = 2;
            this.CloneAnimBtn.TabStop = false;
            this.CloneAnimBtn.Text = "Clone";
            this.CloneAnimBtn.UseVisualStyleBackColor = true;
            this.CloneAnimBtn.Click += new System.EventHandler(this.CloneAnimBtn_Click);
            // 
            // AnimBox
            // 
            this.AnimBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AnimBox.DisplayMember = "Name";
            this.AnimBox.ItemHeight = 16;
            this.AnimBox.Location = new System.Drawing.Point(13, 33);
            this.AnimBox.Name = "AnimBox";
            this.AnimBox.Size = new System.Drawing.Size(281, 564);
            this.AnimBox.TabIndex = 0;
            this.AnimBox.TabStop = false;
            this.AnimBox.SelectedIndexChanged += new System.EventHandler(this.AnimBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RestoreAnimBackupBtn);
            this.groupBox3.Controls.Add(this.RevertRefBtn);
            this.groupBox3.Controls.Add(this.SaveRefBtn);
            this.groupBox3.Controls.Add(this.isRefBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.animNameBox);
            this.groupBox3.Controls.Add(this.isReferenceCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(550, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(403, 658);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editor";
            // 
            // RestoreAnimBackupBtn
            // 
            this.RestoreAnimBackupBtn.Location = new System.Drawing.Point(77, 363);
            this.RestoreAnimBackupBtn.Name = "RestoreAnimBackupBtn";
            this.RestoreAnimBackupBtn.Size = new System.Drawing.Size(239, 39);
            this.RestoreAnimBackupBtn.TabIndex = 13;
            this.RestoreAnimBackupBtn.TabStop = false;
            this.RestoreAnimBackupBtn.Text = "Restore From Backup";
            this.RestoreAnimBackupBtn.UseVisualStyleBackColor = true;
            this.RestoreAnimBackupBtn.Click += new System.EventHandler(this.RestoreAnimBackupBtn_Click);
            // 
            // RevertRefBtn
            // 
            this.RevertRefBtn.Location = new System.Drawing.Point(77, 318);
            this.RevertRefBtn.Name = "RevertRefBtn";
            this.RevertRefBtn.Size = new System.Drawing.Size(239, 39);
            this.RevertRefBtn.TabIndex = 12;
            this.RevertRefBtn.TabStop = false;
            this.RevertRefBtn.Text = "Revert to Saved";
            this.RevertRefBtn.UseVisualStyleBackColor = true;
            this.RevertRefBtn.Click += new System.EventHandler(this.RevertRefBtn_Click);
            // 
            // SaveRefBtn
            // 
            this.SaveRefBtn.Location = new System.Drawing.Point(77, 272);
            this.SaveRefBtn.Name = "SaveRefBtn";
            this.SaveRefBtn.Size = new System.Drawing.Size(239, 40);
            this.SaveRefBtn.TabIndex = 11;
            this.SaveRefBtn.TabStop = false;
            this.SaveRefBtn.Text = "Save Reference Settings (Ctrl+S)";
            this.SaveRefBtn.UseVisualStyleBackColor = true;
            this.SaveRefBtn.Click += new System.EventHandler(this.SaveRefBtn_Click);
            // 
            // isRefBox
            // 
            this.isRefBox.Controls.Add(this.refMovesetBox);
            this.isRefBox.Controls.Add(this.label4);
            this.isRefBox.Controls.Add(this.refAnimNameBox);
            this.isRefBox.Controls.Add(this.label1);
            this.isRefBox.Controls.Add(this.refIdBox);
            this.isRefBox.Controls.Add(this.label2);
            this.isRefBox.Enabled = false;
            this.isRefBox.Location = new System.Drawing.Point(13, 126);
            this.isRefBox.Name = "isRefBox";
            this.isRefBox.Padding = new System.Windows.Forms.Padding(10);
            this.isRefBox.Size = new System.Drawing.Size(377, 140);
            this.isRefBox.TabIndex = 10;
            this.isRefBox.TabStop = false;
            this.isRefBox.Text = "Reference Animation";
            // 
            // refMovesetBox
            // 
            this.refMovesetBox.Location = new System.Drawing.Point(149, 75);
            this.refMovesetBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.refMovesetBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.refMovesetBox.Name = "refMovesetBox";
            this.refMovesetBox.Size = new System.Drawing.Size(65, 22);
            this.refMovesetBox.TabIndex = 10;
            this.refMovesetBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // refAnimNameBox
            // 
            this.refAnimNameBox.Location = new System.Drawing.Point(12, 29);
            this.refAnimNameBox.Name = "refAnimNameBox";
            this.refAnimNameBox.ReadOnly = true;
            this.refAnimNameBox.Size = new System.Drawing.Size(348, 22);
            this.refAnimNameBox.TabIndex = 8;
            this.refAnimNameBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference Moveset";
            // 
            // refIdBox
            // 
            this.refIdBox.Location = new System.Drawing.Point(149, 103);
            this.refIdBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refIdBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.refIdBox.Name = "refIdBox";
            this.refIdBox.Size = new System.Drawing.Size(65, 22);
            this.refIdBox.TabIndex = 3;
            this.refIdBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reference ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animation Name";
            // 
            // animNameBox
            // 
            this.animNameBox.Location = new System.Drawing.Point(13, 53);
            this.animNameBox.Name = "animNameBox";
            this.animNameBox.ReadOnly = true;
            this.animNameBox.Size = new System.Drawing.Size(377, 22);
            this.animNameBox.TabIndex = 5;
            this.animNameBox.TabStop = false;
            // 
            // isReferenceCheckBox
            // 
            this.isReferenceCheckBox.AutoSize = true;
            this.isReferenceCheckBox.Location = new System.Drawing.Point(13, 87);
            this.isReferenceCheckBox.Name = "isReferenceCheckBox";
            this.isReferenceCheckBox.Size = new System.Drawing.Size(110, 21);
            this.isReferenceCheckBox.TabIndex = 0;
            this.isReferenceCheckBox.TabStop = false;
            this.isReferenceCheckBox.Text = "Is Reference";
            this.isReferenceCheckBox.UseVisualStyleBackColor = true;
            this.isReferenceCheckBox.CheckedChanged += new System.EventHandler(this.isReferenceBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hiddenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.openToolStripMenuItem.Text = "Open ANIBND";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.saveToolStripMenuItem.Text = "Save ANIBND";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // hiddenToolStripMenuItem
            // 
            this.hiddenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveReferenceSettingsToolStripMenuItem});
            this.hiddenToolStripMenuItem.Name = "hiddenToolStripMenuItem";
            this.hiddenToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.hiddenToolStripMenuItem.Text = "Hidden";
            this.hiddenToolStripMenuItem.Visible = false;
            // 
            // saveReferenceSettingsToolStripMenuItem
            // 
            this.saveReferenceSettingsToolStripMenuItem.Name = "saveReferenceSettingsToolStripMenuItem";
            this.saveReferenceSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveReferenceSettingsToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.saveReferenceSettingsToolStripMenuItem.Text = "Save Reference Settings";
            this.saveReferenceSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveReferenceSettingsToolStripMenuItem_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 711);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "Moveset Editor v0.3";
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.isRefBox.ResumeLayout(false);
            this.isRefBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refMovesetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refIdBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteMovesetBtn;
        private System.Windows.Forms.Button CloneMovesetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteAnimBtn;
        private System.Windows.Forms.Button CloneAnimBtn;
        private System.Windows.Forms.ListBox AnimBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.CheckBox isReferenceCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown refIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox animNameBox;
        private System.Windows.Forms.ListBox MovesetBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox refAnimNameBox;
        private System.Windows.Forms.GroupBox isRefBox;
        private System.Windows.Forms.Button SaveRefBtn;
        private System.Windows.Forms.ToolStripMenuItem hiddenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReferenceSettingsToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown refMovesetBox;
        private System.Windows.Forms.Button RevertRefBtn;
        private System.Windows.Forms.Button RestoreAnimBackupBtn;
    }
}

