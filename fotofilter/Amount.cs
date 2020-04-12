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
    public partial class Amount : Form
    {
        public Amount()
        {
            InitializeComponent();
        }

        private void buttonNotOk_Click(object sender, EventArgs e) //Om användaren trycker cancel stängs rutan
        {
            Close();
        }
        private void buttonOkay_Click(object sender, EventArgs e) //Om användaren trycker okay blir dialogresult okay och rutan stängs
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
