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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int RGBSliderR = trackBarR.Value;
            int RGBSliderG = trackBarG.Value;
            int RGBsliderB = trackBarB.Value;
            if (RGBSliderR != 0)
            {
                colorPreview.BackColor = Color.FromArgb(RGBSliderR, RGBSliderG, RGBsliderB);
            }
        }
        private void buttonOkay_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonNotOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
