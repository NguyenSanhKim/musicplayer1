namespace H2D.AudioPlayer.App
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnsetting = new System.Windows.Forms.Panel();
            this.btndarktheme = new System.Windows.Forms.Button();
            this.btnLighttheme = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.pnSubMedia = new System.Windows.Forms.Panel();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbsongname1 = new System.Windows.Forms.Label();
            this.pnVol = new System.Windows.Forms.Panel();
            this.pnVolCurrent = new System.Windows.Forms.Panel();
            this.lbVol = new System.Windows.Forms.Label();
            this.lbTimeCurrent = new System.Windows.Forms.Label();
            this.lbLastTime = new System.Windows.Forms.Label();
            this.pnTime = new System.Windows.Forms.Panel();
            this.pnTimeCurrent = new System.Windows.Forms.Panel();
            this.picVol = new System.Windows.Forms.PictureBox();
            this.picPlaylist = new System.Windows.Forms.PictureBox();
            this.picShuffle = new System.Windows.Forms.PictureBox();
            this.picRepeat = new System.Windows.Forms.PictureBox();
            this.picPre = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lbSongName = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnPlayList = new System.Windows.Forms.Panel();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.timerPanRight = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.album1 = new H2D.AudioPlayer.App.Album();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.pnsetting.SuspendLayout();
            this.pnSubMedia.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnVol.SuspendLayout();
            this.pnTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.pnCenter.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.pnPlayList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Silver;
            label1.Location = new System.Drawing.Point(0, 45);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            label1.Size = new System.Drawing.Size(300, 45);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Top;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Silver;
            label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label4.Location = new System.Drawing.Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label4.Size = new System.Drawing.Size(300, 45);
            label4.TabIndex = 0;
            label4.Text = "     label4";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnMenu.Controls.Add(this.button2);
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.pnsetting);
            this.pnMenu.Controls.Add(this.btnsetting);
            this.pnMenu.Controls.Add(this.btnExit);
            this.pnMenu.Controls.Add(this.btnPlaylist);
            this.pnMenu.Controls.Add(this.pnSubMedia);
            this.pnMenu.Controls.Add(this.btnMedia);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(49, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(246, 590);
            this.pnMenu.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 438);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(246, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Now playing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(246, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Album";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnsetting
            // 
            this.pnsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnsetting.Controls.Add(this.btndarktheme);
            this.pnsetting.Controls.Add(this.btnLighttheme);
            this.pnsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnsetting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnsetting.Location = new System.Drawing.Point(0, 309);
            this.pnsetting.Name = "pnsetting";
            this.pnsetting.Size = new System.Drawing.Size(246, 84);
            this.pnsetting.TabIndex = 9;
            // 
            // btndarktheme
            // 
            this.btndarktheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndarktheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndarktheme.FlatAppearance.BorderSize = 0;
            this.btndarktheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btndarktheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btndarktheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndarktheme.ForeColor = System.Drawing.Color.LightCoral;
            this.btndarktheme.Location = new System.Drawing.Point(0, 40);
            this.btndarktheme.Name = "btndarktheme";
            this.btndarktheme.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btndarktheme.Size = new System.Drawing.Size(246, 40);
            this.btndarktheme.TabIndex = 1;
            this.btndarktheme.Text = "Dark theme ";
            this.btndarktheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndarktheme.UseVisualStyleBackColor = true;
            this.btndarktheme.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLighttheme
            // 
            this.btnLighttheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLighttheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLighttheme.FlatAppearance.BorderSize = 0;
            this.btnLighttheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLighttheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLighttheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLighttheme.ForeColor = System.Drawing.Color.LightCoral;
            this.btnLighttheme.Location = new System.Drawing.Point(0, 0);
            this.btnLighttheme.Name = "btnLighttheme";
            this.btnLighttheme.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLighttheme.Size = new System.Drawing.Size(246, 40);
            this.btnLighttheme.TabIndex = 0;
            this.btnLighttheme.Text = "Light theme ";
            this.btnLighttheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLighttheme.UseVisualStyleBackColor = true;
            this.btnLighttheme.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnsetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.ForeColor = System.Drawing.Color.Red;
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(0, 264);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsetting.Size = new System.Drawing.Size(246, 45);
            this.btnsetting.TabIndex = 8;
            this.btnsetting.Text = "Setting";
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 545);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(246, 45);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Red;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 219);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(246, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // pnSubMedia
            // 
            this.pnSubMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnSubMedia.Controls.Add(this.btnOpenFolder);
            this.pnSubMedia.Controls.Add(this.btnOpenFile);
            this.pnSubMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMedia.Location = new System.Drawing.Point(0, 135);
            this.pnSubMedia.Name = "pnSubMedia";
            this.pnSubMedia.Size = new System.Drawing.Size(246, 84);
            this.pnSubMedia.TabIndex = 2;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.LightCoral;
            this.btnOpenFolder.Location = new System.Drawing.Point(0, 40);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenFolder.Size = new System.Drawing.Size(246, 40);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.ForeColor = System.Drawing.Color.LightCoral;
            this.btnOpenFile.Location = new System.Drawing.Point(0, 0);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenFile.Size = new System.Drawing.Size(246, 40);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Red;
            this.btnMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnMedia.Image")));
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Location = new System.Drawing.Point(0, 90);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(246, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnLogo.BackgroundImage = global::H2D.AudioPlayer.App.Properties.Resources.cb16cce8d6603b6425163dd761eda39f;
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(246, 90);
            this.pnLogo.TabIndex = 0;
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnControl.Controls.Add(this.panel3);
            this.pnControl.Controls.Add(this.pnVol);
            this.pnControl.Controls.Add(this.lbVol);
            this.pnControl.Controls.Add(this.lbTimeCurrent);
            this.pnControl.Controls.Add(this.lbLastTime);
            this.pnControl.Controls.Add(this.pnTime);
            this.pnControl.Controls.Add(this.picVol);
            this.pnControl.Controls.Add(this.picPlaylist);
            this.pnControl.Controls.Add(this.picShuffle);
            this.pnControl.Controls.Add(this.picRepeat);
            this.pnControl.Controls.Add(this.picPre);
            this.pnControl.Controls.Add(this.picNext);
            this.pnControl.Controls.Add(this.picPlay);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 590);
            this.pnControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1060, 71);
            this.pnControl.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbsongname1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 71);
            this.panel3.TabIndex = 24;
            // 
            // lbsongname1
            // 
            this.lbsongname1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbsongname1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbsongname1.Location = new System.Drawing.Point(0, 0);
            this.lbsongname1.Name = "lbsongname1";
            this.lbsongname1.Size = new System.Drawing.Size(295, 71);
            this.lbsongname1.TabIndex = 0;
            // 
            // pnVol
            // 
            this.pnVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.pnVol.Controls.Add(this.pnVolCurrent);
            this.pnVol.Location = new System.Drawing.Point(836, 41);
            this.pnVol.Name = "pnVol";
            this.pnVol.Size = new System.Drawing.Size(153, 7);
            this.pnVol.TabIndex = 20;
            this.pnVol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnVol_MouseDown);
            // 
            // pnVolCurrent
            // 
            this.pnVolCurrent.BackColor = System.Drawing.Color.Red;
            this.pnVolCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnVolCurrent.Location = new System.Drawing.Point(0, 0);
            this.pnVolCurrent.Name = "pnVolCurrent";
            this.pnVolCurrent.Size = new System.Drawing.Size(50, 7);
            this.pnVolCurrent.TabIndex = 1;
            this.pnVolCurrent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnVolCurrent_MouseDown);
            // 
            // lbVol
            // 
            this.lbVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVol.AutoSize = true;
            this.lbVol.ForeColor = System.Drawing.Color.LightGray;
            this.lbVol.Location = new System.Drawing.Point(1003, 35);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(28, 19);
            this.lbVol.TabIndex = 23;
            this.lbVol.Text = "0%";
            // 
            // lbTimeCurrent
            // 
            this.lbTimeCurrent.AutoSize = true;
            this.lbTimeCurrent.ForeColor = System.Drawing.Color.LightGray;
            this.lbTimeCurrent.Location = new System.Drawing.Point(301, 3);
            this.lbTimeCurrent.Name = "lbTimeCurrent";
            this.lbTimeCurrent.Size = new System.Drawing.Size(45, 19);
            this.lbTimeCurrent.TabIndex = 22;
            this.lbTimeCurrent.Text = "00:00";
            // 
            // lbLastTime
            // 
            this.lbLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLastTime.AutoSize = true;
            this.lbLastTime.ForeColor = System.Drawing.Color.LightGray;
            this.lbLastTime.Location = new System.Drawing.Point(986, 3);
            this.lbLastTime.Name = "lbLastTime";
            this.lbLastTime.Size = new System.Drawing.Size(45, 19);
            this.lbLastTime.TabIndex = 20;
            this.lbLastTime.Text = "00:00";
            // 
            // pnTime
            // 
            this.pnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.pnTime.Controls.Add(this.pnTimeCurrent);
            this.pnTime.Location = new System.Drawing.Point(352, 12);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(619, 7);
            this.pnTime.TabIndex = 19;
            this.pnTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTime_MouseDown);
            // 
            // pnTimeCurrent
            // 
            this.pnTimeCurrent.BackColor = System.Drawing.Color.Red;
            this.pnTimeCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTimeCurrent.Location = new System.Drawing.Point(0, 0);
            this.pnTimeCurrent.Name = "pnTimeCurrent";
            this.pnTimeCurrent.Size = new System.Drawing.Size(200, 7);
            this.pnTimeCurrent.TabIndex = 0;
            this.pnTimeCurrent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTimeCurrent_MouseDown);
            // 
            // picVol
            // 
            this.picVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picVol.Image = global::H2D.AudioPlayer.App.Properties.Resources.high_vol;
            this.picVol.Location = new System.Drawing.Point(806, 32);
            this.picVol.Name = "picVol";
            this.picVol.Size = new System.Drawing.Size(24, 24);
            this.picVol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVol.TabIndex = 18;
            this.picVol.TabStop = false;
            this.picVol.Click += new System.EventHandler(this.picVol_Click);
            // 
            // picPlaylist
            // 
            this.picPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlaylist.Image = global::H2D.AudioPlayer.App.Properties.Resources.playlist_off;
            this.picPlaylist.Location = new System.Drawing.Point(305, 32);
            this.picPlaylist.Name = "picPlaylist";
            this.picPlaylist.Size = new System.Drawing.Size(24, 24);
            this.picPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlaylist.TabIndex = 17;
            this.picPlaylist.TabStop = false;
            this.picPlaylist.Click += new System.EventHandler(this.picPlaylist_Click);
            // 
            // picShuffle
            // 
            this.picShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShuffle.Image = global::H2D.AudioPlayer.App.Properties.Resources.unshuffle;
            this.picShuffle.Location = new System.Drawing.Point(344, 32);
            this.picShuffle.Name = "picShuffle";
            this.picShuffle.Size = new System.Drawing.Size(24, 24);
            this.picShuffle.TabIndex = 16;
            this.picShuffle.TabStop = false;
            this.picShuffle.Click += new System.EventHandler(this.picShuffle_Click);
            // 
            // picRepeat
            // 
            this.picRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepeat.Image = global::H2D.AudioPlayer.App.Properties.Resources.repeat_off;
            this.picRepeat.Location = new System.Drawing.Point(389, 32);
            this.picRepeat.Name = "picRepeat";
            this.picRepeat.Size = new System.Drawing.Size(24, 24);
            this.picRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRepeat.TabIndex = 15;
            this.picRepeat.TabStop = false;
            this.picRepeat.Click += new System.EventHandler(this.picRepeat_Click);
            // 
            // picPre
            // 
            this.picPre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPre.Image = ((System.Drawing.Image)(resources.GetObject("picPre.Image")));
            this.picPre.Location = new System.Drawing.Point(555, 32);
            this.picPre.Name = "picPre";
            this.picPre.Size = new System.Drawing.Size(24, 24);
            this.picPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPre.TabIndex = 14;
            this.picPre.TabStop = false;
            this.picPre.Click += new System.EventHandler(this.picPre_Click);
            // 
            // picNext
            // 
            this.picNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Image = ((System.Drawing.Image)(resources.GetObject("picNext.Image")));
            this.picNext.Location = new System.Drawing.Point(623, 32);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(24, 24);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNext.TabIndex = 13;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picPlay
            // 
            this.picPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlay.Image = global::H2D.AudioPlayer.App.Properties.Resources.play;
            this.picPlay.Location = new System.Drawing.Point(585, 27);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(32, 32);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlay.TabIndex = 12;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnCenter.Controls.Add(this.pnInfo);
            this.pnCenter.Controls.Add(this.axWindowsMediaPlayer);
            this.pnCenter.Controls.Add(this.album1);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(295, 0);
            this.pnCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(465, 590);
            this.pnCenter.TabIndex = 2;
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnInfo.Controls.Add(this.lbSongName);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(465, 45);
            this.pnInfo.TabIndex = 1;
            // 
            // lbSongName
            // 
            this.lbSongName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSongName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(0, 0);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbSongName.Size = new System.Drawing.Size(465, 45);
            this.lbSongName.TabIndex = 0;
            this.lbSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 3);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(465, 651);
            this.axWindowsMediaPlayer.TabIndex = 0;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            // 
            // pnPlayList
            // 
            this.pnPlayList.AutoScroll = true;
            this.pnPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnPlayList.Controls.Add(label1);
            this.pnPlayList.Controls.Add(label4);
            this.pnPlayList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPlayList.Location = new System.Drawing.Point(760, 0);
            this.pnPlayList.Name = "pnPlayList";
            this.pnPlayList.Size = new System.Drawing.Size(300, 590);
            this.pnPlayList.TabIndex = 1;
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // timerPanRight
            // 
            this.timerPanRight.Interval = 10;
            this.timerPanRight.Tick += new System.EventHandler(this.timerPanRight_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 590);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 45);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::H2D.AudioPlayer.App.Properties.Resources.video_player;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // album1
            // 
            this.album1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.album1.Location = new System.Drawing.Point(0, 0);
            this.album1.Margin = new System.Windows.Forms.Padding(4);
            this.album1.Name = "album1";
            this.album1.Size = new System.Drawing.Size(465, 590);
            this.album1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 661);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnPlayList);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnControl);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(840, 520);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media player";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnsetting.ResumeLayout(false);
            this.pnSubMedia.ResumeLayout(false);
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnVol.ResumeLayout(false);
            this.pnTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.pnCenter.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.pnPlayList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel pnSubMedia;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbVol;
        private System.Windows.Forms.Label lbTimeCurrent;
        private System.Windows.Forms.Label lbLastTime;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.PictureBox picVol;
        private System.Windows.Forms.PictureBox picPlaylist;
        private System.Windows.Forms.PictureBox picShuffle;
        private System.Windows.Forms.PictureBox picRepeat;
        private System.Windows.Forms.PictureBox picPre;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Panel pnPlayList;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Panel pnVol;
        private System.Windows.Forms.Panel pnTimeCurrent;
        private System.Windows.Forms.Timer timerPanRight;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Panel pnVolCurrent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbsongname1;
        private System.Windows.Forms.Panel pnsetting;
        private System.Windows.Forms.Button btnLighttheme;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btndarktheme;
        private System.Windows.Forms.Button button1;
        private Album album1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}