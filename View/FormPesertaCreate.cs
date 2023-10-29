using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.Controller;

namespace TugasPertemuan11.View
{
    public partial class FormPesertaCreate : Form
    {
        private Peserta ps;
        public FormPesertaCreate()
        {
            ps = new Peserta();
            InitializeComponent();
            tampilPeserta();
        }
        public void tampilPeserta()
        {
            dataGridViewCreatePeserta.DataSource = ps.tampilPeserta();
            dataGridViewCreatePeserta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExitPeserta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar");
            Form1 cl = new Form1();
            cl.Show();
            this.Hide();
        }

        private void btnsavePeserta_Click_1(object sender, EventArgs e)
        {
            ps = new Peserta();
            ps.tambahPeserta(txtidcrPeserta.Text, txtnamaCRpeserta.Text, txtemailCrPeserta.Text, txtNoCrPeserta.Text);
           
            this.Controls.Clear();
            this.InitializeComponent();
            txtidcrPeserta.Focus();
            MessageBox.Show("data disimpan");
           FormPesertaCreate psrt = new FormPesertaCreate();

            psrt.Show();
            this.Hide();
        }

        private void txtidcrPeserta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtnamaCRpeserta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtemailCrPeserta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNoCrPeserta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void FormPesertaCreate_Load(object sender, EventArgs e)
        {
            txtidcrPeserta.MaxLength = 3;
            txtnamaCRpeserta.MaxLength = 35;
            txtemailCrPeserta.MaxLength = 35;
            txtNoCrPeserta.MaxLength = 13;
        }
    }
}
