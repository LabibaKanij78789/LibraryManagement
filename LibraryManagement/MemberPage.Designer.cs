namespace LibraryManagement
{
    partial class MemberPage
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
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbl = new System.Windows.Forms.PictureBox();
            this.pgs = new System.Windows.Forms.PictureBox();
            this.pbj = new System.Windows.Forms.PictureBox();
            this.BP = new System.Windows.Forms.LinkLabel();
            this.BL = new System.Windows.Forms.LinkLabel();
            this.GS = new System.Windows.Forms.LinkLabel();
            this.BJ = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Noti = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.UP = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbj)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.No;
            this.title.Font = new System.Drawing.Font("Niagara Solid", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.title.Location = new System.Drawing.Point(37, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(352, 85);
            this.title.TabIndex = 1;
            this.title.Text = "The Athenaeuam";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(1190, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.userName.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userName.Location = new System.Drawing.Point(1045, 18);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(49, 30);
            this.userName.TabIndex = 5;
            this.userName.TabStop = true;
            this.userName.Text = "Hi, ";
            this.userName.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pbl);
            this.groupBox1.Controls.Add(this.pgs);
            this.groupBox1.Controls.Add(this.pbj);
            this.groupBox1.Controls.Add(this.BP);
            this.groupBox1.Controls.Add(this.BL);
            this.groupBox1.Controls.Add(this.GS);
            this.groupBox1.Controls.Add(this.BJ);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox1.Location = new System.Drawing.Point(39, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagement.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(979, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbl
            // 
            this.pbl.Image = global::LibraryManagement.Properties.Resources.booklog;
            this.pbl.Location = new System.Drawing.Point(673, 19);
            this.pbl.Name = "pbl";
            this.pbl.Size = new System.Drawing.Size(134, 136);
            this.pbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbl.TabIndex = 10;
            this.pbl.TabStop = false;
            this.pbl.Click += new System.EventHandler(this.pbl_Click);
            // 
            // pgs
            // 
            this.pgs.Image = global::LibraryManagement.Properties.Resources.suggestion;
            this.pgs.Location = new System.Drawing.Point(375, 19);
            this.pgs.Name = "pgs";
            this.pgs.Size = new System.Drawing.Size(134, 136);
            this.pgs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgs.TabIndex = 9;
            this.pgs.TabStop = false;
            // 
            // pbj
            // 
            this.pbj.Image = global::LibraryManagement.Properties.Resources.pile_of_books;
            this.pbj.Location = new System.Drawing.Point(64, 19);
            this.pbj.Name = "pbj";
            this.pbj.Size = new System.Drawing.Size(134, 136);
            this.pbj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbj.TabIndex = 8;
            this.pbj.TabStop = false;
            this.pbj.Click += new System.EventHandler(this.pbj_Click);
            // 
            // BP
            // 
            this.BP.AutoSize = true;
            this.BP.Location = new System.Drawing.Point(999, 168);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(88, 13);
            this.BP.TabIndex = 7;
            this.BP.TabStop = true;
            this.BP.Text = "Book Possession";
            this.BP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BP_LinkClicked);
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.Location = new System.Drawing.Point(711, 168);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(53, 13);
            this.BL.TabIndex = 5;
            this.BL.TabStop = true;
            this.BL.Text = "Book Log";
            this.BL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BL_LinkClicked);
            // 
            // GS
            // 
            this.GS.AutoSize = true;
            this.GS.Location = new System.Drawing.Point(388, 168);
            this.GS.Name = "GS";
            this.GS.Size = new System.Drawing.Size(85, 13);
            this.GS.TabIndex = 3;
            this.GS.TabStop = true;
            this.GS.Text = "Get Suggestions";
            this.GS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GS_LinkClicked);
            // 
            // BJ
            // 
            this.BJ.AutoSize = true;
            this.BJ.Location = new System.Drawing.Point(75, 168);
            this.BJ.Name = "BJ";
            this.BJ.Size = new System.Drawing.Size(100, 13);
            this.BJ.TabIndex = 1;
            this.BJ.TabStop = true;
            this.BJ.Text = "Books and Journals";
            this.BJ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BJ_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.Noti);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.UP);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox2.Location = new System.Drawing.Point(39, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1198, 199);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryManagement.Properties.Resources.notification_512;
            this.pictureBox4.Location = new System.Drawing.Point(673, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(134, 136);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryManagement.Properties.Resources.update;
            this.pictureBox3.Location = new System.Drawing.Point(375, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Noti
            // 
            this.Noti.AutoSize = true;
            this.Noti.Location = new System.Drawing.Point(711, 168);
            this.Noti.Name = "Noti";
            this.Noti.Size = new System.Drawing.Size(60, 13);
            this.Noti.TabIndex = 5;
            this.Noti.TabStop = true;
            this.Noti.Text = "Notification";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(644, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 136);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // UP
            // 
            this.UP.AutoSize = true;
            this.UP.Location = new System.Drawing.Point(399, 168);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(74, 13);
            this.UP.TabIndex = 3;
            this.UP.TabStop = true;
            this.UP.Text = "Update Profile";
            this.UP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UP_LinkClicked);
            // 
            // MemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MemberPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MemberPage";
            this.Load += new System.EventHandler(this.MemberPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbj)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel userName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel BP;
        private System.Windows.Forms.LinkLabel BL;
        private System.Windows.Forms.LinkLabel GS;
        private System.Windows.Forms.LinkLabel BJ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel Noti;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.LinkLabel UP;
        private System.Windows.Forms.PictureBox pbj;
        private System.Windows.Forms.PictureBox pgs;
        private System.Windows.Forms.PictureBox pbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}