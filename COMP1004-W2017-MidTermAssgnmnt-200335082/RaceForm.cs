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
    public partial class RaceForm : Form
    {
        private List<TextBox> _abilitiesInRaceForm;
        private int _radioButtonInRace = 0;

        
        /// <summary>
        /// Initializing _abilities
        /// </summary>
        /// <param name="_abilities"></param>
        public RaceForm(List<TextBox> _abilities)
        {
            InitializeComponent();
            _abilitiesInRaceForm = _abilities;
        }

        
        /// <summary>
        /// Event handler to display picture and to increment or decrement abilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void HumanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Human1;
            
            for(int ability = 0; ability < _abilitiesInRaceForm.Count; ability++)
            {
                // Passing the new updated ability throught the ability validation method to check that they dont increment more than 50 and less than 3.
                _abilitiesInRaceForm[ability].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[ability].Text) + 5));
            }

            RacialBonusTextBox.Text = "All abilities increased by +5";
            _radioButtonInRace = 1;
        }
        /// <summary>
        /// Event handler to display picture and to increment or decrement abilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Dwarf1;

            _abilitiesInRaceForm[0].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[0].Text) + 20));
            _abilitiesInRaceForm[4].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[4].Text) + 20));

            _abilitiesInRaceForm[5].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[5].Text) - 10));

            RacialBonusTextBox.Text = "STR +20 PER +20 CHA -10";
            _radioButtonInRace = 2;

        }
        /// <summary>
        /// Event handler to display picture and to increment or decrement abilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Elf1;

            _abilitiesInRaceForm[1].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[1].Text) + 15));
            _abilitiesInRaceForm[5].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[5].Text) + 15));

            RacialBonusTextBox.Text = "DEX +15 CHA +15";

            _radioButtonInRace = 3;
        }
        /// <summary>
        /// Event handler to display picture and to increment or decrement abilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Halfling2;

            _abilitiesInRaceForm[1].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[1].Text) + 20));
            _abilitiesInRaceForm[3].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[3].Text) + 20));

            _abilitiesInRaceForm[0].Text = Convert.ToString(Ability_Validation(int.Parse(_abilitiesInRaceForm[0].Text) - 10));

            RacialBonusTextBox.Text = "DEX +20 INT +20 STR -10";

            _radioButtonInRace = 4;
        }

        /// <summary>
        /// Method to validate that the ability does not increment more than 50 or less than 3.
        /// </summary>
        /// <param name="ability"></param>
        /// <returns></returns>
        private int Ability_Validation(int ability)
        {
            if(ability < 2 && ability < 51)
            {
                return ability;
            }
            else if(ability <2)
            {
                return ability = 3;
            }
            else
            {
                return ability = 50;
            }
        }
        /// <summary>
        /// Event handler for next button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (RacialBonusTextBox.Text != "")
            {
                JobForm jobform = new JobForm(_abilitiesInRaceForm, _radioButtonInRace);
                jobform.ShowDialog();

                this.Close();
            }
            else
                MessageBox.Show("Please select a race first!");
            
        }
        
        
    }

}
