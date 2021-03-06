﻿namespace COMP1004_W2017_MidTermAssgnmnt_200335082
{
    partial class FinalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AdditionalInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.HealthPointsTextBox = new System.Windows.Forms.TextBox();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.JobTextBox = new System.Windows.Forms.TextBox();
            this.HealthPointsLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.AbilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.CHATextBox = new System.Windows.Forms.TextBox();
            this.PERTextBox = new System.Windows.Forms.TextBox();
            this.INTTextBox = new System.Windows.Forms.TextBox();
            this.ENDTextBox = new System.Windows.Forms.TextBox();
            this.DEXTextBox = new System.Windows.Forms.TextBox();
            this.STRTextBox = new System.Windows.Forms.TextBox();
            this.CHALabel = new System.Windows.Forms.Label();
            this.PERLabel = new System.Windows.Forms.Label();
            this.INTLabel = new System.Windows.Forms.Label();
            this.ENDLabel = new System.Windows.Forms.Label();
            this.DEXLabel = new System.Windows.Forms.Label();
            this.STRLabel = new System.Windows.Forms.Label();
            this.FinalFormCharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.CharacterInformationGroupBox.SuspendLayout();
            this.AdditionalInformationGroupBox.SuspendLayout();
            this.AbilitiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinalFormCharacterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontStripMenuItem
            // 
            this.fontStripMenuItem.Name = "fontStripMenuItem";
            this.fontStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.fontStripMenuItem.Text = "Font";
            this.fontStripMenuItem.Click += new System.EventHandler(this.fontStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CharacterInformationGroupBox
            // 
            this.CharacterInformationGroupBox.Controls.Add(this.WeightTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.HeightTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.AgeTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.NameTextBox);
            this.CharacterInformationGroupBox.Controls.Add(this.WeightLabel);
            this.CharacterInformationGroupBox.Controls.Add(this.HeightLabel);
            this.CharacterInformationGroupBox.Controls.Add(this.AgeLabel);
            this.CharacterInformationGroupBox.Controls.Add(this.NameLabel);
            this.CharacterInformationGroupBox.Location = new System.Drawing.Point(13, 39);
            this.CharacterInformationGroupBox.Name = "CharacterInformationGroupBox";
            this.CharacterInformationGroupBox.Size = new System.Drawing.Size(370, 143);
            this.CharacterInformationGroupBox.TabIndex = 2;
            this.CharacterInformationGroupBox.TabStop = false;
            this.CharacterInformationGroupBox.Text = "Character Information";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(259, 83);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 26);
            this.WeightTextBox.TabIndex = 7;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(259, 38);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 26);
            this.HeightTextBox.TabIndex = 6;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(77, 82);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 26);
            this.AgeTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(77, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 26);
            this.NameTextBox.TabIndex = 4;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(190, 85);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(70, 20);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "Weight:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(193, 41);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(67, 20);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(29, 86);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(46, 20);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Age:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // AdditionalInformationGroupBox
            // 
            this.AdditionalInformationGroupBox.Controls.Add(this.HealthPointsTextBox);
            this.AdditionalInformationGroupBox.Controls.Add(this.RaceTextBox);
            this.AdditionalInformationGroupBox.Controls.Add(this.JobTextBox);
            this.AdditionalInformationGroupBox.Controls.Add(this.HealthPointsLabel);
            this.AdditionalInformationGroupBox.Controls.Add(this.RaceLabel);
            this.AdditionalInformationGroupBox.Controls.Add(this.JobLabel);
            this.AdditionalInformationGroupBox.Location = new System.Drawing.Point(389, 39);
            this.AdditionalInformationGroupBox.Name = "AdditionalInformationGroupBox";
            this.AdditionalInformationGroupBox.Size = new System.Drawing.Size(240, 143);
            this.AdditionalInformationGroupBox.TabIndex = 3;
            this.AdditionalInformationGroupBox.TabStop = false;
            this.AdditionalInformationGroupBox.Text = "Additional Information";
            // 
            // HealthPointsTextBox
            // 
            this.HealthPointsTextBox.Location = new System.Drawing.Point(131, 105);
            this.HealthPointsTextBox.Name = "HealthPointsTextBox";
            this.HealthPointsTextBox.ReadOnly = true;
            this.HealthPointsTextBox.Size = new System.Drawing.Size(100, 26);
            this.HealthPointsTextBox.TabIndex = 5;
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Location = new System.Drawing.Point(131, 68);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.ReadOnly = true;
            this.RaceTextBox.Size = new System.Drawing.Size(100, 26);
            this.RaceTextBox.TabIndex = 4;
            // 
            // JobTextBox
            // 
            this.JobTextBox.Location = new System.Drawing.Point(131, 31);
            this.JobTextBox.Name = "JobTextBox";
            this.JobTextBox.ReadOnly = true;
            this.JobTextBox.Size = new System.Drawing.Size(100, 26);
            this.JobTextBox.TabIndex = 3;
            // 
            // HealthPointsLabel
            // 
            this.HealthPointsLabel.AutoSize = true;
            this.HealthPointsLabel.Location = new System.Drawing.Point(11, 108);
            this.HealthPointsLabel.Name = "HealthPointsLabel";
            this.HealthPointsLabel.Size = new System.Drawing.Size(122, 20);
            this.HealthPointsLabel.TabIndex = 2;
            this.HealthPointsLabel.Text = "Health Points:";
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(77, 71);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(56, 20);
            this.RaceLabel.TabIndex = 1;
            this.RaceLabel.Text = "Race:";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(90, 34);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(43, 20);
            this.JobLabel.TabIndex = 0;
            this.JobLabel.Text = "Job:";
            // 
            // AbilitiesGroupBox
            // 
            this.AbilitiesGroupBox.Controls.Add(this.CHATextBox);
            this.AbilitiesGroupBox.Controls.Add(this.PERTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.INTTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.ENDTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.DEXTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.STRTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.CHALabel);
            this.AbilitiesGroupBox.Controls.Add(this.PERLabel);
            this.AbilitiesGroupBox.Controls.Add(this.INTLabel);
            this.AbilitiesGroupBox.Controls.Add(this.ENDLabel);
            this.AbilitiesGroupBox.Controls.Add(this.DEXLabel);
            this.AbilitiesGroupBox.Controls.Add(this.STRLabel);
            this.AbilitiesGroupBox.Location = new System.Drawing.Point(13, 188);
            this.AbilitiesGroupBox.Name = "AbilitiesGroupBox";
            this.AbilitiesGroupBox.Size = new System.Drawing.Size(231, 308);
            this.AbilitiesGroupBox.TabIndex = 4;
            this.AbilitiesGroupBox.TabStop = false;
            this.AbilitiesGroupBox.Text = "Abilities";
            // 
            // CHATextBox
            // 
            this.CHATextBox.Location = new System.Drawing.Point(105, 265);
            this.CHATextBox.Name = "CHATextBox";
            this.CHATextBox.ReadOnly = true;
            this.CHATextBox.Size = new System.Drawing.Size(100, 26);
            this.CHATextBox.TabIndex = 11;
            // 
            // PERTextBox
            // 
            this.PERTextBox.Location = new System.Drawing.Point(105, 219);
            this.PERTextBox.Name = "PERTextBox";
            this.PERTextBox.ReadOnly = true;
            this.PERTextBox.Size = new System.Drawing.Size(100, 26);
            this.PERTextBox.TabIndex = 10;
            // 
            // INTTextBox
            // 
            this.INTTextBox.Location = new System.Drawing.Point(105, 173);
            this.INTTextBox.Name = "INTTextBox";
            this.INTTextBox.ReadOnly = true;
            this.INTTextBox.Size = new System.Drawing.Size(100, 26);
            this.INTTextBox.TabIndex = 9;
            // 
            // ENDTextBox
            // 
            this.ENDTextBox.Location = new System.Drawing.Point(105, 127);
            this.ENDTextBox.Name = "ENDTextBox";
            this.ENDTextBox.ReadOnly = true;
            this.ENDTextBox.Size = new System.Drawing.Size(100, 26);
            this.ENDTextBox.TabIndex = 8;
            // 
            // DEXTextBox
            // 
            this.DEXTextBox.Location = new System.Drawing.Point(105, 81);
            this.DEXTextBox.Name = "DEXTextBox";
            this.DEXTextBox.ReadOnly = true;
            this.DEXTextBox.Size = new System.Drawing.Size(100, 26);
            this.DEXTextBox.TabIndex = 7;
            // 
            // STRTextBox
            // 
            this.STRTextBox.Location = new System.Drawing.Point(105, 35);
            this.STRTextBox.Name = "STRTextBox";
            this.STRTextBox.ReadOnly = true;
            this.STRTextBox.Size = new System.Drawing.Size(100, 26);
            this.STRTextBox.TabIndex = 6;
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(36, 268);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(46, 20);
            this.CHALabel.TabIndex = 5;
            this.CHALabel.Text = "CHA";
            // 
            // PERLabel
            // 
            this.PERLabel.AutoSize = true;
            this.PERLabel.Location = new System.Drawing.Point(37, 222);
            this.PERLabel.Name = "PERLabel";
            this.PERLabel.Size = new System.Drawing.Size(45, 20);
            this.PERLabel.TabIndex = 4;
            this.PERLabel.Text = "PER";
            // 
            // INTLabel
            // 
            this.INTLabel.AutoSize = true;
            this.INTLabel.Location = new System.Drawing.Point(45, 176);
            this.INTLabel.Name = "INTLabel";
            this.INTLabel.Size = new System.Drawing.Size(37, 20);
            this.INTLabel.TabIndex = 3;
            this.INTLabel.Text = "INT";
            // 
            // ENDLabel
            // 
            this.ENDLabel.AutoSize = true;
            this.ENDLabel.Location = new System.Drawing.Point(36, 130);
            this.ENDLabel.Name = "ENDLabel";
            this.ENDLabel.Size = new System.Drawing.Size(46, 20);
            this.ENDLabel.TabIndex = 2;
            this.ENDLabel.Text = "END";
            // 
            // DEXLabel
            // 
            this.DEXLabel.AutoSize = true;
            this.DEXLabel.Location = new System.Drawing.Point(36, 84);
            this.DEXLabel.Name = "DEXLabel";
            this.DEXLabel.Size = new System.Drawing.Size(46, 20);
            this.DEXLabel.TabIndex = 1;
            this.DEXLabel.Text = "DEX";
            // 
            // STRLabel
            // 
            this.STRLabel.AutoSize = true;
            this.STRLabel.Location = new System.Drawing.Point(38, 40);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(44, 20);
            this.STRLabel.TabIndex = 0;
            this.STRLabel.Text = "STR";
            // 
            // FinalFormCharacterPictureBox
            // 
            this.FinalFormCharacterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FinalFormCharacterPictureBox.Location = new System.Drawing.Point(298, 204);
            this.FinalFormCharacterPictureBox.Name = "FinalFormCharacterPictureBox";
            this.FinalFormCharacterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.FinalFormCharacterPictureBox.TabIndex = 1;
            this.FinalFormCharacterPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Location = new System.Drawing.Point(545, 475);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(78, 26);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FinalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AbilitiesGroupBox);
            this.Controls.Add(this.AdditionalInformationGroupBox);
            this.Controls.Add(this.CharacterInformationGroupBox);
            this.Controls.Add(this.FinalFormCharacterPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Character Selections";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CharacterInformationGroupBox.ResumeLayout(false);
            this.CharacterInformationGroupBox.PerformLayout();
            this.AdditionalInformationGroupBox.ResumeLayout(false);
            this.AdditionalInformationGroupBox.PerformLayout();
            this.AbilitiesGroupBox.ResumeLayout(false);
            this.AbilitiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinalFormCharacterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox FinalFormCharacterPictureBox;
        private System.Windows.Forms.GroupBox CharacterInformationGroupBox;
        private System.Windows.Forms.GroupBox AdditionalInformationGroupBox;
        private System.Windows.Forms.GroupBox AbilitiesGroupBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox HealthPointsTextBox;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.TextBox JobTextBox;
        private System.Windows.Forms.Label HealthPointsLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.TextBox CHATextBox;
        private System.Windows.Forms.TextBox PERTextBox;
        private System.Windows.Forms.TextBox INTTextBox;
        private System.Windows.Forms.TextBox ENDTextBox;
        private System.Windows.Forms.TextBox DEXTextBox;
        private System.Windows.Forms.TextBox STRTextBox;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.Label PERLabel;
        private System.Windows.Forms.Label INTLabel;
        private System.Windows.Forms.Label ENDLabel;
        private System.Windows.Forms.Label DEXLabel;
        private System.Windows.Forms.Label STRLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}