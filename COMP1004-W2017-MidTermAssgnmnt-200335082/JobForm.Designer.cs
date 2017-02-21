namespace COMP1004_W2017_MidTermAssgnmnt_200335082
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectJobGroupBox = new System.Windows.Forms.GroupBox();
            this.SoldierRadioButton = new System.Windows.Forms.RadioButton();
            this.RogueRadioButton = new System.Windows.Forms.RadioButton();
            this.MagickerRadioButton = new System.Windows.Forms.RadioButton();
            this.CultistRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthPointsLabel = new System.Windows.Forms.Label();
            this.SelectJobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectJobGroupBox
            // 
            this.SelectJobGroupBox.Controls.Add(this.CultistRadioButton);
            this.SelectJobGroupBox.Controls.Add(this.MagickerRadioButton);
            this.SelectJobGroupBox.Controls.Add(this.RogueRadioButton);
            this.SelectJobGroupBox.Controls.Add(this.SoldierRadioButton);
            this.SelectJobGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectJobGroupBox.Location = new System.Drawing.Point(94, 73);
            this.SelectJobGroupBox.Name = "SelectJobGroupBox";
            this.SelectJobGroupBox.Size = new System.Drawing.Size(431, 207);
            this.SelectJobGroupBox.TabIndex = 4;
            this.SelectJobGroupBox.TabStop = false;
            this.SelectJobGroupBox.Text = "Select Job";
            // 
            // SoldierRadioButton
            // 
            this.SoldierRadioButton.AutoSize = true;
            this.SoldierRadioButton.Location = new System.Drawing.Point(35, 66);
            this.SoldierRadioButton.Name = "SoldierRadioButton";
            this.SoldierRadioButton.Size = new System.Drawing.Size(123, 35);
            this.SoldierRadioButton.TabIndex = 0;
            this.SoldierRadioButton.TabStop = true;
            this.SoldierRadioButton.Text = "Soldier";
            this.SoldierRadioButton.UseVisualStyleBackColor = true;
            this.SoldierRadioButton.CheckedChanged += new System.EventHandler(this.SoldierRadioButton_CheckedChanged);
            // 
            // RogueRadioButton
            // 
            this.RogueRadioButton.AutoSize = true;
            this.RogueRadioButton.Location = new System.Drawing.Point(280, 66);
            this.RogueRadioButton.Name = "RogueRadioButton";
            this.RogueRadioButton.Size = new System.Drawing.Size(117, 35);
            this.RogueRadioButton.TabIndex = 1;
            this.RogueRadioButton.TabStop = true;
            this.RogueRadioButton.Text = "Rogue";
            this.RogueRadioButton.UseVisualStyleBackColor = true;
            this.RogueRadioButton.CheckedChanged += new System.EventHandler(this.RogueRadioButton_CheckedChanged);
            // 
            // MagickerRadioButton
            // 
            this.MagickerRadioButton.AutoSize = true;
            this.MagickerRadioButton.Location = new System.Drawing.Point(35, 141);
            this.MagickerRadioButton.Name = "MagickerRadioButton";
            this.MagickerRadioButton.Size = new System.Drawing.Size(150, 35);
            this.MagickerRadioButton.TabIndex = 2;
            this.MagickerRadioButton.TabStop = true;
            this.MagickerRadioButton.Text = "Magicker";
            this.MagickerRadioButton.UseVisualStyleBackColor = true;
            this.MagickerRadioButton.CheckedChanged += new System.EventHandler(this.MagickerRadioButton_CheckedChanged);
            // 
            // CultistRadioButton
            // 
            this.CultistRadioButton.AutoSize = true;
            this.CultistRadioButton.Location = new System.Drawing.Point(280, 141);
            this.CultistRadioButton.Name = "CultistRadioButton";
            this.CultistRadioButton.Size = new System.Drawing.Size(116, 35);
            this.CultistRadioButton.TabIndex = 3;
            this.CultistRadioButton.TabStop = true;
            this.CultistRadioButton.Text = "Cultist";
            this.CultistRadioButton.UseVisualStyleBackColor = true;
            this.CultistRadioButton.CheckedChanged += new System.EventHandler(this.CultistRadioButton_CheckedChanged);
            // 
            // HealthPointsLabel
            // 
            this.HealthPointsLabel.AutoSize = true;
            this.HealthPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthPointsLabel.Location = new System.Drawing.Point(94, 337);
            this.HealthPointsLabel.Name = "HealthPointsLabel";
            this.HealthPointsLabel.Size = new System.Drawing.Size(198, 31);
            this.HealthPointsLabel.TabIndex = 5;
            this.HealthPointsLabel.Text = "Health Points:";
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.HealthPointsLabel);
            this.Controls.Add(this.SelectJobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.SelectJobGroupBox.ResumeLayout(false);
            this.SelectJobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox SelectJobGroupBox;
        private System.Windows.Forms.RadioButton CultistRadioButton;
        private System.Windows.Forms.RadioButton MagickerRadioButton;
        private System.Windows.Forms.RadioButton RogueRadioButton;
        private System.Windows.Forms.RadioButton SoldierRadioButton;
        private System.Windows.Forms.Label HealthPointsLabel;
    }
}