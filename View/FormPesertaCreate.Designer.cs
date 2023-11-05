namespace TugasPertemuan11.View
{
    partial class FormPesertaCreate
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
            this.dataGridViewCreatePeserta = new System.Windows.Forms.DataGridView();
            this.btnExitPeserta = new System.Windows.Forms.Button();
            this.btnsavePeserta = new System.Windows.Forms.Button();
            this.txtNoCrPeserta = new System.Windows.Forms.TextBox();
            this.txtemailCrPeserta = new System.Windows.Forms.TextBox();
            this.txtnamaCRpeserta = new System.Windows.Forms.TextBox();
            this.txtidcrPeserta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreatePeserta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCreatePeserta
            // 
            this.dataGridViewCreatePeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCreatePeserta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCreatePeserta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreatePeserta.Location = new System.Drawing.Point(45, 105);
            this.dataGridViewCreatePeserta.Name = "dataGridViewCreatePeserta";
            this.dataGridViewCreatePeserta.RowHeadersWidth = 62;
            this.dataGridViewCreatePeserta.RowTemplate.Height = 28;
            this.dataGridViewCreatePeserta.Size = new System.Drawing.Size(1018, 312);
            this.dataGridViewCreatePeserta.TabIndex = 42;
            // 
            // btnExitPeserta
            // 
            this.btnExitPeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitPeserta.BackColor = System.Drawing.Color.Red;
            this.btnExitPeserta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPeserta.Location = new System.Drawing.Point(981, 602);
            this.btnExitPeserta.Name = "btnExitPeserta";
            this.btnExitPeserta.Size = new System.Drawing.Size(92, 50);
            this.btnExitPeserta.TabIndex = 41;
            this.btnExitPeserta.Text = "Exit";
            this.btnExitPeserta.UseVisualStyleBackColor = false;
            this.btnExitPeserta.Click += new System.EventHandler(this.btnExitPeserta_Click);
            // 
            // btnsavePeserta
            // 
            this.btnsavePeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsavePeserta.BackColor = System.Drawing.Color.Red;
            this.btnsavePeserta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavePeserta.Location = new System.Drawing.Point(813, 602);
            this.btnsavePeserta.Margin = new System.Windows.Forms.Padding(5);
            this.btnsavePeserta.Name = "btnsavePeserta";
            this.btnsavePeserta.Size = new System.Drawing.Size(92, 50);
            this.btnsavePeserta.TabIndex = 40;
            this.btnsavePeserta.Text = "Save";
            this.btnsavePeserta.UseVisualStyleBackColor = false;
            this.btnsavePeserta.Click += new System.EventHandler(this.btnsavePeserta_Click_1);
            // 
            // txtNoCrPeserta
            // 
            this.txtNoCrPeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoCrPeserta.Location = new System.Drawing.Point(815, 519);
            this.txtNoCrPeserta.Multiline = true;
            this.txtNoCrPeserta.Name = "txtNoCrPeserta";
            this.txtNoCrPeserta.Size = new System.Drawing.Size(260, 30);
            this.txtNoCrPeserta.TabIndex = 35;
            // 
            // txtemailCrPeserta
            // 
            this.txtemailCrPeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemailCrPeserta.Location = new System.Drawing.Point(815, 463);
            this.txtemailCrPeserta.Multiline = true;
            this.txtemailCrPeserta.Name = "txtemailCrPeserta";
            this.txtemailCrPeserta.Size = new System.Drawing.Size(260, 30);
            this.txtemailCrPeserta.TabIndex = 34;
            this.txtemailCrPeserta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemailCrPeserta_KeyPress);
            // 
            // txtnamaCRpeserta
            // 
            this.txtnamaCRpeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnamaCRpeserta.Location = new System.Drawing.Point(278, 519);
            this.txtnamaCRpeserta.Multiline = true;
            this.txtnamaCRpeserta.Name = "txtnamaCRpeserta";
            this.txtnamaCRpeserta.Size = new System.Drawing.Size(260, 30);
            this.txtnamaCRpeserta.TabIndex = 33;
            this.txtnamaCRpeserta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamaCRpeserta_KeyPress);
            // 
            // txtidcrPeserta
            // 
            this.txtidcrPeserta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidcrPeserta.Location = new System.Drawing.Point(278, 463);
            this.txtidcrPeserta.Multiline = true;
            this.txtidcrPeserta.Name = "txtidcrPeserta";
            this.txtidcrPeserta.Size = new System.Drawing.Size(260, 30);
            this.txtidcrPeserta.TabIndex = 32;
            this.txtidcrPeserta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidcrPeserta_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "NO TELEPON";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "NAMA PESERTA";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 63);
            this.label2.TabIndex = 23;
            this.label2.Text = "Create Peserta";
            // 
            // FormPesertaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1117, 679);
            this.Controls.Add(this.dataGridViewCreatePeserta);
            this.Controls.Add(this.btnExitPeserta);
            this.Controls.Add(this.btnsavePeserta);
            this.Controls.Add(this.txtNoCrPeserta);
            this.Controls.Add(this.txtemailCrPeserta);
            this.Controls.Add(this.txtnamaCRpeserta);
            this.Controls.Add(this.txtidcrPeserta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormPesertaCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPesertaCreate";
            this.Load += new System.EventHandler(this.FormPesertaCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreatePeserta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCreatePeserta;
        private System.Windows.Forms.Button btnExitPeserta;
        public System.Windows.Forms.Button btnsavePeserta;
        private System.Windows.Forms.TextBox txtNoCrPeserta;
        private System.Windows.Forms.TextBox txtemailCrPeserta;
        private System.Windows.Forms.TextBox txtnamaCRpeserta;
        public System.Windows.Forms.TextBox txtidcrPeserta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}