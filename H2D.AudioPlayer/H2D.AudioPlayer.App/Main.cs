using H2D.AudioPlayer.App.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    public partial class Main : Form
    {
        private bool Playing = false;
        private bool Shuffle = false;
        private bool Repeat = false;
        private bool Mute = false;
        private int CurrentVol = 0;
        private bool ShowList = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.settings.volume = 100;
                pnSubMedia.Visible = false;
                pnsetting.Visible = false;                
                pnPlayList.Width = 0;
                pnTimeCurrent.Width = 0;
                ShowVolume();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void ShowVolume()
        {
            int vol = (int)(pnVol.Width * (double)(axWindowsMediaPlayer.settings.volume / 100M));
            pnVolCurrent.Width = vol;
            lbVol.Text = axWindowsMediaPlayer.settings.volume + "%";
        }

        private void PlayMusic()
        {
            Playing = true;
            picPlay.Image = Resources.pause;
            timerPlay.Enabled = true;
            timerPlay.Start();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                pnSubMedia.Visible = !pnSubMedia.Visible;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                ShowList = !ShowList;
                timerPanRight.Enabled = true;
                timerPanRight.Start();
                picPlaylist.Image = pnPlayList.Width == 300 ? Resources.playlist_off : Resources.playlist_on;
                //pnInfo.Visible = !ShowList;
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void LoadPlayList()
        {
            if (!ShowList)
                return;
            pnPlayList.Controls.Clear();
            int count = axWindowsMediaPlayer.currentPlaylist.count;
            if (count == 0)
                return;
            for (int i = count - 1; i > -1; i--)
            {
                var font = new Font("Tahoma", 10);
                var label = new Label
                {
                    Font = font,
                    AutoSize = false,
                    Text = "     " + axWindowsMediaPlayer.currentPlaylist.Item[i].name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0),
                    Height = 35,
                    ForeColor = Color.Pink,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    Tag = i
                };
                if (label.Text == "     " + axWindowsMediaPlayer.currentMedia.name)
                {
                    label.BackColor = Color.FromArgb(21, 7, 17);
                    label.Image = Resources.playing;


                }
                else
                {
                    label.BackColor = Color.FromArgb(35, 32, 39);
                    label.Image = null;
                }
                label.DoubleClick += Song_DoubleClick;
                pnPlayList.Controls.Add(label);
            }
        }

        private void Song_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var lable = sender as Label;
                int index = int.Parse(lable.Tag.ToString());
                axWindowsMediaPlayer.Ctlcontrols.playItem(axWindowsMediaPlayer.currentPlaylist.Item[index]);
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void ShowPlaylist(bool show)
        {
            if (show)
            {
                if (pnPlayList.Width < 300)
                {
                    pnPlayList.Width += 10;
                    Thread.Sleep(10);
                    ShowPlaylist(show);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (pnPlayList.Width > 0)
                {
                    pnPlayList.Width -= 10;
                    Thread.Sleep(10);
                    ShowPlaylist(show);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                ShowList = !ShowList;
                timerPanRight.Enabled = true;
                timerPanRight.Start();
                picPlaylist.Image = pnPlayList.Width == 300 ? Resources.playlist_off : Resources.playlist_on;
                
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
            
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
                picPlay.Image = Resources.pause;
                timerPlay.Start();
                if (Playing)
                {
                    axWindowsMediaPlayer.Ctlcontrols.pause();
                    picPlay.Image = Resources.play;
                    timerPlay.Stop();

                }
                else
                {
                    timerPlay.Start();
                }
                Playing = !Playing;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void picShuffle_Click(object sender, EventArgs e)
        {
            try
            {
                picShuffle.Image = Shuffle ? Resources.unshuffle : Resources.shuffle;
                Shuffle = !Shuffle;
                axWindowsMediaPlayer.settings.setMode("shuffle", Shuffle);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            try
            {
                lbSongName.Text = axWindowsMediaPlayer.status;
                lbsongname1.Text = axWindowsMediaPlayer.status;
                lbLastTime.Text = axWindowsMediaPlayer.currentMedia.durationString;
                lbTimeCurrent.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
                var currentTime = axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                var allTime = axWindowsMediaPlayer.currentMedia.duration;
                pnTimeCurrent.Width = (int)(pnTime.Width * (currentTime / allTime));
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void pnTime_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetTime(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void SetTime(int x)
        {
            pnTimeCurrent.Width = x;
            var currentTime = (double)pnTimeCurrent.Width;
            var allTime = (double)pnTime.Width;
            var current = axWindowsMediaPlayer.currentMedia.duration * (currentTime / allTime);
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = current;
        }

        private void pnTimeCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetTime(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void pnVol_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void SetVolume(double x)
        {
            var totalVol = pnVol.Width;
            var vol = x / totalVol * 100;
            axWindowsMediaPlayer.settings.volume = (int)vol;
            ShowVolume();
        }

        private void pnVolCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void picVol_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mute)
                {
                    axWindowsMediaPlayer.settings.volume = CurrentVol;
                    ShowVolPicture();
                    ShowVolume();
                }
                else
                {
                    CurrentVol = axWindowsMediaPlayer.settings.volume;
                    SetVolume(0);
                    picVol.Image = Resources.mute;
                }
                Mute = !Mute;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void ShowVolPicture()
        {
            picVol.Image = axWindowsMediaPlayer.settings.volume > 50 ? Resources.high_vol : Resources.low_vol;
        }

        private void picRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                Repeat = !Repeat;
                axWindowsMediaPlayer.settings.setMode("loop", Repeat);
                picRepeat.Image = Repeat ? Resources.repeat_on : Resources.repeat_off;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void timerPanRight_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ShowList)
                {
                    pnPlayList.Width += 10;
                    if (pnPlayList.Width == 300)
                        timerPanRight.Stop();
                }
                else
                {
                    pnPlayList.Width -= 10;
                    if (pnPlayList.Width == 0)
                        timerPanRight.Stop();
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFile = new OpenFileDialog())
                {
                    openFile.Multiselect = true;
                    openFile.Filter = "Audio File|*.mp3; *.wav; *.mp4";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        axWindowsMediaPlayer.currentPlaylist = axWindowsMediaPlayer.newPlaylist("", "");
                        foreach (var item in openFile.FileNames)
                        {
                            axWindowsMediaPlayer.currentPlaylist.appendItem(axWindowsMediaPlayer.newMedia(item));

                        }
                    }
                    picPlay_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.Ctlcontrols.next();
                PlayMusic();
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void picPre_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.Ctlcontrols.previous();
                PlayMusic();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dic = new FolderBrowserDialog())
                {
                    if (dic.ShowDialog() == DialogResult.OK)
                    {
                        var lstFile = Directory.GetFiles(dic.SelectedPath, "*.mp3").ToList();
                        lstFile.AddRange(Directory.GetFiles(dic.SelectedPath, "*.wav"));
                        axWindowsMediaPlayer.currentPlaylist = axWindowsMediaPlayer.newPlaylist("", "");
                        foreach (var item in lstFile)
                        {
                            axWindowsMediaPlayer.currentPlaylist.appendItem(axWindowsMediaPlayer.newMedia(item));
                        }
                    }
                    picPlay_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Playing = false;
                picPlay.Image = Resources.play;
            }
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            try
            {

                pnSubMedia.Visible = false;
                pnsetting.Visible = !pnsetting.Visible;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pnPlayList.BackColor = Color.Salmon;
                
                pnTimeCurrent.BackColor = Color.OrangeRed;
                pnVolCurrent.BackColor = Color.OrangeRed;
                btnMedia.ForeColor = Color.OrangeRed;
                btnPlaylist.ForeColor = Color.OrangeRed;
                btnsetting.ForeColor = Color.OrangeRed;
                
                pnInfo.BackColor = Color.Salmon;
                btnExit.ForeColor = Color.OrangeRed;
                panel1.BackColor = Color.Tomato;
                pnMenu.BackColor = Color.Pink;
                pnControl.BackColor = Color.Salmon;
                pnSubMedia.BackColor = Color.MistyRose;
                pnsetting.BackColor = Color.MistyRose;
                pnTime.BackColor = Color.White;
                pnVol.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    pnTimeCurrent.BackColor = Color.Red;
                    pnVolCurrent.BackColor = Color.Red;
                    btnMedia.ForeColor = Color.Red;
                    btnPlaylist.ForeColor = Color.Red;
                    btnsetting.ForeColor = Color.Red;
                    btnMedia.ForeColor = Color.Red;
                    btnExit.ForeColor = Color.Red;
                    panel1.BackColor = Color.DimGray;
                    pnMenu.BackColor = Color.FromArgb(11, 7, 17);
                    pnControl.BackColor = Color.FromArgb(23, 21, 32);
                    pnSubMedia.BackColor = Color.FromArgb(35, 32, 39);
                    pnsetting.BackColor = Color.FromArgb(35, 32, 39);
                    pnTime.BackColor = Color.FromArgb(36, 33, 55);
                    pnVol.BackColor = Color.DarkGray;
                    pnInfo.BackColor = Color.FromArgb(23, 21, 32);

                }
                catch (Exception ex)
                {
                    ex.ShowException();
                }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                album1.Visible = true;
                axWindowsMediaPlayer.Visible = false;
                pnInfo.Visible = false;
            }
            catch(Exception ex)
            {
                ex.ShowException();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Visible = true;
        }
    }
}
