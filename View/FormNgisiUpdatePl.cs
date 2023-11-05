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
    public partial class FormNgisiUpdatePl : Form
    {
        private Pelatihan pl;
        Validasi val = new Validasi();
        public FormNgisiUpdatePl()
        {
            InitializeComponent();
        }

        private void FormNgisiUpdatePl_Load(object sender, EventArgs e)
        {
           
        }

        private void dateTimeMulaiUPPL_ValueChanged(object sender, EventArgs e)
        {
            dateTimeMulaiUPPL.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimeSelesaiUPPL_ValueChanged(object sender, EventArgs e)
        {
            dateTimeSelesaiUPPL.CustomFormat = "dd/mm/yyyy";
        }

        private void btnsavePLUp_Click(object sender, EventArgs e)
        {
            Pelatihan pl = new Pelatihan();

           
            if (val.ValID(txt_id_updatePL.Text) && val.valName(txt_namapl_updtPL.Text) && val.ValLok(txt_lokasi_UpdtPL.Text) && val.valInstruktur(txtinstruktur_updtPl.Text) && val.ValDes(txtDes_UpdtPL.Text)
                && val.Valharga(txt_harga_UpdtPl.Text))
            {
                try
                {
                    pl.updatePelatihan(txt_id_updatePL.Text, txt_namapl_updtPL.Text, txtDes_UpdtPL.Text, dateTimeSelesaiUPPL.Value, dateTimeMulaiUPPL.Value,
                    txtinstruktur_updtPl.Text, txt_lokasi_UpdtPL.Text, txt_harga_UpdtPl.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txt_id_updatePL.Focus();
                    MessageBox.Show("data di update");
                    FormUpdatePL lk = new FormUpdatePL();
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

        private void txt_id_updatePL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitPLUp_Click(object sender, EventArgs e)
        {
           
            FormUpdatePL cl = new FormUpdatePL();
            cl.Show();
            this.Hide();
        }
    }
}
