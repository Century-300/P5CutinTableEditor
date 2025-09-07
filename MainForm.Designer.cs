
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            OpenTable = new System.Windows.Forms.ToolStripMenuItem();
            OpenFrames = new System.Windows.Forms.ToolStripMenuItem();
            quickSaveTableSM = new System.Windows.Forms.ToolStripMenuItem();
            saveTableSM = new System.Windows.Forms.ToolStripMenuItem();
            editStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            copyCoordsSM = new System.Windows.Forms.ToolStripMenuItem();
            pasteCoordsSM = new System.Windows.Forms.ToolStripMenuItem();
            displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lightModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            darkModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            inverseButton = new System.Windows.Forms.ToolStripMenuItem();
            scaleMenu = new System.Windows.Forms.ToolStripComboBox();
            UnpackButton = new System.Windows.Forms.Button();
            RepackButton = new System.Windows.Forms.Button();
            entryListBox = new System.Windows.Forms.ListBox();
            modeComboBox = new System.Windows.Forms.ComboBox();
            modeLabel = new System.Windows.Forms.Label();
            tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            tlp_Params = new System.Windows.Forms.TableLayoutPanel();
            entryCombo = new System.Windows.Forms.ComboBox();
            TypeLabel = new System.Windows.Forms.Label();
            numPosX = new System.Windows.Forms.NumericUpDown();
            numPosY = new System.Windows.Forms.NumericUpDown();
            nameLabel = new System.Windows.Forms.Label();
            posYLabel = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            posXLabel = new System.Windows.Forms.Label();
            pnl_PictureBoxContainer = new System.Windows.Forms.Panel();
            pictureBox_BaseImage = new System.Windows.Forms.PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel_Main.SuspendLayout();
            tlp_Params.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPosY).BeginInit();
            pnl_PictureBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BaseImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { FileStripMenu, editStripMenu, displayToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(982, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileStripMenu
            // 
            FileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenTable, OpenFrames, quickSaveTableSM, saveTableSM });
            FileStripMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            FileStripMenu.Name = "FileStripMenu";
            FileStripMenu.Size = new System.Drawing.Size(47, 24);
            FileStripMenu.Text = "File";
            FileStripMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // OpenTable
            // 
            OpenTable.Name = "OpenTable";
            OpenTable.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T;
            OpenTable.Size = new System.Drawing.Size(284, 26);
            OpenTable.Text = "Open Table";
            OpenTable.Click += OpenTable_Click;
            // 
            // OpenFrames
            // 
            OpenFrames.Name = "OpenFrames";
            OpenFrames.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F;
            OpenFrames.Size = new System.Drawing.Size(284, 26);
            OpenFrames.Text = "Open Frames";
            OpenFrames.Click += OpenFrames_Click;
            // 
            // quickSaveTableSM
            // 
            quickSaveTableSM.Name = "quickSaveTableSM";
            quickSaveTableSM.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            quickSaveTableSM.Size = new System.Drawing.Size(284, 26);
            quickSaveTableSM.Text = "Save Table";
            quickSaveTableSM.Click += quickSaveTableSM_Click;
            // 
            // saveTableSM
            // 
            saveTableSM.Name = "saveTableSM";
            saveTableSM.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            saveTableSM.Size = new System.Drawing.Size(284, 26);
            saveTableSM.Text = "Save Table As";
            saveTableSM.Click += saveTableSM_Click;
            // 
            // editStripMenu
            // 
            editStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyCoordsSM, pasteCoordsSM });
            editStripMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            editStripMenu.Name = "editStripMenu";
            editStripMenu.Size = new System.Drawing.Size(50, 24);
            editStripMenu.Text = "Edit";
            // 
            // copyCoordsSM
            // 
            copyCoordsSM.Name = "copyCoordsSM";
            copyCoordsSM.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyCoordsSM.Size = new System.Drawing.Size(273, 26);
            copyCoordsSM.Text = "Copy Coordinates";
            copyCoordsSM.Click += copyCoordsSM_Click;
            // 
            // pasteCoordsSM
            // 
            pasteCoordsSM.Name = "pasteCoordsSM";
            pasteCoordsSM.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteCoordsSM.Size = new System.Drawing.Size(273, 26);
            pasteCoordsSM.Text = "Paste Coordinates";
            pasteCoordsSM.Click += pasteCoordsSM_Click;
            // 
            // displayToolStripMenuItem
            // 
            displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { lightModeMenu, darkModeMenu, inverseButton, scaleMenu });
            displayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            displayToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            displayToolStripMenuItem.Text = "View";
            displayToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // lightModeMenu
            // 
            lightModeMenu.Name = "lightModeMenu";
            lightModeMenu.Size = new System.Drawing.Size(261, 26);
            lightModeMenu.Text = "Light Mode";
            lightModeMenu.Click += lightModeMenu_Click;
            // 
            // darkModeMenu
            // 
            darkModeMenu.Name = "darkModeMenu";
            darkModeMenu.Size = new System.Drawing.Size(261, 26);
            darkModeMenu.Text = "Dark Mode";
            darkModeMenu.Click += darkModeMenu_Click;
            // 
            // inverseButton
            // 
            inverseButton.Name = "inverseButton";
            inverseButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I;
            inverseButton.Size = new System.Drawing.Size(261, 26);
            inverseButton.Text = "Inverse Direction";
            inverseButton.Click += inverseButton_Click;
            // 
            // scaleMenu
            // 
            scaleMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            scaleMenu.Items.AddRange(new object[] { "100", "75", "50", "25", "15", "10", "5", "2" });
            scaleMenu.Name = "scaleMenu";
            scaleMenu.Size = new System.Drawing.Size(121, 28);
            // 
            // UnpackButton
            // 
            tableLayoutPanel_Main.SetColumnSpan(UnpackButton, 2);
            UnpackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            UnpackButton.Location = new System.Drawing.Point(4, 113);
            UnpackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            UnpackButton.Name = "UnpackButton";
            UnpackButton.Size = new System.Drawing.Size(187, 98);
            UnpackButton.TabIndex = 2;
            UnpackButton.TabStop = false;
            UnpackButton.Text = "Unpack Cutins";
            UnpackButton.UseVisualStyleBackColor = false;
            UnpackButton.Click += UnpackButton_Click;
            // 
            // RepackButton
            // 
            tableLayoutPanel_Main.SetColumnSpan(RepackButton, 2);
            RepackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            RepackButton.Location = new System.Drawing.Point(4, 221);
            RepackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RepackButton.Name = "RepackButton";
            RepackButton.Size = new System.Drawing.Size(187, 98);
            RepackButton.TabIndex = 3;
            RepackButton.TabStop = false;
            RepackButton.Text = "Repack Cutins";
            RepackButton.UseVisualStyleBackColor = false;
            RepackButton.Click += RepackButton_Click;
            // 
            // entryListBox
            // 
            tableLayoutPanel_Main.SetColumnSpan(entryListBox, 2);
            entryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            entryListBox.FormattingEnabled = true;
            entryListBox.Location = new System.Drawing.Point(4, 329);
            entryListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            entryListBox.Name = "entryListBox";
            tableLayoutPanel_Main.SetRowSpan(entryListBox, 2);
            entryListBox.Size = new System.Drawing.Size(187, 389);
            entryListBox.TabIndex = 4;
            entryListBox.SelectedIndexChanged += entryListBox_SelectedIndexChanged;
            // 
            // modeComboBox
            // 
            modeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            modeComboBox.FormattingEnabled = true;
            modeComboBox.Items.AddRange(new object[] { "P5R (PC)", "P5R (PS4/Switch)", "P5 (PS3)", "P5 (4K)" });
            modeComboBox.Location = new System.Drawing.Point(82, 40);
            modeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new System.Drawing.Size(109, 28);
            modeComboBox.TabIndex = 13;
            modeComboBox.TabStop = false;
            modeComboBox.SelectedIndexChanged += modeComboBox_SelectedIndexChanged;
            // 
            // modeLabel
            // 
            modeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            modeLabel.AutoSize = true;
            modeLabel.Location = new System.Drawing.Point(22, 34);
            modeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new System.Drawing.Size(52, 40);
            modeLabel.TabIndex = 14;
            modeLabel.Text = "Game Mode";
            // 
            // tableLayoutPanel_Main
            // 
            tableLayoutPanel_Main.ColumnCount = 3;
            tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel_Main.Controls.Add(modeLabel, 0, 0);
            tableLayoutPanel_Main.Controls.Add(modeComboBox, 1, 0);
            tableLayoutPanel_Main.Controls.Add(UnpackButton, 0, 1);
            tableLayoutPanel_Main.Controls.Add(RepackButton, 0, 2);
            tableLayoutPanel_Main.Controls.Add(entryListBox, 0, 3);
            tableLayoutPanel_Main.Controls.Add(tlp_Params, 2, 4);
            tableLayoutPanel_Main.Controls.Add(pnl_PictureBoxContainer, 2, 0);
            tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 30);
            tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            tableLayoutPanel_Main.RowCount = 5;
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel_Main.Size = new System.Drawing.Size(982, 723);
            tableLayoutPanel_Main.TabIndex = 19;
            // 
            // tlp_Params
            // 
            tlp_Params.ColumnCount = 4;
            tlp_Params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlp_Params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tlp_Params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlp_Params.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tlp_Params.Controls.Add(entryCombo, 3, 0);
            tlp_Params.Controls.Add(TypeLabel, 2, 0);
            tlp_Params.Controls.Add(numPosX, 1, 0);
            tlp_Params.Controls.Add(numPosY, 1, 1);
            tlp_Params.Controls.Add(nameLabel, 2, 1);
            tlp_Params.Controls.Add(posYLabel, 0, 1);
            tlp_Params.Controls.Add(nameTextBox, 3, 1);
            tlp_Params.Controls.Add(posXLabel, 0, 0);
            tlp_Params.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_Params.Location = new System.Drawing.Point(198, 507);
            tlp_Params.Name = "tlp_Params";
            tlp_Params.RowCount = 2;
            tlp_Params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Params.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Params.Size = new System.Drawing.Size(781, 213);
            tlp_Params.TabIndex = 17;
            // 
            // entryCombo
            // 
            entryCombo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            entryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            entryCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            entryCombo.FormattingEnabled = true;
            entryCombo.Items.AddRange(new object[] { "Null", "Face Frame", "Eye Frame", "UNK Type_3", "Cutin Offset", "UNK Type 5", "UNK Type 6", "UNK Type 7", "UNK Type 8", "UNK Type 9", "UNK Type 10", "UNK Type" });
            entryCombo.Location = new System.Drawing.Point(511, 39);
            entryCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            entryCombo.Name = "entryCombo";
            entryCombo.Size = new System.Drawing.Size(266, 28);
            entryCombo.TabIndex = 19;
            // 
            // TypeLabel
            // 
            TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new System.Drawing.Point(426, 43);
            TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(77, 20);
            TypeLabel.TabIndex = 20;
            TypeLabel.Text = "Entry Type";
            // 
            // numPosX
            // 
            numPosX.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numPosX.Location = new System.Drawing.Point(121, 39);
            numPosX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numPosX.Maximum = new decimal(new int[] { int.MinValue, 0, 0, 0 });
            numPosX.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            numPosX.Name = "numPosX";
            numPosX.Size = new System.Drawing.Size(265, 27);
            numPosX.TabIndex = 21;
            numPosX.ValueChanged += numPosX_ValueChanged;
            // 
            // numPosY
            // 
            numPosY.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numPosY.Location = new System.Drawing.Point(121, 146);
            numPosY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numPosY.Maximum = new decimal(new int[] { int.MinValue, 0, 0, 0 });
            numPosY.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            numPosY.Name = "numPosY";
            numPosY.Size = new System.Drawing.Size(265, 27);
            numPosY.TabIndex = 24;
            numPosY.ValueChanged += numPosY_ValueChanged;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(417, 149);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(86, 20);
            nameLabel.TabIndex = 25;
            nameLabel.Text = "Entry Name";
            // 
            // posYLabel
            // 
            posYLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            posYLabel.AutoSize = true;
            posYLabel.Location = new System.Drawing.Point(40, 149);
            posYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            posYLabel.Name = "posYLabel";
            posYLabel.Size = new System.Drawing.Size(73, 20);
            posYLabel.TabIndex = 23;
            posYLabel.Text = "Y Position";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nameTextBox.Location = new System.Drawing.Point(511, 146);
            nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nameTextBox.MaxLength = 28;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(266, 27);
            nameTextBox.TabIndex = 26;
            // 
            // posXLabel
            // 
            posXLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            posXLabel.AutoSize = true;
            posXLabel.Location = new System.Drawing.Point(39, 43);
            posXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            posXLabel.Name = "posXLabel";
            posXLabel.Size = new System.Drawing.Size(74, 20);
            posXLabel.TabIndex = 22;
            posXLabel.Text = "X Position";
            // 
            // pnl_PictureBoxContainer
            // 
            pnl_PictureBoxContainer.AutoScroll = true;
            pnl_PictureBoxContainer.AutoSize = true;
            pnl_PictureBoxContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_PictureBoxContainer.BackColor = System.Drawing.Color.SlateGray;
            pnl_PictureBoxContainer.Controls.Add(pictureBox_BaseImage);
            pnl_PictureBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_PictureBoxContainer.Location = new System.Drawing.Point(198, 3);
            pnl_PictureBoxContainer.Name = "pnl_PictureBoxContainer";
            tableLayoutPanel_Main.SetRowSpan(pnl_PictureBoxContainer, 4);
            pnl_PictureBoxContainer.Size = new System.Drawing.Size(781, 498);
            pnl_PictureBoxContainer.TabIndex = 18;
            // 
            // pictureBox_BaseImage
            // 
            pictureBox_BaseImage.Location = new System.Drawing.Point(350, 99);
            pictureBox_BaseImage.Name = "pictureBox_BaseImage";
            pictureBox_BaseImage.Size = new System.Drawing.Size(125, 62);
            pictureBox_BaseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox_BaseImage.TabIndex = 0;
            pictureBox_BaseImage.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            ClientSize = new System.Drawing.Size(982, 753);
            Controls.Add(tableLayoutPanel_Main);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MinimumSize = new System.Drawing.Size(1000, 800);
            Name = "MainForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            Text = "P5 Cutin Table Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel_Main.ResumeLayout(false);
            tableLayoutPanel_Main.PerformLayout();
            tlp_Params.ResumeLayout(false);
            tlp_Params.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPosY).EndInit();
            pnl_PictureBoxContainer.ResumeLayout(false);
            pnl_PictureBoxContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BaseImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


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
        private System.Windows.Forms.ListBox entryListBox;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeMenu;
        private System.Windows.Forms.ToolStripMenuItem lightModeMenu;
        private System.Windows.Forms.ToolStripMenuItem inverseButton;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ToolStripMenuItem saveTableSM;
        private System.Windows.Forms.ToolStripMenuItem editStripMenu;
        private System.Windows.Forms.ToolStripMenuItem copyCoordsSM;
        private System.Windows.Forms.ToolStripMenuItem pasteCoordsSM;
        private System.Windows.Forms.ToolStripMenuItem quickSaveTableSM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Params;
        private System.Windows.Forms.ComboBox entryCombo;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label posYLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label posXLabel;
        private System.Windows.Forms.Panel pnl_PictureBoxContainer;
        private System.Windows.Forms.PictureBox pictureBox_BaseImage;
        private System.Windows.Forms.ToolStripComboBox scaleMenu;
    }
}

