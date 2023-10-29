namespace TugasPertemuan11.View
{
    partial class FormUpdatePL
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUpdatePL = new System.Windows.Forms.DataGridView();
            this.btnUPNgisiPL = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdatePL)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 63);
            this.label2.TabIndex = 22;
            this.label2.Text = "Update";
            // 
            // dataGridViewUpdatePL
            // 
            this.dataGridViewUpdatePL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUpdatePL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdatePL.Location = new System.Drawing.Point(45, 103);
            this.dataGridViewUpdatePL.Name = "dataGridViewUpdatePL";
            this.dataGridViewUpdatePL.RowHeadersWidth = 62;
            this.dataGridViewUpdatePL.RowTemplate.Height = 28;
            this.dataGridViewUpdatePL.Size = new System.Drawing.Size(1017, 392);
            this.dataGridViewUpdatePL.TabIndex = 42;
            this.dataGridViewUpdatePL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdatePL_CellContentClick);
            // 
            // btnUPNgisiPL
            // 
            this.btnUPNgisiPL.BackColor = System.Drawing.Color.Red;
            this.btnUPNgisiPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPNgisiPL.ForeColor = System.Drawing.Color.Black;
            this.btnUPNgisiPL.Location = new System.Drawing.Point(877, 534);
            this.btnUPNgisiPL.Name = "btnUPNgisiPL";
            this.btnUPNgisiPL.Size = new System.Drawing.Size(185, 71);
            this.btnUPNgisiPL.TabIndex = 43;
            this.btnUPNgisiPL.Text = "Update";
            this.btnUPNgisiPL.UseVisualStyleBackColor = false;
            this.btnUPNgisiPL.Click += new System.EventHandler(this.btnUPNgisiPL_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(121, 534);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(185, 71);
            this.btnexit.TabIndex = 44;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FormUpdatePL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1119, 689);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnUPNgisiPL);
            this.Controls.Add(this.dataGridViewUpdatePL);
            this.Controls.Add(this.label2);
            this.Name = "FormUpdatePL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdatePL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUpdatePL;
        private System.Windows.Forms.Button btnUPNgisiPL;
        private System.Windows.Forms.Button btnexit;
    }
}