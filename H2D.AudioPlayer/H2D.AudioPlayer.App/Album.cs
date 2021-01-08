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
            player.URL = "usuk.mp3";
            player.controls.play();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            player.URL = "usuk1.mp3";
            player.controls.play();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            player.URL = "usuk2.mp3";
            player.controls.play();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            player.URL = "usuk3.mp3";
            player.controls.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowList = !ShowList;
                
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
            player.URL = "CoGaiVang-HuyRTungViu-6617041.mp3";
            player.controls.play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.URL = "DiDeTroVe-SoobinHoangSon-4726882.mp3";
            player.controls.play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.URL = "NgayXuanLongPhungSumVay-DaoBaLoc_4j7eu.mp3";

            player.controls.play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player.URL = "rap.mp3";

            player.controls.play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            player.URL = "Kpop.mp3";
            player.controls.play();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            player.URL = "Kpop1.mp3";
            player.controls.play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
    }
}
