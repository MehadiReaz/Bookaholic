
namespace BSM
{
    partial class SellBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.manageBooksGroupBox = new System.Windows.Forms.GroupBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.publicationTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.sortByGenreComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manageBooksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(415, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 43);
            this.label6.TabIndex = 33;
            this.label6.Text = "BOOKAHOLIC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manageBooksGroupBox
            // 
            this.manageBooksGroupBox.Controls.Add(this.quantityTextBox);
            this.manageBooksGroupBox.Controls.Add(this.label10);
            this.manageBooksGroupBox.Controls.Add(this.dateTimePickerDoB);
            this.manageBooksGroupBox.Controls.Add(this.label9);
            this.manageBooksGroupBox.Controls.Add(this.idTextBox);
            this.manageBooksGroupBox.Controls.Add(this.genreComboBox);
            this.manageBooksGroupBox.Controls.Add(this.label4);
            this.manageBooksGroupBox.Controls.Add(this.addButton);
            this.manageBooksGroupBox.Controls.Add(this.priceTextBox);
            this.manageBooksGroupBox.Controls.Add(this.publicationTextBox);
            this.manageBooksGroupBox.Controls.Add(this.BookNameTextBox);
            this.manageBooksGroupBox.Controls.Add(this.authorTextBox);
            this.manageBooksGroupBox.Controls.Add(this.label5);
            this.manageBooksGroupBox.Controls.Add(this.label3);
            this.manageBooksGroupBox.Controls.Add(this.label7);
            this.manageBooksGroupBox.Controls.Add(this.label8);
            this.manageBooksGroupBox.Controls.Add(this.label2);
            this.manageBooksGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBooksGroupBox.Location = new System.Drawing.Point(15, 98);
            this.manageBooksGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageBooksGroupBox.Name = "manageBooksGroupBox";
            this.manageBooksGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageBooksGroupBox.Size = new System.Drawing.Size(512, 536);
            this.manageBooksGroupBox.TabIndex = 34;
            this.manageBooksGroupBox.TabStop = false;
            this.manageBooksGroupBox.Text = "Add / Update / Edit Books";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(144, 439);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(337, 28);
            this.quantityTextBox.TabIndex = 66;
            this.quantityTextBox.Leave += new System.EventHandler(this.quantityTextBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 65;
            this.label10.Text = "Quantity";
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoB.Location = new System.Drawing.Point(145, 389);
            this.dateTimePickerDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.Size = new System.Drawing.Size(336, 28);
            this.dateTimePickerDoB.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "Date";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(145, 84);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(337, 28);
            this.idTextBox.TabIndex = 62;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "BookName",
            "Aurher"});
            this.genreComboBox.Location = new System.Drawing.Point(144, 234);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(337, 30);
            this.genreComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Id";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(144, 490);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(208, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Sell";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(144, 341);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(337, 28);
            this.priceTextBox.TabIndex = 1;
            // 
            // publicationTextBox
            // 
            this.publicationTextBox.Location = new System.Drawing.Point(144, 282);
            this.publicationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicationTextBox.Name = "publicationTextBox";
            this.publicationTextBox.Size = new System.Drawing.Size(337, 28);
            this.publicationTextBox.TabIndex = 1;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Enabled = false;
            this.BookNameTextBox.Location = new System.Drawing.Point(144, 131);
            this.BookNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(337, 28);
            this.BookNameTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(144, 183);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(337, 28);
            this.authorTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Publication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(713, 517);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(15, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(76, 38);
            this.BackButton.TabIndex = 58;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // sortByGenreComboBox
            // 
            this.sortByGenreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByGenreComboBox.FormattingEnabled = true;
            this.sortByGenreComboBox.Items.AddRange(new object[] {
            "All Genre"});
            this.sortByGenreComboBox.Location = new System.Drawing.Point(961, 73);
            this.sortByGenreComboBox.Name = "sortByGenreComboBox";
            this.sortByGenreComboBox.Size = new System.Drawing.Size(222, 30);
            this.sortByGenreComboBox.TabIndex = 60;
            this.sortByGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByGenreComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Sort by Genre";
            // 
            // SellBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 645);
            this.Controls.Add(this.sortByGenreComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manageBooksGroupBox);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellBook_FormClosing);
            this.manageBooksGroupBox.ResumeLayout(false);
            this.manageBooksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox manageBooksGroupBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox publicationTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox sortByGenreComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
    }
}