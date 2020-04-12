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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void HeaderLabel_DoubleClick(object sender, EventArgs e) //Om användaren dubbelklickar på about visas ett easteregg med en katt. Glad Påsk. Katten är "Tablecat", en textbaserad meme från 2ch / 4ch. 
        {
            ContentLabel.Text = "　　　　　　　　　　∧＿∧　  　／￣￣￣￣￣￣￣￣\r\n　　　　　　　　　 （　•ω•）　＜　Sådär kan man ju också göra...\r\n　　　　　　　　／　　　　|　 　 ＼＿＿＿＿＿＿＿＿\r\n　　　　　　　/ 　　　 　 .|　　　　　\r\n　　　　　　  / ^⌒ヽ |.ｲ |\r\n　　　＿＿ |　　　.ノ | || |＿＿\r\n　  　　　  ノく＿＿つ∪∪　  　 ＼\r\n　　　＿（（＿＿＿＿＿＿＿＿＼\r\n　　 ￣￣ヽつ￣￣￣￣￣￣ | |￣\r\n　　　＿＿＿＿＿＿＿＿__ | |\r\n　 　   ￣￣￣￣￣￣￣￣￣| |";
        }
    }
}
