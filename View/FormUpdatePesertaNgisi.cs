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
        Validasi val = new Validasi();
        public FormUpdatePesertaNgisi()
        {
            ps = new Peserta();
            InitializeComponent();
        }

        private void btnsavePLUp_Click(object sender, EventArgs e)
        {
            ps = new Peserta();
           
            if (val.ValID(txtidPesertaUP.Text) && val.valName(txtnamaPesertaUP.Text) && val.ValEmail(txtemailPesertaUP.Text) && val.ValNo(txtNoPesertaUP.Text, 8, 15))
            {
                try
                {
                    ps.updatePeserta(txtidPesertaUP.Text, txtnamaPesertaUP.Text, txtemailPesertaUP.Text, txtNoPesertaUP.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtidPesertaUP.Focus();
                    MessageBox.Show("data di update");
                    FormUpdatePeserta lk = new FormUpdatePeserta();
                    lk.Show();
                    this.Hide();

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty field ", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExitPLUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar");
            FormUpdatePeserta cl = new FormUpdatePeserta();
            cl.Show();
            this.Hide();
        }

        private void FormUpdatePesertaNgisi_Load(object sender, EventArgs e)
        {

        }
    }
}
