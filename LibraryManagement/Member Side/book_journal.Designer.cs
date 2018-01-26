namespace LibraryManagement
{
    partial class book_journal
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bookData = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.LinkLabel();
            this.buy = new System.Windows.Forms.LinkLabel();
            this.borrow = new System.Windows.Forms.LinkLabel();
            this.bookPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bookData
            // 
            this.bookData.AllowUserToAddRows = false;
            this.bookData.AllowUserToDeleteRows = false;
            this.bookData.AllowUserToOrderColumns = true;
            this.bookData.AllowUserToResizeRows = false;
            this.bookData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.bookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookData.Location = new System.Drawing.Point(75, 161);
            this.bookData.Name = "bookData";
            this.bookData.Size = new System.Drawing.Size(639, 409);
            this.bookData.TabIndex = 5;
            this.bookData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookData_CellClick);
            this.bookData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookData_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagement.Properties.Resources.back_1689836_960_720;
            this.pictureBox2.Location = new System.Drawing.Point(1184, 606);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(897, 43);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(168, 27);
            this.searchInput.TabIndex = 16;
            // 
            // search
            // 
            this.search.ActiveLinkColor = System.Drawing.Color.White;
            this.search.AutoSize = true;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.search.LinkColor = System.Drawing.Color.Coral;
            this.search.Location = new System.Drawing.Point(1107, 42);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(2);
            this.search.Size = new System.Drawing.Size(60, 28);
            this.search.TabIndex = 17;
            this.search.TabStop = true;
            this.search.Text = "Search";
            this.search.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.search_LinkClicked);
            // 
            // buy
            // 
            this.buy.ActiveLinkColor = System.Drawing.Color.White;
            this.buy.AutoSize = true;
            this.buy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buy.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.buy.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buy.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.buy.LinkColor = System.Drawing.Color.Coral;
            this.buy.Location = new System.Drawing.Point(833, 628);
            this.buy.Name = "buy";
            this.buy.Padding = new System.Windows.Forms.Padding(2);
            this.buy.Size = new System.Drawing.Size(42, 28);
            this.buy.TabIndex = 18;
            this.buy.TabStop = true;
            this.buy.Text = "Buy";
            this.buy.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buy_LinkClicked);
            // 
            // borrow
            // 
            this.borrow.ActiveLinkColor = System.Drawing.Color.White;
            this.borrow.AutoSize = true;
            this.borrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borrow.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.borrow.LinkColor = System.Drawing.Color.Coral;
            this.borrow.Location = new System.Drawing.Point(948, 628);
            this.borrow.Name = "borrow";
            this.borrow.Padding = new System.Windows.Forms.Padding(2);
            this.borrow.Size = new System.Drawing.Size(65, 28);
            this.borrow.TabIndex = 19;
            this.borrow.TabStop = true;
            this.borrow.Text = "Borrow";
            this.borrow.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.borrow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // bookPanel
            // 
            this.bookPanel.AutoScroll = true;
            this.bookPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPanel.Location = new System.Drawing.Point(777, 161);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(288, 409);
            this.bookPanel.TabIndex = 20;
            // 
            // book_journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bookData);
            this.Name = "book_journal";
            this.Text = "book_journal";
            this.Load += new System.EventHandler(this.book_journal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView bookData;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.LinkLabel search;
        private System.Windows.Forms.LinkLabel buy;
        private System.Windows.Forms.LinkLabel borrow;
        private System.Windows.Forms.Panel bookPanel;
    }
}