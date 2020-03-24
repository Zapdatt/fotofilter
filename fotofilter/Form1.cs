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
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }
        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFile.FileName);
                pbImage.Image = bitmap;
                pbImage.Width = bitmap.Width;
                pbImage.Height = bitmap.Height;
            }
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skiftaFärgkanalerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkiftaFärger();
        }

        private void monochromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monochrome();
        }

        private void inverteraFärgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InverteraFärger();
        }

        private void RGBFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                int RGBSliderR = form2.trackBarR.Value;
                int RGBSliderG = form2.trackBarG.Value;
                int RGBsliderB = form2.trackBarB.Value;
                RGBVärden(RGBSliderR, RGBSliderG, RGBsliderB);
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap.Save("minFil.png");
        }

        private void svenskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "File";
            openImageToolStripMenuItem.Text = "Öppna bild";
            sparaToolStripMenuItem.Text = "Spara fil";
            avslutaToolStripMenuItem.Text = "Avsluta";
            filterToolStripMenuItem.Text = "Filter";
            skiftaFärgkanalerToolStripMenuItem.Text = "Skifta färger";
            inverteraFärgerToolStripMenuItem.Text = "Inverterade Färger";
            monochromeToolStripMenuItem.Text = "Svartvit";
            RGBFilterToolStripMenuItem.Text = "RGB Värden";
            languageToolStripMenuItem.Text = "Språk";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "Fil";
            openImageToolStripMenuItem.Text = "Open Image";
            sparaToolStripMenuItem.Text = "Save file";
            avslutaToolStripMenuItem.Text = "Exit";
            filterToolStripMenuItem.Text = "Filter";
            skiftaFärgkanalerToolStripMenuItem.Text = "Color change";
            monochromeToolStripMenuItem.Text = "Monochrome";
            inverteraFärgerToolStripMenuItem.Text = "Inverted Colors";
            RGBFilterToolStripMenuItem.Text = "RGB Values";
            languageToolStripMenuItem.Text = "Language";
        }

        private void 日本語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "ファイル";
            openImageToolStripMenuItem.Text = "絵を開ける";
            sparaToolStripMenuItem.Text = "新規保管";
            avslutaToolStripMenuItem.Text = "終了";
            filterToolStripMenuItem.Text = "フィルタ";
            skiftaFärgkanalerToolStripMenuItem.Text = "色を更代";
            monochromeToolStripMenuItem.Text = "白黒";
            inverteraFärgerToolStripMenuItem.Text = "反転色";
            RGBFilterToolStripMenuItem.Text = "RGBの値";
            languageToolStripMenuItem.Text = "翻訳";
        }

        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "Fichier";
            openImageToolStripMenuItem.Text = "Ouvrir une image";
            sparaToolStripMenuItem.Text = "Enregistrer";
            avslutaToolStripMenuItem.Text = "Annuler";
            filterToolStripMenuItem.Text = "Filtre d'image";
            skiftaFärgkanalerToolStripMenuItem.Text = "Échange de couleur";
            monochromeToolStripMenuItem.Text = "Monochromatique";
            inverteraFärgerToolStripMenuItem.Text = "D'inverser les couleurs";
            RGBFilterToolStripMenuItem.Text = "Valeurs RVB";
            languageToolStripMenuItem.Text = "Langages";
        }

        private void SkiftaFärger()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    Color modified = Color.FromArgb(original.G, original.B, original.R);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }
        private void Monochrome()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    int mono = (original.R + original.G + original.B) / 3;
                    Color modified = Color.FromArgb(mono, mono, mono);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }
        private void InverteraFärger()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    Color modified = Color.FromArgb(255 - original.R, 255 - original.G, 255 - original.B );
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }
        private void RGBVärden(int R, int G, int B)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    int NyR = original.R + R;
                    if (NyR < 0)
                    { NyR = 0; }
                    if (NyR > 255)
                    { NyR = 255; }
                    int NyG = original.G + G;
                    if (NyG < 0)
                    { NyG = 0; }
                    if (NyG > 255)
                    { NyG = 255; }
                    int NyB = original.B + B;
                    if (NyB < 0)
                    { NyB = 0; }
                    if (NyB > 255)
                    { NyB = 255; }
                    Color modified = Color.FromArgb(NyR, NyG, NyB);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }
    }
}
