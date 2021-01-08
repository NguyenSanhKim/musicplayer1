using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace H2D.AudioPlayer.App
{
    public partial class Album : UserControl
    {
        private bool ShowList = false;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
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

        private void pnUSUK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            player.URL = "buomxuan.mp3";

            player.controls.play();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            player.URL = "DiDeTroVe-SoobinHoangSon-4726882.mp3";

            player.controls.play();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            player.URL = "NgayXuanLongPhungSumVay-DaoBaLoc_4j7eu.mp3";

            player.controls.play();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            player.URL = "CoGaiVang-HuyRTungViu-6617041.mp3";
            player.URL = "NgayXuanLongPhungSumVay-DaoBaLoc_4j7eu.mp3";
            player.controls.play();
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
