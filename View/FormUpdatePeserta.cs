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
    public partial class FormUpdatePeserta : Form
    {
        private Peserta ps;
        public FormUpdatePeserta()
        {
            ps = new Peserta();
            InitializeComponent();
            tampilPeserta();
        }
        public void tampilPeserta()
        {
            dataGridViewUpdatePs.DataSource = ps.tampilPeserta();
            dataGridViewUpdatePs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FormUpdatePeserta_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridViewUpdatePL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUPNgisiPL_Click(object sender, EventArgs e)
        {
            FormUpdatePesertaNgisi peserta = new FormUpdatePesertaNgisi();
            peserta.Show();
            this.Hide();

            peserta.txtidPesertaUP.Text = this.dataGridViewUpdatePs.CurrentRow.Cells[0].Value.ToString();
            peserta.txtnamaPesertaUP.Text = this.dataGridViewUpdatePs.CurrentRow.Cells[1].Value.ToString();
            peserta.txtemailPesertaUP.Text = this.dataGridViewUpdatePs.CurrentRow.Cells[2].Value.ToString();
            peserta.txtNoPesertaUP.Text = this.dataGridViewUpdatePs.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar");
            FormPeserta cl = new FormPeserta();
            cl.Show();
            this.Hide();
        }
    }
}
