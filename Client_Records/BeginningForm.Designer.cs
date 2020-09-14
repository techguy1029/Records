namespace Client_Records
{
    partial class BeginningForm
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
            this.buttonNewEntry = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchTerm = new System.Windows.Forms.TextBox();
            this.radioButtonColumn1 = new System.Windows.Forms.RadioButton();
            this.radioButtonColumn2 = new System.Windows.Forms.RadioButton();
            this.radioButtonColumn4 = new System.Windows.Forms.RadioButton();
            this.radioButtonColumn3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(811, 743);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonNewEntry
            // 
            this.buttonNewEntry.Location = new System.Drawing.Point(977, 585);
            this.buttonNewEntry.Name = "buttonNewEntry";
            this.buttonNewEntry.Size = new System.Drawing.Size(191, 69);
            this.buttonNewEntry.TabIndex = 1;
            this.buttonNewEntry.Text = "New Entry";
            this.buttonNewEntry.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1142, 221);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(158, 76);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchTerm
            // 
            this.textBoxSearchTerm.Location = new System.Drawing.Point(841, 172);
            this.textBoxSearchTerm.Name = "textBoxSearchTerm";
            this.textBoxSearchTerm.Size = new System.Drawing.Size(459, 26);
            this.textBoxSearchTerm.TabIndex = 3;
            // 
            // radioButtonColumn1
            // 
            this.radioButtonColumn1.AutoSize = true;
            this.radioButtonColumn1.Location = new System.Drawing.Point(841, 221);
            this.radioButtonColumn1.Name = "radioButtonColumn1";
            this.radioButtonColumn1.Size = new System.Drawing.Size(97, 24);
            this.radioButtonColumn1.TabIndex = 4;
            this.radioButtonColumn1.TabStop = true;
            this.radioButtonColumn1.Text = "Column1";
            this.radioButtonColumn1.UseVisualStyleBackColor = true;
            // 
            // radioButtonColumn2
            // 
            this.radioButtonColumn2.AutoSize = true;
            this.radioButtonColumn2.Location = new System.Drawing.Point(841, 273);
            this.radioButtonColumn2.Name = "radioButtonColumn2";
            this.radioButtonColumn2.Size = new System.Drawing.Size(97, 24);
            this.radioButtonColumn2.TabIndex = 5;
            this.radioButtonColumn2.TabStop = true;
            this.radioButtonColumn2.Text = "Column2";
            this.radioButtonColumn2.UseVisualStyleBackColor = true;
            // 
            // radioButtonColumn4
            // 
            this.radioButtonColumn4.AutoSize = true;
            this.radioButtonColumn4.Location = new System.Drawing.Point(977, 273);
            this.radioButtonColumn4.Name = "radioButtonColumn4";
            this.radioButtonColumn4.Size = new System.Drawing.Size(97, 24);
            this.radioButtonColumn4.TabIndex = 7;
            this.radioButtonColumn4.TabStop = true;
            this.radioButtonColumn4.Text = "Column4";
            this.radioButtonColumn4.UseVisualStyleBackColor = true;
            // 
            // radioButtonColumn3
            // 
            this.radioButtonColumn3.AutoSize = true;
            this.radioButtonColumn3.Location = new System.Drawing.Point(977, 221);
            this.radioButtonColumn3.Name = "radioButtonColumn3";
            this.radioButtonColumn3.Size = new System.Drawing.Size(97, 24);
            this.radioButtonColumn3.TabIndex = 6;
            this.radioButtonColumn3.TabStop = true;
            this.radioButtonColumn3.Text = "Column3";
            this.radioButtonColumn3.UseVisualStyleBackColor = true;
            // 
            // BeginningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 789);
            this.Controls.Add(this.radioButtonColumn4);
            this.Controls.Add(this.radioButtonColumn3);
            this.Controls.Add(this.radioButtonColumn2);
            this.Controls.Add(this.radioButtonColumn1);
            this.Controls.Add(this.textBoxSearchTerm);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonNewEntry);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BeginningForm";
            this.Text = "Browse Data";
            this.Load += new System.EventHandler(this.BeginningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNewEntry;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchTerm;
        private System.Windows.Forms.RadioButton radioButtonColumn1;
        private System.Windows.Forms.RadioButton radioButtonColumn2;
        private System.Windows.Forms.RadioButton radioButtonColumn4;
        private System.Windows.Forms.RadioButton radioButtonColumn3;
    }
}

