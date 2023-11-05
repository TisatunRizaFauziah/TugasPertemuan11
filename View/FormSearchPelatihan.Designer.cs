namespace TugasPertemuan11.View
{
    partial class FormSearchPelatihan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchPelatihan));
            this.txtSearchPL = new System.Windows.Forms.TextBox();
            this.btnPrintPelatihan = new System.Windows.Forms.Button();
            this.btnSearchPL = new System.Windows.Forms.Button();
            this.dataGridViewSearchPelatihan = new System.Windows.Forms.DataGridView();
            this.btnExitPelatihan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1PL = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentPL = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPelatihan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchPL
            // 
            this.txtSearchPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPL.Location = new System.Drawing.Point(466, 80);
            this.txtSearchPL.Multiline = true;
            this.txtSearchPL.Name = "txtSearchPL";
            this.txtSearchPL.Size = new System.Drawing.Size(413, 51);
            this.txtSearchPL.TabIndex = 69;
            // 
            // btnPrintPelatihan
            // 
            this.btnPrintPelatihan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPelatihan.BackColor = System.Drawing.Color.Red;
            this.btnPrintPelatihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPelatihan.Location = new System.Drawing.Point(787, 596);
            this.btnPrintPelatihan.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrintPelatihan.Name = "btnPrintPelatihan";
            this.btnPrintPelatihan.Size = new System.Drawing.Size(92, 50);
            this.btnPrintPelatihan.TabIndex = 67;
            this.btnPrintPelatihan.Text = "Print";
            this.btnPrintPelatihan.UseVisualStyleBackColor = false;
            this.btnPrintPelatihan.Click += new System.EventHandler(this.btnPrintPelatihan_Click);
            // 
            // btnSearchPL
            // 
            this.btnSearchPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPL.Location = new System.Drawing.Point(898, 80);
            this.btnSearchPL.Name = "btnSearchPL";
            this.btnSearchPL.Size = new System.Drawing.Size(100, 51);
            this.btnSearchPL.TabIndex = 68;
            this.btnSearchPL.Text = "Search";
            this.btnSearchPL.UseVisualStyleBackColor = true;
            this.btnSearchPL.Click += new System.EventHandler(this.btnSearchPL_Click);
            // 
            // dataGridViewSearchPelatihan
            // 
            this.dataGridViewSearchPelatihan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchPelatihan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSearchPelatihan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchPelatihan.Location = new System.Drawing.Point(40, 174);
            this.dataGridViewSearchPelatihan.Name = "dataGridViewSearchPelatihan";
            this.dataGridViewSearchPelatihan.RowHeadersWidth = 62;
            this.dataGridViewSearchPelatihan.RowTemplate.Height = 28;
            this.dataGridViewSearchPelatihan.Size = new System.Drawing.Size(1037, 370);
            this.dataGridViewSearchPelatihan.TabIndex = 66;
            // 
            // btnExitPelatihan
            // 
            this.btnExitPelatihan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitPelatihan.BackColor = System.Drawing.Color.Red;
            this.btnExitPelatihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPelatihan.Location = new System.Drawing.Point(949, 596);
            this.btnExitPelatihan.Name = "btnExitPelatihan";
            this.btnExitPelatihan.Size = new System.Drawing.Size(92, 50);
            this.btnExitPelatihan.TabIndex = 65;
            this.btnExitPelatihan.Text = "Exit";
            this.btnExitPelatihan.UseVisualStyleBackColor = false;
            this.btnExitPelatihan.Click += new System.EventHandler(this.btnExitPelatihan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 63);
            this.label2.TabIndex = 64;
            this.label2.Text = "Search Pelatihan";
            // 
            // printPreviewDialog1PL
            // 
            this.printPreviewDialog1PL.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1PL.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1PL.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1PL.Enabled = true;
            this.printPreviewDialog1PL.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1PL.Icon")));
            this.printPreviewDialog1PL.Name = "printPreviewDialog1";
            this.printPreviewDialog1PL.Visible = false;
            // 
            // printDocumentPL
            // 
            this.printDocumentPL.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentPL_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TugasPertemuan11.Properties.Resources.search_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.Location = new System.Drawing.Point(1004, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // FormSearchPelatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1117, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchPL);
            this.Controls.Add(this.btnPrintPelatihan);
            this.Controls.Add(this.btnSearchPL);
            this.Controls.Add(this.dataGridViewSearchPelatihan);
            this.Controls.Add(this.btnExitPelatihan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSearchPelatihan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchPelatihan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPelatihan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchPL;
        public System.Windows.Forms.Button btnPrintPelatihan;
        private System.Windows.Forms.Button btnSearchPL;
        private System.Windows.Forms.DataGridView dataGridViewSearchPelatihan;
        private System.Windows.Forms.Button btnExitPelatihan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1PL;
        private System.Drawing.Printing.PrintDocument printDocumentPL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}