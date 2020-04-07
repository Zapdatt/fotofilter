using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilterLibrary;

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
            RGB form2 = new RGB();
            form2.ShowDialog();
//            if (DialogResult == DialogResult.OK;)
//            {
                int RGBSliderRF = form2.trackBarR.Value;
                int RGBSliderGF = form2.trackBarG.Value;
                int RGBsliderBF = form2.trackBarB.Value;
                RGBVärden(RGBSliderRF, RGBSliderGF, RGBsliderBF);
//            }
        }

        private void miniNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterLibrary.Filters.MiniNoise(bitmap, 10);
        }

        private void bitRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneBitRGB();
        }
        private void bitRGBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TwoBitRGB();
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFile.FileName);
            }
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
            miniNoiseToolStripMenuItem.Text = "Minibrus";
            bitRGBToolStripMenuItem.Text = "Enbits RGB";
            bitRGBToolStripMenuItem1.Text = "Twobits RGB";
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
            miniNoiseToolStripMenuItem.Text = "Mini Noice";
            bitRGBToolStripMenuItem.Text = "Single bit RGB";
            bitRGBToolStripMenuItem1.Text = "Double bit RGB";
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
            RGBFilterToolStripMenuItem.Text = "ＲＧＢの値";
            miniNoiseToolStripMenuItem.Text = "少し不鮮明";
            bitRGBToolStripMenuItem.Text = "一ビットＲＧＢ";
            bitRGBToolStripMenuItem1.Text = "二ビットＲＧＢ";
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
            miniNoiseToolStripMenuItem.Text = "Bruit visuel mini";
            bitRGBToolStripMenuItem.Text = "Une bit RVB";
            bitRGBToolStripMenuItem1.Text = "Deux bit RVB";
            languageToolStripMenuItem.Text = "Langages";
        }
        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit form3 = new Credit();
            form3.ShowDialog();
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About form4 = new About();
            form4.ShowDialog();
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
        private void RGBVärden(int RF, int GF, int BF)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    int NyR = original.R + RF;
                    if (NyR < 0)
                    { NyR = 0; }
                    if (NyR > 255)
                    { NyR = 255; }
                    int NyG = original.G + GF;
                    if (NyG < 0)
                    { NyG = 0; }
                    if (NyG > 255)
                    { NyG = 255; }
                    int NyB = original.B + BF;
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
        private void OneBitRGB()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    int R = 0;
                    int G = 0;
                    int B = 0;
                    if (original.R < 127.5)
                    {
                        R = 0;
                    }
                    else
                    {
                        R = 255;
                    }
                    if (original.G < 127.5)
                    {
                        G = 0;
                    }
                    else
                    {
                        G = 255;
                    }
                    if (original.B < 127.5)
                    {
                        B = 0;
                    }
                    else
                    {
                        B = 255;
                    }
                    Color modified = Color.FromArgb(R, G, B);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }
        private void TwoBitRGB()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    int R = 0;
                    int G = 0;
                    int B = 0;
                    if (original.R < 85)
                    {
                        R = 0;
                    }
                    else if (original.R > 85 && original.R < 170)
                    {
                        R = 127;
                    }
                    else
                    {
                        R = 255;
                    }
                    if (original.G < 85)
                    {
                        G = 0;
                    }
                    else if (original.G > 85 && original.G < 170)
                    {
                        G = 127;
                    }
                    else
                    {
                        G = 255;
                    }
                    if (original.B < 85)
                    {
                        B = 0;
                    }
                    else if (original.B > 85 && original.B < 170)
                    {
                        B = 127;
                    }
                    else
                    {
                        B = 255;
                    }
                    Color modified = Color.FromArgb(R, G, B);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }
    }
}
