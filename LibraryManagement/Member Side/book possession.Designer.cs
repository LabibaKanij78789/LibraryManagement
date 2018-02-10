namespace LibraryManagement
{
    partial class book_possession
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
            this.booksBorrowed = new System.Windows.Forms.DataGridView();
            this.booksBought = new System.Windows.Forms.DataGridView();
            this.buy = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksBorrowed
            // 
            this.booksBorrowed.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.booksBorrowed.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.booksBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksBorrowed.Location = new System.Drawing.Point(176, 170);
            this.booksBorrowed.Name = "booksBorrowed";
            this.booksBorrowed.Size = new System.Drawing.Size(444, 388);
            this.booksBorrowed.TabIndex = 0;
            this.booksBorrowed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksBorrowed_CellContentClick);
            // 
            // booksBought
            // 
            this.booksBought.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.booksBought.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.booksBought.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksBought.Location = new System.Drawing.Point(697, 170);
            this.booksBought.Name = "booksBought";
            this.booksBought.Size = new System.Drawing.Size(438, 388);
            this.booksBought.TabIndex = 1;
            this.booksBought.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksBought_CellContentClick);
            // 
            // buy
            // 
            this.buy.AutoSize = true;
            this.buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buy.Location = new System.Drawing.Point(863, 132);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(98, 25);
            this.buy.TabIndex = 3;
            this.buy.Text = "Buy Log";
            // 
            // borrow
            // 
            this.borrow.AutoSize = true;
            this.borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.borrow.Location = new System.Drawing.Point(351, 132);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(131, 25);
            this.borrow.TabIndex = 4;
            this.borrow.Text = "Borrow Log";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryManagement.Properties.Resources.back_1689836_960_720;
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.back_1689836_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(1079, 601);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // book_possession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.booksBought);
            this.Controls.Add(this.booksBorrowed);
            this.Name = "book_possession";
            this.Text = "book_possession";
            this.Load += new System.EventHandler(this.book_possession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksBorrowed;
        private System.Windows.Forms.DataGridView booksBought;
        private System.Windows.Forms.Label buy;
        private System.Windows.Forms.Label borrow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}