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
    public partial class RGB : Form
    {
        public RGB()
        {
            InitializeComponent(); // Variabler för varje trackbar skapas, colorpreview blir värdet av dem och upppdateras med invalidate.
            int RGBSliderR = trackBarR.Value;
            int RGBSliderG = trackBarG.Value;
            int RGBsliderB = trackBarB.Value;
            colorPreview.BackColor = Color.FromArgb(RGBSliderR, RGBSliderG, RGBsliderB);
            colorPreview.Invalidate();
        }
        private void buttonOkay_Click(object sender, EventArgs e) // om användaren trycker okay blir dialog okay och rutan stängs.
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonNotOk_Click(object sender, EventArgs e) // om användaren trycker Cancel stängs rutan.
        {
            Close();
        }

        private void trackBarR_ValueChanged(object sender, EventArgs e) //när en ändring sker på track bar R uppdateras färgen i color preview. Eftersom att trackbar är mellan -255 till 255 räknas värdet om så att det ligger mellan 0 - 255 istället beroende på sin tidigare värde. Detta är samma för alla trackbars.
        {
            int RGBSliderR = trackBarR.Value;
            int RGBSliderG = trackBarG.Value;
            int RGBsliderB = trackBarB.Value;
            int R = RGBSliderR + 255;
            R = R / 2;
            int G = RGBSliderG + 255;
            G = G / 2;
            int B = RGBsliderB + 255;
            B = B / 2;

            colorPreview.BackColor = Color.FromArgb(R, G, B);
            colorPreview.Invalidate();
        }

        private void trackBarG_ValueChanged(object sender, EventArgs e)
        {
            int RGBSliderR = trackBarR.Value;
            int RGBSliderG = trackBarG.Value;
            int RGBsliderB = trackBarB.Value;
            int R = RGBSliderR + 255;
            R = R / 2;
            int G = RGBSliderG + 255;
            G = G / 2;
            int B = RGBsliderB + 255;
            B = B / 2;

            colorPreview.BackColor = Color.FromArgb(R, G, B);
            colorPreview.Invalidate();
        }

        private void trackBarB_ValueChanged(object sender, EventArgs e)
        {
            int RGBSliderR = trackBarR.Value;
            int RGBSliderG = trackBarG.Value;
            int RGBsliderB = trackBarB.Value;
            int R = RGBSliderR + 255;
            R = R / 2;
            int G = RGBSliderG + 255;
            G = G / 2;
            int B = RGBsliderB + 255;
            B = B / 2;

            colorPreview.BackColor = Color.FromArgb(R, G, B);
            colorPreview.Invalidate();
        }
    }
}
