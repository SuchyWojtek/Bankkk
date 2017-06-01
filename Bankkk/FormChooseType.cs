using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankkk
{
    public partial class FormChooseType : Form
    {
        public FormChooseType()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (radBtnPriv.Checked)
            {
                this.Hide();
                FormNewAccount f = new FormNewAccount();
                f.Show();
            }
            if (radBtnFirm.Checked)
            {
                this.Hide();
                FormNewFirmAccount f = new FormNewFirmAccount();
                f.Show();
            }
        }
    }
}
