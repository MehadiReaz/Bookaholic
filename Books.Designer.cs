
namespace BSM
{
    partial class Books
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
            this.BackButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.AvailableBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(15, 14);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(76, 38);
            this.BackButton.TabIndex = 56;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(431, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 43);
            this.label6.TabIndex = 57;
            this.label6.Text = "BOOKAHOLIC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.genreComboBox);
            this.sortGroupBox.Controls.Add(this.AvailableBooksDataGridView);
            this.sortGroupBox.Controls.Add(this.label1);
            this.sortGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupBox.Location = new System.Drawing.Point(15, 103);
            this.sortGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortGroupBox.Size = new System.Drawing.Size(1037, 588);
            this.sortGroupBox.TabIndex = 58;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Total Available Boooks";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "All Genre"});
            this.genreComboBox.Location = new System.Drawing.Point(436, 20);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(223, 30);
            this.genreComboBox.TabIndex = 1;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // AvailableBooksDataGridView
            // 
            this.AvailableBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableBooksDataGridView.Location = new System.Drawing.Point(5, 73);
            this.AvailableBooksDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailableBooksDataGridView.Name = "AvailableBooksDataGridView";
            this.AvailableBooksDataGridView.RowHeadersWidth = 51;
            this.AvailableBooksDataGridView.RowTemplate.Height = 24;
            this.AvailableBooksDataGridView.Size = new System.Drawing.Size(1027, 511);
            this.AvailableBooksDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 705);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BackButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Books";
            this.Text = "Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Books_FormClosing);
            this.Load += new System.EventHandler(this.Books_Load);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableBooksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.DataGridView AvailableBooksDataGridView;
        private System.Windows.Forms.Label label1;
    }
}