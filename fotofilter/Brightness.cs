using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotofilter
{
    public partial class Brightness : Form
    {
        public Brightness()
        {
            InitializeComponent();
        }
        private void buttonOkay_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonNotOk_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
