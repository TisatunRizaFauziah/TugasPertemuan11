namespace TugasPertemuan11.View
{
    partial class FormUpdatePeserta
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
            this.btnUPNgisiPL = new System.Windows.Forms.Button();
            this.dataGridViewUpdatePs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdatePs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUPNgisiPL
            // 
            this.btnUPNgisiPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUPNgisiPL.BackColor = System.Drawing.Color.Red;
            this.btnUPNgisiPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPNgisiPL.ForeColor = System.Drawing.Color.Black;
            this.btnUPNgisiPL.Location = new System.Drawing.Point(871, 567);
            this.btnUPNgisiPL.Name = "btnUPNgisiPL";
            this.btnUPNgisiPL.Size = new System.Drawing.Size(185, 71);
            this.btnUPNgisiPL.TabIndex = 46;
            this.btnUPNgisiPL.Text = "Update";
            this.btnUPNgisiPL.UseVisualStyleBackColor = false;
            this.btnUPNgisiPL.Click += new System.EventHandler(this.btnUPNgisiPL_Click);
            // 
            // dataGridViewUpdatePs
            // 
            this.dataGridViewUpdatePs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUpdatePs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUpdatePs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdatePs.Location = new System.Drawing.Point(39, 136);
            this.dataGridViewUpdatePs.Name = "dataGridViewUpdatePs";
            this.dataGridViewUpdatePs.RowHeadersWidth = 62;
            this.dataGridViewUpdatePs.RowTemplate.Height = 28;
            this.dataGridViewUpdatePs.Size = new System.Drawing.Size(1017, 392);
            this.dataGridViewUpdatePs.TabIndex = 45;
            this.dataGridViewUpdatePs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdatePL_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 63);
            this.label2.TabIndex = 44;
            this.label2.Text = "Update Peserta";
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(81, 567);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(185, 71);
            this.btnexit.TabIndex = 48;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FormUpdatePeserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1119, 689);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnUPNgisiPL);
            this.Controls.Add(this.dataGridViewUpdatePs);
            this.Controls.Add(this.label2);
            this.Name = "FormUpdatePeserta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdatePeserta";
            this.Load += new System.EventHandler(this.FormUpdatePeserta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdatePs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUPNgisiPL;
        private System.Windows.Forms.DataGridView dataGridViewUpdatePs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
    }
}