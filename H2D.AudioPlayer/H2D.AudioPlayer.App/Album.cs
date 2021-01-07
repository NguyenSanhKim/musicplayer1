using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    public partial class Album : UserControl
    {
        public Album()
        {
            InitializeComponent();
        }

        private void btnVN_Click(object sender, EventArgs e)
        {
            pnVN.Visible = true;
            pnKPOP.Visible = false;
            pnUSUK.Visible = false;
        }

        private void btnUSUK_Click(object sender, EventArgs e)
        {
            pnUSUK.Visible = true;
            pnKPOP.Visible = false;
            pnVN.Visible = false;
        }

        private void btnKPOP_Click(object sender, EventArgs e)
        {
            pnUSUK.Visible = false;
            pnKPOP.Visible = true;
            pnVN.Visible = false;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    pnVN.Visible = false;
        //    pnKPOP.Visible = true;
        //    pnUSUK.Visible = true;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    pnUSUK.Visible = false;
        //    pnKPOP.Visible = true;
        //    pnVN.Visible = true;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    pnUSUK.Visible = true;
        //    pnKPOP.Visible = false;
        //    pnVN.Visible = true;
        //}
    }
}
