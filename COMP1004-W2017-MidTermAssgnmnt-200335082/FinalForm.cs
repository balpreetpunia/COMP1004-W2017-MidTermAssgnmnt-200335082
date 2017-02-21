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

namespace COMP1004_W2017_MidTermAssgnmnt_200335082
{
    public partial class FinalForm : Form
    {
        private List<TextBox> _abilitiesInFinalForm;
        private int _radioButtonInFinal;
        private String _jobType;
        private String _healthPoints;

        public FinalForm(List<TextBox> _abilitiesInJobForm, int _radioButtonInJob, String _jobType, String _healthPoints)
        {
            InitializeComponent();
            _abilitiesInFinalForm = _abilitiesInJobForm;
            _radioButtonInFinal = _radioButtonInJob;
            this._jobType = _jobType;
            this._healthPoints = _healthPoints;
            CharacterImage();
            AdditionalInformation();
            Ability();
        }

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

        private void AdditionalInformation()
        {
            JobTextBox.Text = _jobType;
            RaceTextBox.Text = Race();
            HealthPointsTextBox.Text = _healthPoints;
        }

        private void Ability()
        {
            STRTextBox.Text = _abilitiesInFinalForm[0].Text;
            DEXTextBox.Text = _abilitiesInFinalForm[1].Text;
            ENDTextBox.Text = _abilitiesInFinalForm[2].Text;
            INTTextBox.Text = _abilitiesInFinalForm[3].Text;
            PERTextBox.Text = _abilitiesInFinalForm[4].Text;
            CHATextBox.Text = _abilitiesInFinalForm[5].Text;
        }
    }
}
