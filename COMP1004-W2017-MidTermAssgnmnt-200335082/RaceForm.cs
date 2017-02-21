using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnmnt_200335082
{
    public partial class RaceForm : Form
    {
        private List<TextBox> _abilitiesInRaceForm;
        private int _radioButtonInRace = 0;

        

        public RaceForm(List<TextBox> _abilities)
        {
            InitializeComponent();
            _abilitiesInRaceForm = _abilities;
        }

        

        private void HumanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Human1;
            
            for(int ability = 0; ability < _abilitiesInRaceForm.Count; ability++)
            {
                _abilitiesInRaceForm[ability].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[ability].Text) + 5);
            }

            RacialBonusTextBox.Text = "All abilities increased by +5";
            _radioButtonInRace = 1;
        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Dwarf1;

            _abilitiesInRaceForm[0].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[0].Text) + 20);
            _abilitiesInRaceForm[4].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[4].Text) + 20);

            _abilitiesInRaceForm[5].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[5].Text) - 10);

            RacialBonusTextBox.Text = "STR +20 PER +20 CHA -10";
            _radioButtonInRace = 2;

        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Elf1;

            _abilitiesInRaceForm[1].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[1].Text) + 15);
            _abilitiesInRaceForm[5].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[5].Text) + 15);

            RacialBonusTextBox.Text = "DEX +15 CHA +15";

            _radioButtonInRace = 3;
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Halfling2;

            _abilitiesInRaceForm[1].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[1].Text) + 20);
            _abilitiesInRaceForm[3].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[3].Text) + 20);

            _abilitiesInRaceForm[0].Text = Convert.ToString(int.Parse(_abilitiesInRaceForm[0].Text) - 10);

            RacialBonusTextBox.Text = "DEX +20 INT +20 STR -10";

            _radioButtonInRace = 4;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            JobForm jobform = new JobForm(_abilitiesInRaceForm, _radioButtonInRace);
            jobform.ShowDialog();

            this.Close();
        }

        
    }

}
