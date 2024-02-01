namespace Picback
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList = new System.Windows.Forms.ListView();
            this.btnCan = new System.Windows.Forms.Button();
            this.driveList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forward = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gre = new System.Windows.Forms.Panel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.Psx = new System.Windows.Forms.Button();
            this.retrica = new System.Windows.Forms.Button();
            this.SSeed = new System.Windows.Forms.Button();
            this.navback = new System.Windows.Forms.Button();
            this.navnext = new System.Windows.Forms.Button();
            this.Polish = new System.Windows.Forms.Button();
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.PL = new System.Windows.Forms.Button();
            this.PA = new System.Windows.Forms.Button();
            this.insta = new System.Windows.Forms.Button();
            this.instaSQ = new System.Windows.Forms.Button();
            this.snap = new System.Windows.Forms.Button();
            this.B612 = new System.Windows.Forms.Button();
            this.instaLY = new System.Windows.Forms.Button();
            this.YC = new System.Windows.Forms.Button();
            this.backward = new System.Windows.Forms.Button();
            this.psfix = new System.Windows.Forms.Button();
            this.fb = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Button();
            this.camera = new System.Windows.Forms.Button();
            this.LR = new System.Windows.Forms.Button();
            this.fbM = new System.Windows.Forms.Button();
            this.psmix = new System.Windows.Forms.Button();
            this.bluetooth = new System.Windows.Forms.Button();
            this.whats = new System.Windows.Forms.Button();
            this.SS = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.imageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageList.HideSelection = false;
            this.imageList.Location = new System.Drawing.Point(84, 34);
            this.imageList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(195, 930);
            this.imageList.TabIndex = 5;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.imageList_ItemSelectionChanged);
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(935, 919);
            this.btnCan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(101, 30);
            this.btnCan.TabIndex = 2;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.BtnCan_Click);
            // 
            // driveList
            // 
            this.driveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveList.FormattingEnabled = true;
            this.driveList.Items.AddRange(new object[] {
            "Drive"});
            this.driveList.Location = new System.Drawing.Point(797, 923);
            this.driveList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.driveList.Name = "driveList";
            this.driveList.Size = new System.Drawing.Size(103, 24);
            this.driveList.TabIndex = 5;
            this.driveList.SelectedIndexChanged += new System.EventHandler(this.driveList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forward);
            this.panel1.Controls.Add(this.driveList);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnsrch);
            this.panel1.Controls.Add(this.btnCan);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 978);
            this.panel1.TabIndex = 24;
            // 
            // forward
            // 
            this.forward.BackgroundImage = global::Picback.Properties.Resources.arro;
            this.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.forward.Location = new System.Drawing.Point(1040, 412);
            this.forward.Margin = new System.Windows.Forms.Padding(4);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(40, 40);
            this.forward.TabIndex = 25;
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click_1);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::Picback.Properties.Resources.Upload;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUp.Location = new System.Drawing.Point(566, 334);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(200, 200);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnsrch
            // 
            this.btnsrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnsrch.BackgroundImage = global::Picback.Properties.Resources.Search1;
            this.btnsrch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnsrch.Location = new System.Drawing.Point(300, 334);
            this.btnsrch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(200, 200);
            this.btnsrch.TabIndex = 2;
            this.btnsrch.UseVisualStyleBackColor = false;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.gre);
            this.panel2.Controls.Add(this.progress);
            this.panel2.Controls.Add(this.Psx);
            this.panel2.Controls.Add(this.retrica);
            this.panel2.Controls.Add(this.SSeed);
            this.panel2.Controls.Add(this.navback);
            this.panel2.Controls.Add(this.imageList);
            this.panel2.Controls.Add(this.navnext);
            this.panel2.Controls.Add(this.Polish);
            this.panel2.Controls.Add(this.selectedImage);
            this.panel2.Controls.Add(this.PL);
            this.panel2.Controls.Add(this.PA);
            this.panel2.Controls.Add(this.insta);
            this.panel2.Controls.Add(this.instaSQ);
            this.panel2.Controls.Add(this.snap);
            this.panel2.Controls.Add(this.B612);
            this.panel2.Controls.Add(this.instaLY);
            this.panel2.Controls.Add(this.YC);
            this.panel2.Controls.Add(this.backward);
            this.panel2.Controls.Add(this.psfix);
            this.panel2.Controls.Add(this.fb);
            this.panel2.Controls.Add(this.CC);
            this.panel2.Controls.Add(this.camera);
            this.panel2.Controls.Add(this.LR);
            this.panel2.Controls.Add(this.fbM);
            this.panel2.Controls.Add(this.psmix);
            this.panel2.Controls.Add(this.bluetooth);
            this.panel2.Controls.Add(this.whats);
            this.panel2.Controls.Add(this.SS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 980);
            this.panel2.TabIndex = 1;
            // 
            // gre
            // 
            this.gre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.gre.Location = new System.Drawing.Point(74, 5);
            this.gre.Name = "gre";
            this.gre.Size = new System.Drawing.Size(100, 5);
            this.gre.TabIndex = 27;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(74, 5);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1003, 5);
            this.progress.TabIndex = 25;
            // 
            // Psx
            // 
            this.Psx.BackgroundImage = global::Picback.Properties.Resources.psx;
            this.Psx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Psx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Psx.Location = new System.Drawing.Point(4, 270);
            this.Psx.Name = "Psx";
            this.Psx.Size = new System.Drawing.Size(35, 35);
            this.Psx.TabIndex = 26;
            this.Psx.Text = " ";
            this.Psx.UseVisualStyleBackColor = true;
            this.Psx.Click += new System.EventHandler(this.psx_Click);
            // 
            // retrica
            // 
            this.retrica.BackgroundImage = global::Picback.Properties.Resources.retrica;
            this.retrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.retrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrica.Location = new System.Drawing.Point(4, 466);
            this.retrica.Name = "retrica";
            this.retrica.Size = new System.Drawing.Size(35, 35);
            this.retrica.TabIndex = 25;
            this.retrica.Text = " ";
            this.retrica.UseVisualStyleBackColor = true;
            this.retrica.Click += new System.EventHandler(this.retrica_Click);
            // 
            // SSeed
            // 
            this.SSeed.BackgroundImage = global::Picback.Properties.Resources.sseed;
            this.SSeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSeed.Location = new System.Drawing.Point(43, 466);
            this.SSeed.Name = "SSeed";
            this.SSeed.Size = new System.Drawing.Size(35, 35);
            this.SSeed.TabIndex = 24;
            this.SSeed.Text = " ";
            this.SSeed.UseVisualStyleBackColor = true;
            this.SSeed.Click += new System.EventHandler(this.SSeed_Click);
            // 
            // navback
            // 
            this.navback.BackgroundImage = global::Picback.Properties.Resources.arr;
            this.navback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.navback.Location = new System.Drawing.Point(285, 498);
            this.navback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navback.Name = "navback";
            this.navback.Size = new System.Drawing.Size(50, 50);
            this.navback.TabIndex = 7;
            this.navback.UseVisualStyleBackColor = true;
            this.navback.Click += new System.EventHandler(this.navback_Click_1);
            // 
            // navnext
            // 
            this.navnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.navnext.BackgroundImage = global::Picback.Properties.Resources.arro;
            this.navnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navnext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.navnext.Location = new System.Drawing.Point(1032, 498);
            this.navnext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navnext.Name = "navnext";
            this.navnext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navnext.Size = new System.Drawing.Size(50, 50);
            this.navnext.TabIndex = 7;
            this.navnext.UseVisualStyleBackColor = false;
            this.navnext.Click += new System.EventHandler(this.navnext_Click_1);
            // 
            // Polish
            // 
            this.Polish.BackgroundImage = global::Picback.Properties.Resources.polish;
            this.Polish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Polish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polish.Location = new System.Drawing.Point(43, 426);
            this.Polish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Polish.Name = "Polish";
            this.Polish.Size = new System.Drawing.Size(35, 35);
            this.Polish.TabIndex = 11;
            this.Polish.Text = " ";
            this.Polish.UseVisualStyleBackColor = true;
            this.Polish.Click += new System.EventHandler(this.Polish_Click);
            // 
            // selectedImage
            // 
            this.selectedImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.selectedImage.Location = new System.Drawing.Point(285, 34);
            this.selectedImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(795, 944);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedImage.TabIndex = 5;
            this.selectedImage.TabStop = false;
            this.selectedImage.Click += new System.EventHandler(this.selectedImage_Click);
            // 
            // PL
            // 
            this.PL.BackgroundImage = global::Picback.Properties.Resources.photo_lb;
            this.PL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PL.Location = new System.Drawing.Point(4, 387);
            this.PL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(35, 35);
            this.PL.TabIndex = 11;
            this.PL.Text = " ";
            this.PL.UseVisualStyleBackColor = true;
            this.PL.Click += new System.EventHandler(this.PL_Click);
            // 
            // PA
            // 
            this.PA.BackgroundImage = global::Picback.Properties.Resources.picsart;
            this.PA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PA.Location = new System.Drawing.Point(43, 387);
            this.PA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PA.Name = "PA";
            this.PA.Size = new System.Drawing.Size(35, 35);
            this.PA.TabIndex = 10;
            this.PA.Text = " ";
            this.PA.UseVisualStyleBackColor = true;
            this.PA.Click += new System.EventHandler(this.PA_Click);
            // 
            // insta
            // 
            this.insta.BackgroundImage = global::Picback.Properties.Resources.insta;
            this.insta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.insta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insta.Location = new System.Drawing.Point(4, 193);
            this.insta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insta.Name = "insta";
            this.insta.Size = new System.Drawing.Size(35, 35);
            this.insta.TabIndex = 23;
            this.insta.Text = " ";
            this.insta.UseVisualStyleBackColor = true;
            this.insta.Click += new System.EventHandler(this.insta_Click);
            // 
            // instaSQ
            // 
            this.instaSQ.BackgroundImage = global::Picback.Properties.Resources.instasq;
            this.instaSQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instaSQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instaSQ.Location = new System.Drawing.Point(4, 426);
            this.instaSQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instaSQ.Name = "instaSQ";
            this.instaSQ.Size = new System.Drawing.Size(35, 35);
            this.instaSQ.TabIndex = 10;
            this.instaSQ.Text = " ";
            this.instaSQ.UseVisualStyleBackColor = true;
            this.instaSQ.Click += new System.EventHandler(this.instaSQ_Click);
            // 
            // snap
            // 
            this.snap.BackgroundImage = global::Picback.Properties.Resources.snap;
            this.snap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.snap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snap.Location = new System.Drawing.Point(43, 154);
            this.snap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snap.Name = "snap";
            this.snap.Size = new System.Drawing.Size(35, 35);
            this.snap.TabIndex = 22;
            this.snap.Text = " ";
            this.snap.UseVisualStyleBackColor = true;
            this.snap.Click += new System.EventHandler(this.snap_Click);
            // 
            // B612
            // 
            this.B612.BackgroundImage = global::Picback.Properties.Resources.b612;
            this.B612.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B612.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B612.Location = new System.Drawing.Point(4, 348);
            this.B612.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B612.Name = "B612";
            this.B612.Size = new System.Drawing.Size(35, 35);
            this.B612.TabIndex = 11;
            this.B612.Text = " ";
            this.B612.UseVisualStyleBackColor = true;
            this.B612.Click += new System.EventHandler(this.B612_Click);
            // 
            // instaLY
            // 
            this.instaLY.BackgroundImage = global::Picback.Properties.Resources.instaly;
            this.instaLY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instaLY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instaLY.Location = new System.Drawing.Point(43, 193);
            this.instaLY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instaLY.Name = "instaLY";
            this.instaLY.Size = new System.Drawing.Size(35, 35);
            this.instaLY.TabIndex = 21;
            this.instaLY.Text = " ";
            this.instaLY.UseVisualStyleBackColor = true;
            this.instaLY.Click += new System.EventHandler(this.instaLY_Click);
            // 
            // YC
            // 
            this.YC.BackgroundImage = global::Picback.Properties.Resources.yc;
            this.YC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YC.Location = new System.Drawing.Point(43, 348);
            this.YC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YC.Name = "YC";
            this.YC.Size = new System.Drawing.Size(35, 35);
            this.YC.TabIndex = 10;
            this.YC.Text = " ";
            this.YC.UseVisualStyleBackColor = true;
            this.YC.Click += new System.EventHandler(this.YC_Click);
            // 
            // backward
            // 
            this.backward.BackColor = System.Drawing.Color.DodgerBlue;
            this.backward.FlatAppearance.BorderSize = 0;
            this.backward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backward.Font = new System.Drawing.Font("Trebuchet MS", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backward.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backward.Location = new System.Drawing.Point(4, 2);
            this.backward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(64, 31);
            this.backward.TabIndex = 5;
            this.backward.Text = "Back";
            this.backward.UseVisualStyleBackColor = false;
            this.backward.Click += new System.EventHandler(this.backward_Click);
            // 
            // psfix
            // 
            this.psfix.BackgroundImage = global::Picback.Properties.Resources.psfix;
            this.psfix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.psfix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.psfix.Location = new System.Drawing.Point(4, 309);
            this.psfix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.psfix.Name = "psfix";
            this.psfix.Size = new System.Drawing.Size(35, 35);
            this.psfix.TabIndex = 12;
            this.psfix.Text = " ";
            this.psfix.UseVisualStyleBackColor = true;
            this.psfix.Click += new System.EventHandler(this.psfix_Click);
            // 
            // fb
            // 
            this.fb.BackgroundImage = global::Picback.Properties.Resources.fb;
            this.fb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fb.Location = new System.Drawing.Point(4, 232);
            this.fb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fb.Name = "fb";
            this.fb.Size = new System.Drawing.Size(35, 35);
            this.fb.TabIndex = 20;
            this.fb.Text = " ";
            this.fb.UseVisualStyleBackColor = true;
            this.fb.Click += new System.EventHandler(this.fb_Click);
            // 
            // CC
            // 
            this.CC.BackgroundImage = global::Picback.Properties.Resources.CC;
            this.CC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CC.Location = new System.Drawing.Point(4, 506);
            this.CC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(35, 35);
            this.CC.TabIndex = 11;
            this.CC.Text = " ";
            this.CC.UseVisualStyleBackColor = true;
            this.CC.Click += new System.EventHandler(this.CC_Click);
            // 
            // camera
            // 
            this.camera.BackgroundImage = global::Picback.Properties.Resources.camera;
            this.camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.camera.Location = new System.Drawing.Point(4, 76);
            this.camera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(35, 35);
            this.camera.TabIndex = 6;
            this.camera.Text = " ";
            this.camera.UseVisualStyleBackColor = true;
            this.camera.Click += new System.EventHandler(this.camera_Click);
            // 
            // LR
            // 
            this.LR.BackgroundImage = global::Picback.Properties.Resources.litroom;
            this.LR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LR.Location = new System.Drawing.Point(43, 270);
            this.LR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(35, 35);
            this.LR.TabIndex = 13;
            this.LR.Text = " ";
            this.LR.UseVisualStyleBackColor = true;
            this.LR.Click += new System.EventHandler(this.LR_Click);
            // 
            // fbM
            // 
            this.fbM.BackgroundImage = global::Picback.Properties.Resources.fbm;
            this.fbM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbM.Location = new System.Drawing.Point(43, 232);
            this.fbM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbM.Name = "fbM";
            this.fbM.Size = new System.Drawing.Size(35, 35);
            this.fbM.TabIndex = 19;
            this.fbM.Text = " ";
            this.fbM.UseVisualStyleBackColor = true;
            this.fbM.Click += new System.EventHandler(this.fbM_Click);
            // 
            // psmix
            // 
            this.psmix.BackgroundImage = global::Picback.Properties.Resources.psmix;
            this.psmix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.psmix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.psmix.Location = new System.Drawing.Point(43, 309);
            this.psmix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.psmix.Name = "psmix";
            this.psmix.Size = new System.Drawing.Size(35, 35);
            this.psmix.TabIndex = 10;
            this.psmix.Text = " ";
            this.psmix.UseVisualStyleBackColor = true;
            this.psmix.Click += new System.EventHandler(this.psmix_Click);
            // 
            // bluetooth
            // 
            this.bluetooth.BackgroundImage = global::Picback.Properties.Resources.bluetooth;
            this.bluetooth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluetooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluetooth.Location = new System.Drawing.Point(4, 115);
            this.bluetooth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bluetooth.Name = "bluetooth";
            this.bluetooth.Size = new System.Drawing.Size(35, 35);
            this.bluetooth.TabIndex = 8;
            this.bluetooth.Text = " ";
            this.bluetooth.UseVisualStyleBackColor = true;
            this.bluetooth.Click += new System.EventHandler(this.bluetooth_Click);
            // 
            // whats
            // 
            this.whats.BackgroundImage = global::Picback.Properties.Resources.whatsapp;
            this.whats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.whats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whats.Location = new System.Drawing.Point(4, 154);
            this.whats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.whats.Name = "whats";
            this.whats.Size = new System.Drawing.Size(35, 35);
            this.whats.TabIndex = 17;
            this.whats.Text = " ";
            this.whats.UseVisualStyleBackColor = true;
            this.whats.Click += new System.EventHandler(this.whats_Click);
            // 
            // SS
            // 
            this.SS.BackgroundImage = global::Picback.Properties.Resources.ss;
            this.SS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SS.Location = new System.Drawing.Point(43, 76);
            this.SS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(35, 35);
            this.SS.TabIndex = 9;
            this.SS.Text = " ";
            this.SS.UseVisualStyleBackColor = true;
            this.SS.Click += new System.EventHandler(this.SS_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1082, 980);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picback";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox selectedImage;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.Button camera;
        private System.Windows.Forms.Button navnext;
        private System.Windows.Forms.Button bluetooth;
        private System.Windows.Forms.Button insta;
        private System.Windows.Forms.Button snap;
        private System.Windows.Forms.Button instaLY;
        private System.Windows.Forms.Button fb;
        private System.Windows.Forms.Button whats;
        private System.Windows.Forms.Button LR;
        private System.Windows.Forms.Button psfix;
        private System.Windows.Forms.Button CC;
        private System.Windows.Forms.Button psmix;
        private System.Windows.Forms.Button SS;
        private System.Windows.Forms.Button Polish;
        private System.Windows.Forms.Button instaSQ;
        private System.Windows.Forms.Button PL;
        private System.Windows.Forms.Button PA;
        private System.Windows.Forms.Button B612;
        private System.Windows.Forms.Button YC;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ComboBox driveList;
        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button navback;
        private System.Windows.Forms.Button backward;
        private System.Windows.Forms.Button retrica;
        private System.Windows.Forms.Button SSeed;
        private System.Windows.Forms.Button Psx;
        private System.Windows.Forms.Button fbM;
        private System.Windows.Forms.ProgressBar progress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel gre;
    }
}

