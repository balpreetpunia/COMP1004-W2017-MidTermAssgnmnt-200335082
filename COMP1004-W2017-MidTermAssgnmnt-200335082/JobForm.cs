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
        List<TextBox> _abilitiesInJobForm;

        public JobForm(List<TextBox> _abilitiesAsParameter)
        {
            InitializeComponent();
            _abilitiesInJobForm = _abilitiesAsParameter;
        }
    }
}
