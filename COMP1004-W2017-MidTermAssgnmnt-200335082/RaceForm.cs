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
        public RaceForm()
        {
            InitializeComponent();
        }

        private void HumanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Human1;
        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Dwarf1;
        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Elf1;
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnmnt_200335082.Properties.Resources.M_Halfling2;
        }
    }
}
