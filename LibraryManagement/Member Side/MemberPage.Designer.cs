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
            this.bookP = new System.Windows.Forms.LinkLabel();
            this.bookL = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbl = new System.Windows.Forms.PictureBox();
            this.pbj = new System.Windows.Forms.PictureBox();
            this.BJ = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Noti = new System.Windows.Forms.LinkLabel();
            this.upP = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.bookP);
            this.groupBox1.Controls.Add(this.bookL);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pbl);
            this.groupBox1.Controls.Add(this.pbj);
            this.groupBox1.Controls.Add(this.BJ);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox1.Location = new System.Drawing.Point(39, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bookP
            // 
            this.bookP.ActiveLinkColor = System.Drawing.Color.White;
            this.bookP.AutoSize = true;
            this.bookP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookP.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookP.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.bookP.LinkColor = System.Drawing.Color.Coral;
            this.bookP.Location = new System.Drawing.Point(944, 163);
            this.bookP.Name = "bookP";
            this.bookP.Padding = new System.Windows.Forms.Padding(2);
            this.bookP.Size = new System.Drawing.Size(123, 28);
            this.bookP.TabIndex = 15;
            this.bookP.TabStop = true;
            this.bookP.Text = "Book Possession";
            this.bookP.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bookP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bookP_LinkClicked);
            // 
            // bookL
            // 
            this.bookL.ActiveLinkColor = System.Drawing.Color.White;
            this.bookL.AutoSize = true;
            this.bookL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookL.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.bookL.LinkColor = System.Drawing.Color.Coral;
            this.bookL.Location = new System.Drawing.Point(578, 163);
            this.bookL.Name = "bookL";
            this.bookL.Padding = new System.Windows.Forms.Padding(2);
            this.bookL.Size = new System.Drawing.Size(79, 28);
            this.bookL.TabIndex = 14;
            this.bookL.TabStop = true;
            this.bookL.Text = "Book Log";
            this.bookL.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bookL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bookL_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagement.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(933, 19);
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
            this.pbl.Location = new System.Drawing.Point(546, 16);
            this.pbl.Name = "pbl";
            this.pbl.Size = new System.Drawing.Size(134, 136);
            this.pbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbl.TabIndex = 10;
            this.pbl.TabStop = false;
            this.pbl.Click += new System.EventHandler(this.pbl_Click);
            // 
            // pbj
            // 
            this.pbj.Image = global::LibraryManagement.Properties.Resources.pile_of_books;
            this.pbj.Location = new System.Drawing.Point(147, 16);
            this.pbj.Name = "pbj";
            this.pbj.Size = new System.Drawing.Size(134, 136);
            this.pbj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbj.TabIndex = 8;
            this.pbj.TabStop = false;
            this.pbj.Click += new System.EventHandler(this.pbj_Click);
            // 
            // BJ
            // 
            this.BJ.ActiveLinkColor = System.Drawing.Color.White;
            this.BJ.AutoSize = true;
            this.BJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BJ.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BJ.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.BJ.LinkColor = System.Drawing.Color.Coral;
            this.BJ.Location = new System.Drawing.Point(147, 163);
            this.BJ.Name = "BJ";
            this.BJ.Padding = new System.Windows.Forms.Padding(2);
            this.BJ.Size = new System.Drawing.Size(144, 28);
            this.BJ.TabIndex = 1;
            this.BJ.TabStop = true;
            this.BJ.Text = "Books and Journals";
            this.BJ.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BJ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BJ_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 415);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.Noti);
            this.groupBox2.Controls.Add(this.upP);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox2.Location = new System.Drawing.Point(39, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1198, 199);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Noti
            // 
            this.Noti.ActiveLinkColor = System.Drawing.Color.White;
            this.Noti.AutoSize = true;
            this.Noti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Noti.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Noti.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Noti.LinkColor = System.Drawing.Color.Coral;
            this.Noti.Location = new System.Drawing.Point(692, 163);
            this.Noti.Name = "Noti";
            this.Noti.Padding = new System.Windows.Forms.Padding(2);
            this.Noti.Size = new System.Drawing.Size(102, 28);
            this.Noti.TabIndex = 17;
            this.Noti.TabStop = true;
            this.Noti.Text = "Notifications";
            this.Noti.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Noti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Noti_LinkClicked);
            // 
            // upP
            // 
            this.upP.ActiveLinkColor = System.Drawing.Color.White;
            this.upP.AutoSize = true;
            this.upP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upP.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upP.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.upP.LinkColor = System.Drawing.Color.Coral;
            this.upP.Location = new System.Drawing.Point(386, 163);
            this.upP.Name = "upP";
            this.upP.Padding = new System.Windows.Forms.Padding(2);
            this.upP.Size = new System.Drawing.Size(112, 28);
            this.upP.TabIndex = 16;
            this.upP.TabStop = true;
            this.upP.Text = "Update Profile";
            this.upP.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.upP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.upP_LinkClicked);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(864, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1018, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "View Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(662, 22);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(168, 27);
            this.searchText.TabIndex = 15;
            this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.LinkLabel BJ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbj;
        private System.Windows.Forms.PictureBox pbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.LinkLabel bookL;
        private System.Windows.Forms.LinkLabel bookP;
        private System.Windows.Forms.LinkLabel upP;
        private System.Windows.Forms.LinkLabel Noti;
    }
}