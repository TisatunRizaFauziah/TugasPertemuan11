namespace TugasPertemuan11.View
{
    partial class FormSearchPeserta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchPeserta));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPrintPeserta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSearchPeserta = new System.Windows.Forms.DataGridView();
            this.btnExitPeserta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialogPS = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentPS = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPeserta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(471, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 51);
            this.textBox1.TabIndex = 62;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPrintPeserta
            // 
            this.btnPrintPeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPeserta.BackColor = System.Drawing.Color.Red;
            this.btnPrintPeserta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPeserta.Location = new System.Drawing.Point(775, 602);
            this.btnPrintPeserta.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrintPeserta.Name = "btnPrintPeserta";
            this.btnPrintPeserta.Size = new System.Drawing.Size(92, 50);
            this.btnPrintPeserta.TabIndex = 59;
            this.btnPrintPeserta.Text = "Print";
            this.btnPrintPeserta.UseVisualStyleBackColor = false;
            this.btnPrintPeserta.Click += new System.EventHandler(this.btnPrintPeserta_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(923, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 51);
            this.button1.TabIndex = 61;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewSearchPeserta
            // 
            this.dataGridViewSearchPeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchPeserta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSearchPeserta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchPeserta.Location = new System.Drawing.Point(28, 180);
            this.dataGridViewSearchPeserta.Name = "dataGridViewSearchPeserta";
            this.dataGridViewSearchPeserta.RowHeadersWidth = 62;
            this.dataGridViewSearchPeserta.RowTemplate.Height = 28;
            this.dataGridViewSearchPeserta.Size = new System.Drawing.Size(1037, 370);
            this.dataGridViewSearchPeserta.TabIndex = 58;
            // 
            // btnExitPeserta
            // 
            this.btnExitPeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitPeserta.BackColor = System.Drawing.Color.Red;
            this.btnExitPeserta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPeserta.Location = new System.Drawing.Point(937, 602);
            this.btnExitPeserta.Name = "btnExitPeserta";
            this.btnExitPeserta.Size = new System.Drawing.Size(92, 50);
            this.btnExitPeserta.TabIndex = 57;
            this.btnExitPeserta.Text = "Exit";
            this.btnExitPeserta.UseVisualStyleBackColor = false;
            this.btnExitPeserta.Click += new System.EventHandler(this.btnExitPeserta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 63);
            this.label2.TabIndex = 47;
            this.label2.Text = "Search Peserta";
            // 
            // printPreviewDialogPS
            // 
            this.printPreviewDialogPS.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPS.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPS.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogPS.Enabled = true;
            this.printPreviewDialogPS.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogPS.Icon")));
            this.printPreviewDialogPS.Name = "printPreviewDialog1";
            this.printPreviewDialogPS.Visible = false;
            this.printPreviewDialogPS.Load += new System.EventHandler(this.printPreviewDialogPS_Load);
            // 
            // printDocumentPS
            // 
            this.printDocumentPS.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TugasPertemuan11.Properties.Resources.search_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // FormSearchPeserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1117, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPrintPeserta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSearchPeserta);
            this.Controls.Add(this.btnExitPeserta);
            this.Controls.Add(this.label2);
            this.Name = "FormSearchPeserta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchPeserta";
            this.Load += new System.EventHandler(this.FormSearchPeserta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPeserta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnPrintPeserta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSearchPeserta;
        private System.Windows.Forms.Button btnExitPeserta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogPS;
        private System.Drawing.Printing.PrintDocument printDocumentPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}