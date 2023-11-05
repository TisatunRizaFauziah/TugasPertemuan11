namespace TugasPertemuan11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnpelatihan = new System.Windows.Forms.Button();
            this.btnpeserta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(314, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "PELATIHAN PEMOGRAMAN";
            // 
            // btnpelatihan
            // 
            this.btnpelatihan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpelatihan.BackColor = System.Drawing.Color.SkyBlue;
            this.btnpelatihan.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpelatihan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpelatihan.Location = new System.Drawing.Point(483, 382);
            this.btnpelatihan.Name = "btnpelatihan";
            this.btnpelatihan.Size = new System.Drawing.Size(352, 113);
            this.btnpelatihan.TabIndex = 2;
            this.btnpelatihan.Text = "Pelatihan";
            this.btnpelatihan.UseVisualStyleBackColor = false;
            this.btnpelatihan.Click += new System.EventHandler(this.btnpelatihan_Click);
            // 
            // btnpeserta
            // 
            this.btnpeserta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpeserta.BackColor = System.Drawing.Color.SkyBlue;
            this.btnpeserta.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpeserta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpeserta.Location = new System.Drawing.Point(483, 209);
            this.btnpeserta.Name = "btnpeserta";
            this.btnpeserta.Size = new System.Drawing.Size(352, 113);
            this.btnpeserta.TabIndex = 3;
            this.btnpeserta.Text = "Peserta";
            this.btnpeserta.UseVisualStyleBackColor = false;
            this.btnpeserta.Click += new System.EventHandler(this.btnpeserta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::TugasPertemuan11.Properties.Resources.pngtree_cartoon_training_class_orange_background_material_picture_image_1010079;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 764);
            this.Controls.Add(this.btnpeserta);
            this.Controls.Add(this.btnpelatihan);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpelatihan;
        private System.Windows.Forms.Button btnpeserta;
    }
}

