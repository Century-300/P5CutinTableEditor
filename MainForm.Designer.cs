
namespace CutinTableEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFrames = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSaveTableSM = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTableSM = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCoordsSM = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCoordsSM = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.UnpackButton = new System.Windows.Forms.Button();
            this.RepackButton = new System.Windows.Forms.Button();
            this.BaseFrame = new System.Windows.Forms.PictureBox();
            this.eyePicture = new System.Windows.Forms.PictureBox();
            this.entryListBox = new System.Windows.Forms.ListBox();
            this.entryCombo = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.numPosX = new System.Windows.Forms.NumericUpDown();
            this.posXLabel = new System.Windows.Forms.Label();
            this.posYLabel = new System.Windows.Forms.Label();
            this.numPosY = new System.Windows.Forms.NumericUpDown();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenu,
            this.editStripMenu,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileStripMenu
            // 
            this.FileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTable,
            this.OpenFrames,
            this.quickSaveTableSM,
            this.saveTableSM});
            this.FileStripMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FileStripMenu.Name = "FileStripMenu";
            this.FileStripMenu.Size = new System.Drawing.Size(38, 20);
            this.FileStripMenu.Text = "File";
            this.FileStripMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // OpenTable
            // 
            this.OpenTable.Name = "OpenTable";
            this.OpenTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.OpenTable.Size = new System.Drawing.Size(226, 22);
            this.OpenTable.Text = "Open Table";
            this.OpenTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenFrames
            // 
            this.OpenFrames.Name = "OpenFrames";
            this.OpenFrames.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.OpenFrames.Size = new System.Drawing.Size(226, 22);
            this.OpenFrames.Text = "Open Frames";
            this.OpenFrames.Click += new System.EventHandler(this.OpenFrames_Click);
            // 
            // quickSaveTableSM
            // 
            this.quickSaveTableSM.Name = "quickSaveTableSM";
            this.quickSaveTableSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.quickSaveTableSM.Size = new System.Drawing.Size(226, 22);
            this.quickSaveTableSM.Text = "Save Table";
            this.quickSaveTableSM.Click += new System.EventHandler(this.quickSaveTableSM_Click);
            // 
            // saveTableSM
            // 
            this.saveTableSM.Name = "saveTableSM";
            this.saveTableSM.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveTableSM.Size = new System.Drawing.Size(226, 22);
            this.saveTableSM.Text = "Save Table As";
            this.saveTableSM.Click += new System.EventHandler(this.saveTableSM_Click);
            // 
            // editStripMenu
            // 
            this.editStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCoordsSM,
            this.pasteCoordsSM});
            this.editStripMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editStripMenu.Name = "editStripMenu";
            this.editStripMenu.Size = new System.Drawing.Size(40, 20);
            this.editStripMenu.Text = "Edit";
            // 
            // copyCoordsSM
            // 
            this.copyCoordsSM.Name = "copyCoordsSM";
            this.copyCoordsSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyCoordsSM.Size = new System.Drawing.Size(216, 22);
            this.copyCoordsSM.Text = "Copy Coordinates";
            this.copyCoordsSM.Click += new System.EventHandler(this.copyCoordsSM_Click);
            // 
            // pasteCoordsSM
            // 
            this.pasteCoordsSM.Name = "pasteCoordsSM";
            this.pasteCoordsSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteCoordsSM.Size = new System.Drawing.Size(216, 22);
            this.pasteCoordsSM.Text = "Paste Coordinates";
            this.pasteCoordsSM.Click += new System.EventHandler(this.pasteCoordsSM_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeMenu,
            this.darkModeMenu,
            this.inverseButton});
            this.displayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.displayToolStripMenuItem.Text = "View";
            this.displayToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // lightModeMenu
            // 
            this.lightModeMenu.Name = "lightModeMenu";
            this.lightModeMenu.Size = new System.Drawing.Size(210, 22);
            this.lightModeMenu.Text = "Light Mode";
            this.lightModeMenu.Click += new System.EventHandler(this.lightModeMenu_Click);
            // 
            // darkModeMenu
            // 
            this.darkModeMenu.Name = "darkModeMenu";
            this.darkModeMenu.Size = new System.Drawing.Size(210, 22);
            this.darkModeMenu.Text = "Dark Mode";
            this.darkModeMenu.Click += new System.EventHandler(this.darkModeMenu_Click);
            // 
            // inverseButton
            // 
            this.inverseButton.Name = "inverseButton";
            this.inverseButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.inverseButton.Size = new System.Drawing.Size(210, 22);
            this.inverseButton.Text = "Inverse Direction";
            this.inverseButton.Click += new System.EventHandler(this.inverseButton_Click);
            // 
            // UnpackButton
            // 
            this.UnpackButton.Location = new System.Drawing.Point(12, 69);
            this.UnpackButton.Name = "UnpackButton";
            this.UnpackButton.Size = new System.Drawing.Size(197, 52);
            this.UnpackButton.TabIndex = 2;
            this.UnpackButton.TabStop = false;
            this.UnpackButton.Text = "Unpack Cutins";
            this.UnpackButton.UseVisualStyleBackColor = false;
            this.UnpackButton.Click += new System.EventHandler(this.UnpackButton_Click);
            // 
            // RepackButton
            // 
            this.RepackButton.Location = new System.Drawing.Point(12, 127);
            this.RepackButton.Name = "RepackButton";
            this.RepackButton.Size = new System.Drawing.Size(197, 52);
            this.RepackButton.TabIndex = 3;
            this.RepackButton.TabStop = false;
            this.RepackButton.Text = "Repack Cutins";
            this.RepackButton.UseVisualStyleBackColor = false;
            this.RepackButton.Click += new System.EventHandler(this.RepackButton_Click);
            // 
            // BaseFrame
            // 
            this.BaseFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseFrame.BackColor = System.Drawing.Color.Transparent;
            this.BaseFrame.Location = new System.Drawing.Point(235, 32);
            this.BaseFrame.Name = "BaseFrame";
            this.BaseFrame.Size = new System.Drawing.Size(872, 632);
            this.BaseFrame.TabIndex = 3;
            this.BaseFrame.TabStop = false;
            // 
            // eyePicture
            // 
            this.eyePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyePicture.BackColor = System.Drawing.Color.Transparent;
            this.eyePicture.Location = new System.Drawing.Point(0, 0);
            this.eyePicture.Name = "eyePicture";
            this.eyePicture.Size = new System.Drawing.Size(0, 0);
            this.eyePicture.TabIndex = 15;
            this.eyePicture.TabStop = false;
            // 
            // entryListBox
            // 
            this.entryListBox.FormattingEnabled = true;
            this.entryListBox.Location = new System.Drawing.Point(12, 195);
            this.entryListBox.Name = "entryListBox";
            this.entryListBox.Size = new System.Drawing.Size(197, 563);
            this.entryListBox.TabIndex = 4;
            this.entryListBox.SelectedIndexChanged += new System.EventHandler(this.entryListBox_SelectedIndexChanged);
            // 
            // entryCombo
            // 
            this.entryCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entryCombo.FormattingEnabled = true;
            this.entryCombo.Items.AddRange(new object[] {
            "Null",
            "Face Frame",
            "Eye Frame",
            "UNK Type_3",
            "Cutin Offset",
            "UNK Type 5",
            "UNK Type 6",
            "UNK Type 7",
            "UNK Type 8",
            "UNK Type 9",
            "UNK Type 10",
            "UNK Type"});
            this.entryCombo.Location = new System.Drawing.Point(762, 695);
            this.entryCombo.Name = "entryCombo";
            this.entryCombo.Size = new System.Drawing.Size(173, 21);
            this.entryCombo.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(698, 698);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(58, 13);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Entry Type";
            // 
            // numPosX
            // 
            this.numPosX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPosX.Location = new System.Drawing.Point(421, 696);
            this.numPosX.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.numPosX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numPosX.Name = "numPosX";
            this.numPosX.Size = new System.Drawing.Size(173, 20);
            this.numPosX.TabIndex = 9;
            this.numPosX.ValueChanged += new System.EventHandler(this.numPosX_ValueChanged);
            // 
            // posXLabel
            // 
            this.posXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.posXLabel.AutoSize = true;
            this.posXLabel.Location = new System.Drawing.Point(361, 698);
            this.posXLabel.Name = "posXLabel";
            this.posXLabel.Size = new System.Drawing.Size(54, 13);
            this.posXLabel.TabIndex = 10;
            this.posXLabel.Text = "X Position";
            // 
            // posYLabel
            // 
            this.posYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.posYLabel.AutoSize = true;
            this.posYLabel.Location = new System.Drawing.Point(361, 735);
            this.posYLabel.Name = "posYLabel";
            this.posYLabel.Size = new System.Drawing.Size(54, 13);
            this.posYLabel.TabIndex = 11;
            this.posYLabel.Text = "Y Position";
            // 
            // numPosY
            // 
            this.numPosY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPosY.Location = new System.Drawing.Point(421, 733);
            this.numPosY.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.numPosY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numPosY.Name = "numPosY";
            this.numPosY.Size = new System.Drawing.Size(173, 20);
            this.numPosY.TabIndex = 12;
            this.numPosY.ValueChanged += new System.EventHandler(this.numPosY_ValueChanged);
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "P5R (PC)",
            "P5R (PS4/Switch)",
            "P5 (PS3)",
            "P5 (4K)"});
            this.modeComboBox.Location = new System.Drawing.Point(83, 32);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(126, 21);
            this.modeComboBox.TabIndex = 13;
            this.modeComboBox.TabStop = false;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(12, 35);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(65, 13);
            this.modeLabel.TabIndex = 14;
            this.modeLabel.Text = "Game Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(235, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 632);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(698, 735);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 13);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Entry Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(762, 732);
            this.nameTextBox.MaxLength = 28;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1119, 776);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.eyePicture);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.numPosY);
            this.Controls.Add(this.posYLabel);
            this.Controls.Add(this.posXLabel);
            this.Controls.Add(this.numPosX);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.entryCombo);
            this.Controls.Add(this.entryListBox);
            this.Controls.Add(this.BaseFrame);
            this.Controls.Add(this.RepackButton);
            this.Controls.Add(this.UnpackButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1135, 815);
            this.Name = "MainForm";
            this.Text = "P5 Cutin Table Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeBaseFrame()
        {
            // 
            // BaseFrame
            // 
            this.BaseFrame.Size = new System.Drawing.Size(this.baseWidth, this.baseHeight);
        }
        private void InitializeEyeFrame()
        {
            // 
            // BaseFrame
            // 
            this.eyePicture.Size = new System.Drawing.Size(this.eyeWidth, this.eyeHeight);
        }

        private void updateEyeFrame()
        {
            this.eyePicture.Location = new System.Drawing.Point(ePosX, ePosY);
        }


        private void VisualMode (bool dMode)
            {

            switch (dMode)  //Wow century, how come mom lets you have two big ass switch cases in the designer?
            {
            case true:
                    this.modeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
                    this.modeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.modeComboBox.ForeColor = System.Drawing.Color.White;
                    this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
                    this.FileStripMenu.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.displayToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.OpenTable.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.OpenFrames.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.saveTableSM.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.saveTableSM.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.quickSaveTableSM.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.quickSaveTableSM.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.darkModeMenu.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.lightModeMenu.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.inverseButton.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.FileStripMenu.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.OpenTable.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.OpenFrames.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.darkModeMenu.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.lightModeMenu.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.inverseButton.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.displayToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.editStripMenu.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.editStripMenu.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.copyCoordsSM.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.copyCoordsSM.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.pasteCoordsSM.ForeColor = System.Drawing.Color.FromArgb(0, 175, 255);
                    this.pasteCoordsSM.BackColor = System.Drawing.Color.FromArgb(28, 39, 61);
                    this.UnpackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.UnpackButton.ForeColor = System.Drawing.Color.White;
                    this.RepackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.RepackButton.ForeColor = System.Drawing.Color.White;
                    this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
                    this.entryListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.entryListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
                    this.entryCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.entryCombo.ForeColor = System.Drawing.Color.White;
                    this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
                    this.numPosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.numPosX.ForeColor = System.Drawing.Color.White;
                    this.posXLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
                    this.posYLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
                    this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
                    this.numPosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.numPosY.ForeColor = System.Drawing.Color.White;
                    this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(27)))));
                    this.nameTextBox.ForeColor = System.Drawing.Color.White;
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
                    break;
            case false:

                    this.modeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    this.modeComboBox.BackColor = System.Drawing.Color.White;
                    this.modeComboBox.ForeColor = System.Drawing.Color.Black;
                    this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
                    this.FileStripMenu.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.FileStripMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.OpenTable.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.OpenTable.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.OpenFrames.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.OpenFrames.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.saveTableSM.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.saveTableSM.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.quickSaveTableSM.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.quickSaveTableSM.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.editStripMenu.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.editStripMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.copyCoordsSM.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.copyCoordsSM.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.pasteCoordsSM.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.pasteCoordsSM.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.darkModeMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.darkModeMenu.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.lightModeMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.lightModeMenu.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.inverseButton.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.inverseButton.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.displayToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.displayToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.UnpackButton.BackColor = System.Drawing.SystemColors.ControlLight;
                    this.UnpackButton.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.RepackButton.BackColor = System.Drawing.SystemColors.ControlLight;
                    this.RepackButton.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
                    this.entryListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.entryListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    this.entryCombo.BackColor = System.Drawing.Color.White;
                    this.entryCombo.ForeColor = System.Drawing.Color.Black;
                    this.TypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    this.numPosX.BackColor = System.Drawing.Color.White;
                    this.numPosX.ForeColor = System.Drawing.Color.Black;
                    this.posXLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    this.posYLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    this.numPosY.BackColor = System.Drawing.Color.White;
                    this.numPosY.ForeColor = System.Drawing.Color.Black;
                    this.nameTextBox.BackColor = System.Drawing.Color.White;
                    this.nameTextBox.ForeColor = System.Drawing.Color.Black;
                    this.BackColor = System.Drawing.SystemColors.Menu;
                    break;
            default:
            break;
            }

            }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenTable;
        private System.Windows.Forms.ToolStripMenuItem OpenFrames;
        private System.Windows.Forms.Button UnpackButton;
        private System.Windows.Forms.Button RepackButton;
        private System.Windows.Forms.PictureBox BaseFrame;
        private System.Windows.Forms.ListBox entryListBox;
        private System.Windows.Forms.ComboBox entryCombo;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.Label posXLabel;
        private System.Windows.Forms.Label posYLabel;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeMenu;
        private System.Windows.Forms.ToolStripMenuItem lightModeMenu;
        private System.Windows.Forms.ToolStripMenuItem inverseButton;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.PictureBox eyePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ToolStripMenuItem saveTableSM;
        private System.Windows.Forms.ToolStripMenuItem editStripMenu;
        private System.Windows.Forms.ToolStripMenuItem copyCoordsSM;
        private System.Windows.Forms.ToolStripMenuItem pasteCoordsSM;
        private System.Windows.Forms.ToolStripMenuItem quickSaveTableSM;
    }
}

