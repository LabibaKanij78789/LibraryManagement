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
            this.button1 = new System.Windows.Forms.Button();
            this.searchInput = new LibraryManagement.CustomTextBox();
            this.bookData = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(1029, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchInput
            // 
            this.searchInput.AcceptsTab = true;
            this.searchInput.BackColor = System.Drawing.Color.Transparent;
            this.searchInput.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.ForeColor = System.Drawing.Color.LightSalmon;
            this.searchInput.Location = new System.Drawing.Point(755, 42);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(233, 33);
            this.searchInput.TabIndex = 4;
            this.searchInput.Click += new System.EventHandler(this.searchInput_Click);
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged_1);
            // 
            // bookData
            // 
            this.bookData.AllowUserToAddRows = false;
            this.bookData.AllowUserToDeleteRows = false;
            this.bookData.AllowUserToOrderColumns = true;
            this.bookData.AllowUserToResizeRows = false;
            this.bookData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.bookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookData.Location = new System.Drawing.Point(79, 161);
            this.bookData.Name = "bookData";
            this.bookData.Size = new System.Drawing.Size(986, 464);
            this.bookData.TabIndex = 5;
            this.bookData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookData_CellClick);
            this.bookData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookData_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(1123, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(1123, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Borrow";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // book_journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bookData);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.button1);
            this.Name = "book_journal";
            this.Text = "book_journal";
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private CustomTextBox searchInput;
        private System.Windows.Forms.DataGridView bookData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}