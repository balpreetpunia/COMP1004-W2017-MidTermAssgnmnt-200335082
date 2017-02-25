using COMP1004_W2017_MidTermAssgnmnt_200335082;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// App Name - Midterm Exam
/// Author's Name - Tom Tsiliopoulos & Balpreet Punia
/// App Creation Date - 2017-02-24
/// Student ID - 200335082
/// 
/// </summary>

namespace COMP1004_W2017_MidTermAssgnmnt_200335082
{
    public partial class FinalForm : Form
    {
        //Instance variables
        private List<TextBox> _abilitiesInFinalForm;
        private int _radioButtonInFinal;
        private String _jobType;
        private String _healthPoints;

        public FinalForm(List<TextBox> _abilitiesInJobForm, int _radioButtonInJob, String _jobType, String _healthPoints)
        {
            //Initializing variables
            InitializeComponent();
            _abilitiesInFinalForm = _abilitiesInJobForm;
            _radioButtonInFinal = _radioButtonInJob;
            this._jobType = _jobType;
            this._healthPoints = _healthPoints;

            //Classing method to display the information as soon as the form loads.
            CharacterImage();
            AdditionalInformation();
            Ability();
        }
        /// <summary>
        /// Method to determine the race
        /// </summary>
        /// <returns></returns>
        private string Race()
        {
            if (_radioButtonInFinal == 1)
            {
                return "Human";
            }
            else if (_radioButtonInFinal == 2)
            {
                return "Dwarf";
            }
            else if (_radioButtonInFinal == 3)
            {
                return "Elf";
                      }
            else
            {
                return "Halfling";
            }
        }
        /// <summary>
        /// Method to determine which image to use acording to the race.
        /// </summary>
        private void CharacterImage()
        {
            if(Race() == "Human")
            {
                FinalFormCharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Human1;
            }
            else if (Race() == "Dwarf")
            {
                FinalFormCharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Dwarf1;
            }
            else if (Race() == "Elf")
            {
                FinalFormCharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Elf1;
            }
            else
            {
                FinalFormCharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Halfling2;
            }
        }
        /// <summary>
        /// Method to display the contents of the additional information fields.
        /// </summary>
        private void AdditionalInformation()
        {
            JobTextBox.Text = _jobType;
            RaceTextBox.Text = Race();
            HealthPointsTextBox.Text = _healthPoints;
        }

        /// <summary>
        /// Method to display the content of the abilities fields.
        /// </summary>
        private void Ability()
        {
            STRTextBox.Text = _abilitiesInFinalForm[0].Text;
            DEXTextBox.Text = _abilitiesInFinalForm[1].Text;
            ENDTextBox.Text = _abilitiesInFinalForm[2].Text;
            INTTextBox.Text = _abilitiesInFinalForm[3].Text;
            PERTextBox.Text = _abilitiesInFinalForm[4].Text;
            CHATextBox.Text = _abilitiesInFinalForm[5].Text;
        }

        /// <summary>
        /// Event handler for the about menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.ShowDialog();
        }

        /// <summary>
        /// Event handler for the font menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.MaxSize = 18;
            fontDialog.MinSize = 10;
            fontDialog.ShowDialog();

            //Setting up font according to the selection.
            NameLabel.Font = fontDialog.Font;
            AgeLabel.Font = fontDialog.Font;
            HeightLabel.Font = fontDialog.Font;
            WeightLabel.Font = fontDialog.Font;
            JobLabel.Font = fontDialog.Font;
            RaceLabel.Font = fontDialog.Font;
            HealthPointsLabel.Font = fontDialog.Font;
            STRLabel.Font = fontDialog.Font;
            DEXLabel.Font = fontDialog.Font;
            ENDLabel.Font = fontDialog.Font;
            INTLabel.Font = fontDialog.Font;
            PERLabel.Font = fontDialog.Font;
            CHALabel.Font = fontDialog.Font;
            NameTextBox.Font = fontDialog.Font;
            AgeTextBox.Font = fontDialog.Font;
            HeightTextBox.Font = fontDialog.Font;
            WeightTextBox.Font = fontDialog.Font;
            JobTextBox.Font = fontDialog.Font;
            RaceTextBox.Font = fontDialog.Font;
            HealthPointsTextBox.Font = fontDialog.Font;
            STRTextBox.Font = fontDialog.Font;
            DEXTextBox.Font = fontDialog.Font;
            ENDTextBox.Font = fontDialog.Font;
            INTTextBox.Font = fontDialog.Font;
            PERTextBox.Font = fontDialog.Font;
            CHATextBox.Font = fontDialog.Font;
            CharacterInformationGroupBox.Font = fontDialog.Font;
            AdditionalInformationGroupBox.Font = fontDialog.Font;
            AbilitiesGroupBox.Font = fontDialog.Font;
        }

        /// <summary>
        /// Event handler for the exit menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for the print menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Print(),"Print Preview",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Print method to determine what gets printed.
        private String Print()
        {
            String print = ("Name: " + NameTextBox.Text + "\t" + "Job: " + _jobType + "\t" + "Race: " + Race() + "\t" + "Helth Points: " + _healthPoints + "\n"+
                            "ABILITIES"+ "\t" +"STR: "+ STRTextBox.Text+"    DEX: " + DEXTextBox.Text + "    ENF: " + ENDTextBox.Text + "    INT: " + INTTextBox.Text
                            + "    PER: " + PERTextBox.Text + "    CHA: " + CHATextBox.Text);
            return print;
        }

        /// <summary>
        /// Event handler for the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }
    }
}
