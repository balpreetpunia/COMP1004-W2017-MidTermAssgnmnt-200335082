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
    public partial class JobForm : Form
    {
        private List<TextBox> _abilitiesInJobForm;
        private int _radioButtonInJob;
        private String _jobType = "";
        private String _healthPoints;

        public JobForm(List<TextBox> _abilitiesInRaceForm, int _radioButtonInRace)
        {
            InitializeComponent();
            _abilitiesInJobForm = _abilitiesInRaceForm;
            _radioButtonInJob = _radioButtonInRace;
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[2].Text) + 30);
            _jobType = "Soldier";
            _healthPoints = Convert.ToString(int.Parse(_abilitiesInJobForm[2].Text) + 30);
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[1].Text) + 28);
            _jobType = "Rogue";
            _healthPoints = Convert.ToString(int.Parse(_abilitiesInJobForm[1].Text) + 28);
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[3].Text) + 15);
            _jobType = "Magicker";
            _healthPoints = Convert.ToString(int.Parse(_abilitiesInJobForm[3].Text) + 15);
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[5].Text) + 24);
            _jobType = "Cultist";
            _healthPoints = Convert.ToString(int.Parse(_abilitiesInJobForm[5].Text) + 24);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (_jobType != "")
            {
                FinalForm finalform = new FinalForm(_abilitiesInJobForm, _radioButtonInJob, _jobType, _healthPoints);
                finalform.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Please select a job first!");
        }
    }
}
