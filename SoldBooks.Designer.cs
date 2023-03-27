
namespace BSM
{
    partial class SoldBooks
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
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortByUserNameComboBox = new System.Windows.Forms.ComboBox();
            this.sortByUserNameDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.sortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortByUserNameDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.sortByUserNameComboBox);
            this.sortGroupBox.Controls.Add(this.sortByUserNameDataGridView);
            this.sortGroupBox.Controls.Add(this.label1);
            this.sortGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupBox.Location = new System.Drawing.Point(15, 122);
            this.sortGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortGroupBox.Size = new System.Drawing.Size(1037, 527);
            this.sortGroupBox.TabIndex = 2;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sold Boooks";
            // 
            // sortByUserNameComboBox
            // 
            this.sortByUserNameComboBox.FormattingEnabled = true;
            this.sortByUserNameComboBox.Items.AddRange(new object[] {
            "All Genre"});
            this.sortByUserNameComboBox.Location = new System.Drawing.Point(436, 20);
            this.sortByUserNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortByUserNameComboBox.Name = "sortByUserNameComboBox";
            this.sortByUserNameComboBox.Size = new System.Drawing.Size(223, 30);
            this.sortByUserNameComboBox.TabIndex = 1;
            this.sortByUserNameComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByUserNameComboBox_SelectedIndexChanged);
            // 
            // sortByUserNameDataGridView
            // 
            this.sortByUserNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortByUserNameDataGridView.Location = new System.Drawing.Point(5, 73);
            this.sortByUserNameDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortByUserNameDataGridView.Name = "sortByUserNameDataGridView";
            this.sortByUserNameDataGridView.RowHeadersWidth = 51;
            this.sortByUserNameDataGridView.RowTemplate.Height = 24;
            this.sortByUserNameDataGridView.Size = new System.Drawing.Size(1027, 449);
            this.sortByUserNameDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seller Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(424, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 43);
            this.label6.TabIndex = 27;
            this.label6.Text = "BOOKAHOLIC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(15, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(76, 38);
            this.BackButton.TabIndex = 57;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SoldBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 662);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SoldBooks";
            this.Text = "SoldBooks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoldBooks_FormClosing);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortByUserNameDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.ComboBox sortByUserNameComboBox;
        private System.Windows.Forms.DataGridView sortByUserNameDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BackButton;
    }
}