
namespace BSM
{
    partial class AddBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manageBooksGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.publicationTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.manageBooksGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(535, 455);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // manageBooksGroupBox
            // 
            this.manageBooksGroupBox.Controls.Add(this.idTextBox);
            this.manageBooksGroupBox.Controls.Add(this.label4);
            this.manageBooksGroupBox.Controls.Add(this.priceTextBox);
            this.manageBooksGroupBox.Controls.Add(this.label1);
            this.manageBooksGroupBox.Controls.Add(this.deleteButton);
            this.manageBooksGroupBox.Controls.Add(this.updateButton);
            this.manageBooksGroupBox.Controls.Add(this.genreComboBox);
            this.manageBooksGroupBox.Controls.Add(this.addButton);
            this.manageBooksGroupBox.Controls.Add(this.quantityTextBox);
            this.manageBooksGroupBox.Controls.Add(this.publicationTextBox);
            this.manageBooksGroupBox.Controls.Add(this.bookNameTextBox);
            this.manageBooksGroupBox.Controls.Add(this.authorTextBox);
            this.manageBooksGroupBox.Controls.Add(this.label5);
            this.manageBooksGroupBox.Controls.Add(this.label3);
            this.manageBooksGroupBox.Controls.Add(this.label7);
            this.manageBooksGroupBox.Controls.Add(this.label8);
            this.manageBooksGroupBox.Controls.Add(this.label2);
            this.manageBooksGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBooksGroupBox.Location = new System.Drawing.Point(11, 111);
            this.manageBooksGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageBooksGroupBox.Name = "manageBooksGroupBox";
            this.manageBooksGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageBooksGroupBox.Size = new System.Drawing.Size(384, 444);
            this.manageBooksGroupBox.TabIndex = 36;
            this.manageBooksGroupBox.TabStop = false;
            this.manageBooksGroupBox.Text = "Add / Update / Edit Books";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(109, 25);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(254, 24);
            this.idTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(109, 347);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(254, 24);
            this.priceTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(266, 397);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(155, 397);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(84, 34);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "BookName",
            "Aurher"});
            this.genreComboBox.Location = new System.Drawing.Point(109, 181);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(254, 25);
            this.genreComboBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(40, 397);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(109, 289);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(254, 24);
            this.quantityTextBox.TabIndex = 1;
            // 
            // publicationTextBox
            // 
            this.publicationTextBox.Location = new System.Drawing.Point(109, 233);
            this.publicationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.publicationTextBox.Name = "publicationTextBox";
            this.publicationTextBox.Size = new System.Drawing.Size(254, 24);
            this.publicationTextBox.TabIndex = 1;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(109, 72);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(254, 24);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(109, 124);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(254, 24);
            this.authorTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Publication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(337, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 35);
            this.label6.TabIndex = 38;
            this.label6.Text = "BOOKAHOLIC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(11, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(57, 31);
            this.BackButton.TabIndex = 58;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 578);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manageBooksGroupBox);
            this.Name = "AddBook";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBook_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.manageBooksGroupBox.ResumeLayout(false);
            this.manageBooksGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox manageBooksGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox publicationTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label5;
    }
}