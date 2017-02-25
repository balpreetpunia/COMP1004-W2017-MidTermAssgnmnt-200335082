using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();
        private List<TextBox> _abilities;

        public AbilityForm()
        {
            InitializeComponent();

            // Instantiates a List of Text Boxes
            this._abilities = new List<TextBox>();
            this._initializeAbilities();
        }

        private void _initializeAbilities()
        {
            this._abilities.Add(STRTextBox);
            this._abilities.Add(DEXTextBox);
            this._abilities.Add(ENDTextBox);
            this._abilities.Add(INTTextBox);
            this._abilities.Add(PERTextBox);
            this._abilities.Add(CHATextBox);
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            // iterates through the TextBox List (_abilities)
            for (int ability = 0; ability < this._abilities.Count; ability++)
            {
                // Roll3D10 and assign the value to a temp variable
                int currentRoll = this.Roll3D10();

                this._abilities[ability].Text = currentRoll.ToString();
            }
        }
        /// <summary>
        /// Event handler for the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
                if (this._abilities[0].Text != "")
                {
                    RaceForm raceform = new RaceForm(_abilities);
                    raceform.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Please roll first!");
            
        }
    }
}
