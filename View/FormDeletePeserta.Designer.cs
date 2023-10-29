namespace TugasPertemuan11.View
{
    partial class FormDeletePeserta
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
            this.txtNotDeletePs = new System.Windows.Forms.TextBox();
            this.txtnamaDeletePS = new System.Windows.Forms.TextBox();
            this.txtidDeletePS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDeletePS = new System.Windows.Forms.DataGridView();
            this.btnClearPL = new System.Windows.Forms.Button();
            this.btnDeletePL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeleteEmailPS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletePS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotDeletePs
            // 
            this.txtNotDeletePs.Location = new System.Drawing.Point(798, 474);
            this.txtNotDeletePs.Multiline = true;
            this.txtNotDeletePs.Name = "txtNotDeletePs";
            this.txtNotDeletePs.Size = new System.Drawing.Size(260, 30);
            this.txtNotDeletePs.TabIndex = 74;
            // 
            // txtnamaDeletePS
            // 
            this.txtnamaDeletePS.Location = new System.Drawing.Point(257, 474);
            this.txtnamaDeletePS.Multiline = true;
            this.txtnamaDeletePS.Name = "txtnamaDeletePS";
            this.txtnamaDeletePS.Size = new System.Drawing.Size(260, 30);
            this.txtnamaDeletePS.TabIndex = 72;
            // 
            // txtidDeletePS
            // 
            this.txtidDeletePS.Location = new System.Drawing.Point(257, 418);
            this.txtidDeletePS.Multiline = true;
            this.txtidDeletePS.Name = "txtidDeletePS";
            this.txtidDeletePS.Size = new System.Drawing.Size(260, 30);
            this.txtidDeletePS.TabIndex = 71;
            this.txtidDeletePS.TextChanged += new System.EventHandler(this.txtidDeletePS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 68;
            this.label8.Text = "NO TELEPON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 67;
            this.label9.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "NAMA PESERTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID";
            // 
            // dataGridViewDeletePS
            // 
            this.dataGridViewDeletePS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDeletePS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeletePS.Location = new System.Drawing.Point(41, 89);
            this.dataGridViewDeletePS.Name = "dataGridViewDeletePS";
            this.dataGridViewDeletePS.RowHeadersWidth = 62;
            this.dataGridViewDeletePS.RowTemplate.Height = 28;
            this.dataGridViewDeletePS.Size = new System.Drawing.Size(1017, 276);
            this.dataGridViewDeletePS.TabIndex = 62;
            this.dataGridViewDeletePS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeletePL_CellContentClick);
            // 
            // btnClearPL
            // 
            this.btnClearPL.BackColor = System.Drawing.Color.Red;
            this.btnClearPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPL.Location = new System.Drawing.Point(966, 596);
            this.btnClearPL.Name = "btnClearPL";
            this.btnClearPL.Size = new System.Drawing.Size(92, 50);
            this.btnClearPL.TabIndex = 61;
            this.btnClearPL.Text = "Clear";
            this.btnClearPL.UseVisualStyleBackColor = false;
            this.btnClearPL.Click += new System.EventHandler(this.btnClearPL_Click);
            // 
            // btnDeletePL
            // 
            this.btnDeletePL.BackColor = System.Drawing.Color.Red;
            this.btnDeletePL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePL.Location = new System.Drawing.Point(798, 596);
            this.btnDeletePL.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletePL.Name = "btnDeletePL";
            this.btnDeletePL.Size = new System.Drawing.Size(92, 50);
            this.btnDeletePL.TabIndex = 60;
            this.btnDeletePL.Text = "Delete";
            this.btnDeletePL.UseVisualStyleBackColor = false;
            this.btnDeletePL.Click += new System.EventHandler(this.btnDeletePL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 63);
            this.label2.TabIndex = 59;
            this.label2.Text = "Delete Peserta";
            // 
            // txtDeleteEmailPS
            // 
            this.txtDeleteEmailPS.Location = new System.Drawing.Point(797, 417);
            this.txtDeleteEmailPS.Multiline = true;
            this.txtDeleteEmailPS.Name = "txtDeleteEmailPS";
            this.txtDeleteEmailPS.Size = new System.Drawing.Size(260, 30);
            this.txtDeleteEmailPS.TabIndex = 75;
            // 
            // FormDeletePeserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1117, 679);
            this.Controls.Add(this.txtDeleteEmailPS);
            this.Controls.Add(this.txtNotDeletePs);
            this.Controls.Add(this.txtnamaDeletePS);
            this.Controls.Add(this.txtidDeletePS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDeletePS);
            this.Controls.Add(this.btnClearPL);
            this.Controls.Add(this.btnDeletePL);
            this.Controls.Add(this.label2);
            this.Name = "FormDeletePeserta";
            this.Text = "FormDeletePeserta";
            this.Load += new System.EventHandler(this.FormDeletePeserta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletePS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtidDeletePS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearPL;
        public System.Windows.Forms.Button btnDeletePL;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnamaDeletePS;
        public System.Windows.Forms.TextBox txtNotDeletePs;
        public System.Windows.Forms.TextBox txtDeleteEmailPS;
        public System.Windows.Forms.DataGridView dataGridViewDeletePS;
    }
}