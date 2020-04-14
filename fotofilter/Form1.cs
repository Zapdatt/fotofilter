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
    public partial class MainForm : Form
    {
        //Variabler för språk, bitmap och en lista skapas. Engelska är standard språket.
        bool Swedish = false;
        bool English = true;
        bool Japanese = false;
        bool French = false;

        Bitmap bitmap;

        List<Bitmap> versioner = new List<Bitmap>();
        int listpos = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        { //När användaren trycker på open image får de upp en ruta där de kan välja en bild. Pictureboxen byter storlek så att den får plats och självaste form1 byter storlek så att den får plats och har samma kant runt hela.
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFile.FileName);
                pbImage.Image = bitmap;
                pbImage.Width = bitmap.Width;
                pbImage.Height = bitmap.Height;
                Width = bitmap.Width + 33;
                Height = bitmap.Height + 83;
            }
            bildlistan();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e) 
        { //Om användaren trycker på Exit, stängs programmet ner.
            Application.Exit();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        { // När användaren trycker på redo kontrollerar programmet först om positionen i listan av bildhistoriken är över 0 (om någon ändring faktist har skett.)
            if (listpos > 0)
            {
                listpos--; //Den nuvarande positionen minskar, picturebox blir bilden på den positionen, picturebox uppdateras.
                pbImage.Image = versioner[listpos];
                pbImage.Refresh();
            }
        }

        private void skiftaFärgkanalerToolStripMenuItem_Click(object sender, EventArgs e)
        { //När användaren trycker på ett filter körs först fuktionen för det filtret och sedan funktionen "bildlistan" som ser till att bildhistoriken uppdateras. Detta är samma för alla som endast innehåller  sin egna fuktion och "bildlistan".
            SkiftaFärger(); 
            bildlistan();
        }

        private void monochromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monochrome();
            bildlistan();
        }

        private void inverteraFärgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InverteraFärger();
            bildlistan();
        }

        private void RGBFilterToolStripMenuItem_Click(object sender, EventArgs e)
        { //Ett nytt form skapas, eftersom att användaren kan vilja ha ett annat språk ändras först texten i detta form för att stämma överens med språket.
            RGB form2 = new RGB();
            if (Swedish == true)
            {
                form2.buttonOkay.Text = "Bekräfta";
                form2.buttonNotOk.Text = "Avbryt";
                form2.LabelG.Text = "G -";
            }
            else if (English == true)
            {
                form2.buttonOkay.Text = "Confirm";
                form2.buttonNotOk.Text = "Cancel";
                form2.LabelG.Text = "G -";
            }
            else if (Japanese == true)
            {
                form2.buttonOkay.Text = "確認する";
                form2.buttonNotOk.Text = "キャンセル";
                form2.LabelG.Text = "G -";
            }
            else if (French == true)
            {
                form2.buttonOkay.Text = "Confirmer";
                form2.buttonNotOk.Text = "Annuler";
                form2.LabelG.Text = "V -";
            }
            form2.ShowDialog(); // Efter att texten ändrats visas form2, här kan användaren välja sina RGB värden.
            if (form2.DialogResult == DialogResult.OK) //Om användaren trycker på okej läggs värdena i variabler som förs in i fuktionen "RGBvärden"
            {
            int RGBSliderRF = form2.trackBarR.Value;
            int RGBSliderGF = form2.trackBarG.Value;
            int RGBsliderBF = form2.trackBarB.Value;
            RGBVärden(RGBSliderRF, RGBSliderGF, RGBsliderBF);
            bildlistan();
            } 
        }

        private void miniNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterLibrary.Filters.MiniNoise(bitmap, 10); //Detta filter var skapat av Martin och det står därför "FilterLibrary.Filter innan fuktionen.
            pbImage.Refresh(); //Picturebox uppdateras
            bildlistan();
        }
        private void megaNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterLibrary.Filters.MiniNoise(bitmap, 100);
            pbImage.Refresh();
            bildlistan();
        }
        private void NoiseToolStripMenuItem_Click(object sender, EventArgs e)
        { //Likväl RGB så skapas först form och sen ändras texten så att det stämmer överens med det språk användaren valt.
            Amount form6 = new Amount();
            if (Swedish == true)
            {
                form6.buttonOkay.Text = "Bekräfta";
                form6.buttonNotOk.Text = "Avbryt";
            }
            else if (English == true)
            {
                form6.buttonOkay.Text = "Confirm";
                form6.buttonNotOk.Text = "Cancel";
            }
            else if (Japanese == true)
            {
                form6.buttonOkay.Text = "確認する";
                form6.buttonNotOk.Text = "キャンセル";
            }
            else if (French == true)
            {
                form6.buttonOkay.Text = "Confirmer";
                form6.buttonNotOk.Text = "Annuler";
            }
            form6.ShowDialog(); //Form6 visas och användaren väljer till vilken grad de vill att "mininoise" ska användas.
            if (form6.DialogResult == DialogResult.OK) //Om användaren trycker okej tas värdet ut och förs in i funktionen och bilden ändras.
            {
                int SliderAmount = form6.trackBarAmount.Value;
                FilterLibrary.Filters.MiniNoise(bitmap, SliderAmount);
                pbImage.Refresh();
                bildlistan();
            }
        }

        private void bitRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneBitRGB();
            bildlistan();
        }
        private void bitRGBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TwoBitRGB();
            bildlistan();
        }
        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        { //En ny form skapas och texten ändras beroende på språk.
            Brightness form5 = new Brightness();
            if (Swedish == true)
            {
                form5.buttonOkay.Text = "Bekräfta";
                form5.buttonNotOk.Text = "Avbryt";
            }
            else if (English == true)
            {
                form5.buttonOkay.Text = "Confirm";
                form5.buttonNotOk.Text = "Cancel";
            }
            else if (Japanese == true)
            {
                form5.buttonOkay.Text = "確認する";
                form5.buttonNotOk.Text = "キャンセル";
            }
            else if (French == true)
            {
                form5.buttonOkay.Text = "Confirmer";
                form5.buttonNotOk.Text = "Annuler";
            }
            form5.ShowDialog(); //Form5 visas, om användaren trycker okej tas värdet från value och stoppas in i funktionen.
            if (form5.DialogResult == DialogResult.OK)
            {
                int SliderBright = form5.trackBarBright.Value;
                Brightness(SliderBright);
                bildlistan();
            }
        }
        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        { //Bitmapen roteras med hjälp av "RotateFlip" som redan finns. Därefter uppdateras picturebox.
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbImage.Refresh();
            bildlistan();
        }
        private void rotate90ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbImage.Refresh();
            bildlistan();
        }
        private void flipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbImage.Refresh();
            bildlistan();
        }
        private void flipVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pbImage.Refresh();
            bildlistan();
        }
        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        { // Om användaren trycker på svara visas en ruta där användaren kan spara filen på sin dator.
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFile.FileName);
                bildlistan();
            }
        }

        private void svenskaToolStripMenuItem_Click(object sender, EventArgs e)
        { // om användaren väljer svenska blir den svenska variabeln true och de andra false, all text på main ändras.
            Swedish = true;
            English = false;
            Japanese = false;
            French = false;
            fileToolStripMenuItem.Text = "Fil";
            openImageToolStripMenuItem.Text = "Öppna bild...";
            sparaToolStripMenuItem.Text = "Spara som...";
            avslutaToolStripMenuItem.Text = "Avsluta";
            editToolStripMenuItem.Text = "Ändra";
            undoToolStripMenuItem.Text = "Ångra";
            filterToolStripMenuItem.Text = "Filter";
            skiftaFärgkanalerToolStripMenuItem.Text = "Skifta färger";
            inverteraFärgerToolStripMenuItem.Text = "Inverterade Färger";
            monochromeToolStripMenuItem.Text = "Svartvit";
            RGBFilterToolStripMenuItem.Text = "RGB Värden";
            miniNoiseToolStripMenuItem.Text = "Minibrus";
            bitRGBToolStripMenuItem.Text = "Enbits RGB";
            bitRGBToolStripMenuItem1.Text = "Twobits RGB";
            brightnessToolStripMenuItem.Text = "Ljusstyrka";
            languageToolStripMenuItem.Text = "Språk";
            rotate90ToolStripMenuItem.Text = "Rotera 90°";
            rotate90ToolStripMenuItem1.Text = "Rotera -90°";
            flipToolStripMenuItem.Text = "Spegelvänd Vågrätt";
            flipVerticallyToolStripMenuItem.Text = "Spegelvänd Lodrätt";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e) // samma fast med engelska
        {
            Swedish = false;
            English = true;
            Japanese = false;
            French = false;
            fileToolStripMenuItem.Text = "Fil";
            openImageToolStripMenuItem.Text = "Open Image...";
            sparaToolStripMenuItem.Text = "Save as...";
            avslutaToolStripMenuItem.Text = "Exit";
            editToolStripMenuItem.Text = "Edit";
            undoToolStripMenuItem.Text = "Undo";
            filterToolStripMenuItem.Text = "Filter";
            skiftaFärgkanalerToolStripMenuItem.Text = "Color change";
            monochromeToolStripMenuItem.Text = "Monochrome";
            inverteraFärgerToolStripMenuItem.Text = "Inverted Colors";
            RGBFilterToolStripMenuItem.Text = "RGB Values";
            miniNoiseToolStripMenuItem.Text = "Mini Noice";
            bitRGBToolStripMenuItem.Text = "Single bit RGB";
            bitRGBToolStripMenuItem1.Text = "Double bit RGB";
            brightnessToolStripMenuItem.Text = "Brightness";
            languageToolStripMenuItem.Text = "Language";
            rotate90ToolStripMenuItem.Text = "Rotate 90°";
            rotate90ToolStripMenuItem1.Text = "Rotate -90°";
            flipToolStripMenuItem.Text = "Flip Horizontally";
            flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
        }

        private void 日本語ToolStripMenuItem_Click(object sender, EventArgs e) // samma fast med japanska
        {
            Swedish = false;
            English = false;
            Japanese = true;
            French = false;
            fileToolStripMenuItem.Text = "ファイル";
            openImageToolStripMenuItem.Text = "絵を開ける...";
            sparaToolStripMenuItem.Text = "新規保管...";
            avslutaToolStripMenuItem.Text = "終了";
            editToolStripMenuItem.Text = "エディット";
            undoToolStripMenuItem.Text = "アンドゥ";
            filterToolStripMenuItem.Text = "フィルタ";
            skiftaFärgkanalerToolStripMenuItem.Text = "色を更代";
            monochromeToolStripMenuItem.Text = "白黒";
            inverteraFärgerToolStripMenuItem.Text = "反転色";
            RGBFilterToolStripMenuItem.Text = "ＲＧＢの値";
            miniNoiseToolStripMenuItem.Text = "少し不鮮明";
            bitRGBToolStripMenuItem.Text = "一ビットＲＧＢ";
            bitRGBToolStripMenuItem1.Text = "二ビットＲＧＢ";
            brightnessToolStripMenuItem.Text = "明度";
            languageToolStripMenuItem.Text = "翻訳";
            rotate90ToolStripMenuItem.Text = "９０度回転";
            rotate90ToolStripMenuItem1.Text = "－９０度回転";
            flipToolStripMenuItem.Text = "左右反転";
            flipVerticallyToolStripMenuItem.Text = "上下反転";
        }

        private void françaisToolStripMenuItem_Click(object sender, EventArgs e) // samma fast med franska
        {
            Swedish = false;
            English = false;
            Japanese = false;
            French = true;
            fileToolStripMenuItem.Text = "Fichier";
            openImageToolStripMenuItem.Text = "Ouvrir une image...";
            sparaToolStripMenuItem.Text = "Enregistrer...";
            avslutaToolStripMenuItem.Text = "Annuler";
            editToolStripMenuItem.Text = "Éditer";
            undoToolStripMenuItem.Text = "Annuler l’action précédente";
            filterToolStripMenuItem.Text = "Filtre d'image";
            skiftaFärgkanalerToolStripMenuItem.Text = "Échange de couleur";
            monochromeToolStripMenuItem.Text = "Monochromatique";
            inverteraFärgerToolStripMenuItem.Text = "D'inverser les couleurs";
            RGBFilterToolStripMenuItem.Text = "Valeurs RVB";
            miniNoiseToolStripMenuItem.Text = "Bruit visuel mini";
            bitRGBToolStripMenuItem.Text = "Une bit RVB";
            bitRGBToolStripMenuItem1.Text = "Deux bit RVB";
            brightnessToolStripMenuItem.Text = "Luminosité";
            languageToolStripMenuItem.Text = "Langages";
            rotate90ToolStripMenuItem.Text = "Pivoter 90°";
            rotate90ToolStripMenuItem1.Text = "Pivoter -90°";
            flipToolStripMenuItem.Text = "Retourner l'image horizontalement";
            flipVerticallyToolStripMenuItem.Text = "Retourner l'image verticalement";
        }
        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        { // när användaren trycker på credit visas credit rutan.
            Credit form3 = new Credit();
            form3.ShowDialog();
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        { // när användaren trycker på about visas about rutan.
            About form4 = new About();
            form4.ShowDialog();
        }

        private void bildlistan() // bitmap x skapas och är en kopia av den nuvarande pbimage.image, x läggs till i versioner, värdet på listpos ändras 
        { 
            //versioner.RemoveRange(listpos, versioner.Count - listpos);
            Bitmap x = new Bitmap(pbImage.Image);
            versioner.Add(x);
            listpos = versioner.Count - 1;
        }

        private void SkiftaFärger() // för varje individuell pixel blir R = G, G = B och B = R. 
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
            pbImage.Image = bitmap; //picturebox uppdateras
        }
        private void Monochrome() // för varje pixel blir R, G och B samma värde vilket är medelvärdet av dem. 
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
            pbImage.Image = bitmap; // Picturebox uppdateras.
        }
        private void InverteraFärger() //För varje pixel blir värdet på RGB det tidigare -255.
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    Color modified = Color.FromArgb(255 - original.R, 255 - original.G, 255 - original.B);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap; //Picturebox uppdateras
        }
        private void RGBVärden(int RF, int GF, int BF) //För varje pixel ökar eller minskar RGB värdena med så mycket användaren valt i form 2. Om det är mer än 255 blir det 255, är det mindre än 0 blir det 0.
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
            pbImage.Image = bitmap; //Picturebox uppdateras
        }
        private void OneBitRGB() // för varje pixel blir R / G / B antingen 0 eller 255.
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
            pbImage.Image = bitmap; //Picturebox uppdateras
        }
        private void TwoBitRGB() // för varje pixel blir R / G / B antingen 0, 127 eller 255.
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
            pbImage.Image = bitmap; //Picturebox uppdateras.
        }
        private void Brightness(int Bright) //för varje pixel ökar R / G / B med så mycket användaren valt i brightness. är det mer än 255 blir det 255, är det mindre än 0 blir det 0.
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    int NyR = original.R + Bright;
                    if (NyR < 0)
                    { NyR = 0; }
                    if (NyR > 255)
                    { NyR = 255; }
                    int NyG = original.G + Bright;
                    if (NyG < 0)
                    { NyG = 0; }
                    if (NyG > 255)
                    { NyG = 255; }
                    int NyB = original.B + Bright;
                    if (NyB < 0)
                    { NyB = 0; }
                    if (NyB > 255)
                    { NyB = 255; }
                    Color modified = Color.FromArgb(NyR, NyG, NyB);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap; //Picturebox uppdateras.
        }
    }
}
