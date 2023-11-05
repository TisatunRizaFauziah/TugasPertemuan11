using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.Controller;

namespace TugasPertemuan11.View
{
    public partial class FormSearchPeserta : Form
    {
        private Peserta ps;
        public FormSearchPeserta()
        {
            ps= new Peserta();
            InitializeComponent();
            tampilPelatihan();
        }
        public void tampilPelatihan()
        {
            dataGridViewSearchPeserta.DataSource = ps.tampilPeserta();
            dataGridViewSearchPeserta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FormSearchPeserta_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitPeserta_Click(object sender, EventArgs e)
        {
            FormPeserta ps= new FormPeserta();
            ps.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewSearchPeserta.DataSource = ps.searchTeacher(textBox1.Text);
            dataGridViewSearchPeserta.RowTemplate.Height = 80;
        }

        private void btnPrintPeserta_Click(object sender, EventArgs e)
        {
            printPreviewDialogPS.Document = printDocumentPS;
            printPreviewDialogPS.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap btm = new Bitmap(this.dataGridViewSearchPeserta.Width, this.dataGridViewSearchPeserta.Height);
            dataGridViewSearchPeserta.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewSearchPeserta.Width, this.dataGridViewSearchPeserta.Height));
            e.Graphics.DrawImage(btm, 270, 320);
            e.Graphics.DrawString(label1.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 50));
        }

        private void printPreviewDialogPS_Load(object sender, EventArgs e)
        {

        }
    }
}
