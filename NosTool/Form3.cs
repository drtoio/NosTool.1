﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NosTool
{
    public partial class orateur : Form
    {
        public orateur()
        {
            InitializeComponent();
        }

        private void copierOrateur_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(orateurText.Text);
        }

        private void copierGeneral_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generalText.Text);
        }

        private void copierOrateur2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(orateurText2.Text);
        }
    }
}
