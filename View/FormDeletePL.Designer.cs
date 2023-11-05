namespace TugasPertemuan11.View
{
    partial class FormDeletePL
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
            this.dataGridViewDeletePL = new System.Windows.Forms.DataGridView();
            this.btnClearPL = new System.Windows.Forms.Button();
            this.btnDeletePL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSelesaiDeletePL = new System.Windows.Forms.DateTimePicker();
            this.dtMulaiDeletePL = new System.Windows.Forms.DateTimePicker();
            this.txthargaDeletePL = new System.Windows.Forms.TextBox();
            this.txtLokasiDeletePl = new System.Windows.Forms.TextBox();
            this.txtInstDeletePL = new System.Windows.Forms.TextBox();
            this.txtDeskDeletePL = new System.Windows.Forms.TextBox();
            this.txtnamaDeletePL = new System.Windows.Forms.TextBox();
            this.txtidDeletePl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitDeletePL = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletePL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeletePL
            // 
            this.dataGridViewDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDeletePL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDeletePL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeletePL.Location = new System.Drawing.Point(47, 84);
            this.dataGridViewDeletePL.Name = "dataGridViewDeletePL";
            this.dataGridViewDeletePL.RowHeadersWidth = 62;
            this.dataGridViewDeletePL.RowTemplate.Height = 28;
            this.dataGridViewDeletePL.Size = new System.Drawing.Size(1017, 276);
            this.dataGridViewDeletePL.TabIndex = 42;
            this.dataGridViewDeletePL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCreatePL_CellContentClick);
            // 
            // btnClearPL
            // 
            this.btnClearPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPL.BackColor = System.Drawing.Color.Red;
            this.btnClearPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPL.Location = new System.Drawing.Point(972, 591);
            this.btnClearPL.Name = "btnClearPL";
            this.btnClearPL.Size = new System.Drawing.Size(92, 50);
            this.btnClearPL.TabIndex = 41;
            this.btnClearPL.Text = "Clear";
            this.btnClearPL.UseVisualStyleBackColor = false;
            this.btnClearPL.Click += new System.EventHandler(this.btnClearPL_Click);
            // 
            // btnDeletePL
            // 
            this.btnDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePL.BackColor = System.Drawing.Color.Red;
            this.btnDeletePL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePL.Location = new System.Drawing.Point(836, 591);
            this.btnDeletePL.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletePL.Name = "btnDeletePL";
            this.btnDeletePL.Size = new System.Drawing.Size(100, 50);
            this.btnDeletePL.TabIndex = 40;
            this.btnDeletePL.Text = "Delete";
            this.btnDeletePL.UseVisualStyleBackColor = false;
            this.btnDeletePL.Click += new System.EventHandler(this.btnsaveDeletePL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 63);
            this.label2.TabIndex = 23;
            this.label2.Text = "Delete Pelatihan";
            // 
            // dtSelesaiDeletePL
            // 
            this.dtSelesaiDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSelesaiDeletePL.CustomFormat = " ";
            this.dtSelesaiDeletePL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSelesaiDeletePL.Location = new System.Drawing.Point(804, 378);
            this.dtSelesaiDeletePL.Name = "dtSelesaiDeletePL";
            this.dtSelesaiDeletePL.Size = new System.Drawing.Size(260, 26);
            this.dtSelesaiDeletePL.TabIndex = 58;
            this.dtSelesaiDeletePL.ValueChanged += new System.EventHandler(this.dateTimePickerSelesaiPL_ValueChanged);
            // 
            // dtMulaiDeletePL
            // 
            this.dtMulaiDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMulaiDeletePL.CustomFormat = " ";
            this.dtMulaiDeletePL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMulaiDeletePL.Location = new System.Drawing.Point(264, 549);
            this.dtMulaiDeletePL.Name = "dtMulaiDeletePL";
            this.dtMulaiDeletePL.Size = new System.Drawing.Size(260, 26);
            this.dtMulaiDeletePL.TabIndex = 57;
            this.dtMulaiDeletePL.ValueChanged += new System.EventHandler(this.dtMulaiDeletePL_ValueChanged);
            // 
            // txthargaDeletePL
            // 
            this.txthargaDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txthargaDeletePL.Location = new System.Drawing.Point(805, 542);
            this.txthargaDeletePL.Multiline = true;
            this.txthargaDeletePL.Name = "txthargaDeletePL";
            this.txthargaDeletePL.Size = new System.Drawing.Size(260, 30);
            this.txthargaDeletePL.TabIndex = 56;
            // 
            // txtLokasiDeletePl
            // 
            this.txtLokasiDeletePl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLokasiDeletePl.Location = new System.Drawing.Point(805, 490);
            this.txtLokasiDeletePl.Multiline = true;
            this.txtLokasiDeletePl.Name = "txtLokasiDeletePl";
            this.txtLokasiDeletePl.Size = new System.Drawing.Size(260, 30);
            this.txtLokasiDeletePl.TabIndex = 55;
            // 
            // txtInstDeletePL
            // 
            this.txtInstDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstDeletePL.Location = new System.Drawing.Point(805, 436);
            this.txtInstDeletePL.Multiline = true;
            this.txtInstDeletePL.Name = "txtInstDeletePL";
            this.txtInstDeletePL.Size = new System.Drawing.Size(260, 30);
            this.txtInstDeletePL.TabIndex = 54;
            // 
            // txtDeskDeletePL
            // 
            this.txtDeskDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeskDeletePL.Location = new System.Drawing.Point(264, 490);
            this.txtDeskDeletePL.Multiline = true;
            this.txtDeskDeletePL.Name = "txtDeskDeletePL";
            this.txtDeskDeletePL.Size = new System.Drawing.Size(260, 30);
            this.txtDeskDeletePL.TabIndex = 53;
            // 
            // txtnamaDeletePL
            // 
            this.txtnamaDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnamaDeletePL.Location = new System.Drawing.Point(264, 436);
            this.txtnamaDeletePL.Multiline = true;
            this.txtnamaDeletePL.Name = "txtnamaDeletePL";
            this.txtnamaDeletePL.Size = new System.Drawing.Size(260, 30);
            this.txtnamaDeletePL.TabIndex = 52;
            // 
            // txtidDeletePl
            // 
            this.txtidDeletePl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidDeletePl.Location = new System.Drawing.Point(264, 380);
            this.txtidDeletePl.Multiline = true;
            this.txtidDeletePl.Name = "txtidDeletePl";
            this.txtidDeletePl.Size = new System.Drawing.Size(260, 30);
            this.txtidDeletePl.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 50;
            this.label6.Text = "HARGA";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "LOKASI";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "INSTRUKTUR";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "TANGGAL SELESAI";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "TANGGAL MULAI";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "DESKRIPSI";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "NAMA PELATIHAN";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // btnExitDeletePL
            // 
            this.btnExitDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExitDeletePL.BackColor = System.Drawing.Color.Red;
            this.btnExitDeletePL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDeletePL.Location = new System.Drawing.Point(47, 615);
            this.btnExitDeletePL.Margin = new System.Windows.Forms.Padding(5);
            this.btnExitDeletePL.Name = "btnExitDeletePL";
            this.btnExitDeletePL.Size = new System.Drawing.Size(92, 50);
            this.btnExitDeletePL.TabIndex = 59;
            this.btnExitDeletePL.Text = "Exit";
            this.btnExitDeletePL.UseVisualStyleBackColor = false;
            this.btnExitDeletePL.Click += new System.EventHandler(this.btnExitDeletePL_Click);
            // 
            // delete
            // 
            this.delete.Image = global::TugasPertemuan11.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            this.delete.Location = new System.Drawing.Point(795, 591);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(44, 50);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 60;
            this.delete.TabStop = false;
            // 
            // FormDeletePL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1117, 679);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.btnExitDeletePL);
            this.Controls.Add(this.dtSelesaiDeletePL);
            this.Controls.Add(this.dtMulaiDeletePL);
            this.Controls.Add(this.txthargaDeletePL);
            this.Controls.Add(this.txtLokasiDeletePl);
            this.Controls.Add(this.txtInstDeletePL);
            this.Controls.Add(this.txtDeskDeletePL);
            this.Controls.Add(this.txtnamaDeletePL);
            this.Controls.Add(this.txtidDeletePl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDeletePL);
            this.Controls.Add(this.btnClearPL);
            this.Controls.Add(this.btnDeletePL);
            this.Controls.Add(this.label2);
            this.Name = "FormDeletePL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeletePL";
            this.Load += new System.EventHandler(this.FormDeletePL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletePL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeletePL;
        private System.Windows.Forms.Button btnClearPL;
        public System.Windows.Forms.Button btnDeletePL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtMulaiDeletePL;
        private System.Windows.Forms.TextBox txthargaDeletePL;
        private System.Windows.Forms.TextBox txtLokasiDeletePl;
        private System.Windows.Forms.TextBox txtInstDeletePL;
        private System.Windows.Forms.TextBox txtDeskDeletePL;
        private System.Windows.Forms.TextBox txtnamaDeletePL;
        public System.Windows.Forms.TextBox txtidDeletePl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtSelesaiDeletePL;
        public System.Windows.Forms.Button btnExitDeletePL;
        private System.Windows.Forms.PictureBox delete;
    }
}