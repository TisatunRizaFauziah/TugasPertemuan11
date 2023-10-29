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
    public partial class FormUpdatePesertaNgisi : Form
    {
        private Peserta ps;
        public FormUpdatePesertaNgisi()
        {
            ps = new Peserta();
            InitializeComponent();
        }

        private void btnsavePLUp_Click(object sender, EventArgs e)
        {
            ps = new Peserta();
            ps.updatePeserta(txtidPesertaUP.Text, txtnamaPesertaUP.Text, txtemailPesertaUP.Text, txtNoPesertaUP.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtidPesertaUP.Focus();
            MessageBox.Show("data di update");
            FormUpdatePeserta lk = new FormUpdatePeserta();
            lk.Show();
            this.Hide();
        }

        private void btnExitPLUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar");
            FormUpdatePeserta cl = new FormUpdatePeserta();
            cl.Show();
            this.Hide();
        }
    }
}
