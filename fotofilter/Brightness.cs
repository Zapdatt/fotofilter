﻿using System;
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
        private void buttonOkay_Click_1(object sender, EventArgs e) //Om användaren trycker okay blir dialog result okay och rutan stängs
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonNotOk_Click_1(object sender, EventArgs e) //om användaren trycker Cancel stängs rutan.
        {
            Close();
        }

    }
}
