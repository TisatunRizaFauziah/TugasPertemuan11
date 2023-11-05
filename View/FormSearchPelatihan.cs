using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.Controller;

namespace TugasPertemuan11.View
{
    public partial class FormSearchPelatihan : Form
    {
        private Pelatihan pl;
        public FormSearchPelatihan()
        {
            pl = new Pelatihan();
            InitializeComponent();
            tampilPelatihan();
        }
        public void tampilPelatihan()
        {
            dataGridViewSearchPelatihan.DataSource = pl.tampilPelatihan();
          dataGridViewSearchPelatihan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearchPL_Click(object sender, EventArgs e)
        {
            dataGridViewSearchPelatihan.DataSource = pl.searchPelatihan(txtSearchPL.Text);
            dataGridViewSearchPelatihan.RowTemplate.Height = 80;
        }


        private void btnExitPelatihan_Click(object sender, EventArgs e)
        {
            FormPelatihan pl = new FormPelatihan();
            pl.Show();
            this.Hide();
        }

        private void printDocumentPL_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap btm = new Bitmap(this.dataGridViewSearchPelatihan.Width, this.dataGridViewSearchPelatihan.Height);
            dataGridViewSearchPelatihan.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewSearchPelatihan.Width, this.dataGridViewSearchPelatihan.Height));
            e.Graphics.DrawImage(btm, 270, 320);
            e.Graphics.DrawString(label1.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 50));
        }

        private void btnPrintPelatihan_Click(object sender, EventArgs e)
        {
            printPreviewDialog1PL.Document = printDocumentPL;
            printPreviewDialog1PL.ShowDialog();
        }
    }
}
