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

        public JobForm(List<TextBox> _abilitiesAsParameter)
        {
            InitializeComponent();
            _abilitiesInJobForm = _abilitiesAsParameter;
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[2].Text) + 30);
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[1].Text) + 28);
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[3].Text) + 15);
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsLabel.Text = "Health Points: " + Convert.ToString(int.Parse(_abilitiesInJobForm[5].Text) + 24);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalform = new FinalForm(_abilitiesInJobForm);
            finalform.ShowDialog();
            this.Close();
        }
    }
}
