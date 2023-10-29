namespace TugasPertemuan11
{
    partial class FormPelatihan
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
            this.btnCreatePL = new System.Windows.Forms.Button();
            this.btndeletePL = new System.Windows.Forms.Button();
            this.btnUpdatePL = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(791, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "PELATIHAN";
            // 
            // btnCreatePL
            // 
            this.btnCreatePL.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCreatePL.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePL.Location = new System.Drawing.Point(788, 263);
            this.btnCreatePL.Name = "btnCreatePL";
            this.btnCreatePL.Size = new System.Drawing.Size(313, 63);
            this.btnCreatePL.TabIndex = 2;
            this.btnCreatePL.Text = "Create";
            this.btnCreatePL.UseVisualStyleBackColor = false;
            this.btnCreatePL.Click += new System.EventHandler(this.btnCreatePL_Click);
            // 
            // btndeletePL
            // 
            this.btndeletePL.BackColor = System.Drawing.Color.SkyBlue;
            this.btndeletePL.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletePL.Location = new System.Drawing.Point(788, 503);
            this.btndeletePL.Name = "btndeletePL";
            this.btndeletePL.Size = new System.Drawing.Size(313, 63);
            this.btndeletePL.TabIndex = 5;
            this.btndeletePL.Text = "Delete";
            this.btndeletePL.UseVisualStyleBackColor = false;
            this.btndeletePL.Click += new System.EventHandler(this.btndeletePL_Click);
            // 
            // btnUpdatePL
            // 
            this.btnUpdatePL.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdatePL.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePL.Location = new System.Drawing.Point(788, 384);
            this.btnUpdatePL.Name = "btnUpdatePL";
            this.btnUpdatePL.Size = new System.Drawing.Size(313, 63);
            this.btnUpdatePL.TabIndex = 4;
            this.btnUpdatePL.Text = "Update";
            this.btnUpdatePL.UseVisualStyleBackColor = false;
            this.btnUpdatePL.Click += new System.EventHandler(this.btnUpdatePL_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(908, 625);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 50);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BackgroundImage = global::TugasPertemuan11.Properties.Resources._06knightlyIMAGE_696x822;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 769);
            this.panel1.TabIndex = 0;
            // 
            // FormPelatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1258, 764);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btndeletePL);
            this.Controls.Add(this.btnUpdatePL);
            this.Controls.Add(this.btnCreatePL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPelatihan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelatihan";
            this.Load += new System.EventHandler(this.FormPelatihan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatePL;
        private System.Windows.Forms.Button btndeletePL;
        private System.Windows.Forms.Button btnUpdatePL;
        private System.Windows.Forms.Button btnExit;
    }
}