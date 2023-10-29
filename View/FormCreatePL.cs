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
    public partial class FormCreatePL : Form
    {
        private Pelatihan pl;
        private Pelatihan tambah;

        public FormCreatePL()
        {
            pl = new Pelatihan();
            InitializeComponent();
            tampilPelatihan();
        }


        private void btnsavePL_Click(object sender, EventArgs e)
        {
            Pelatihan pl = new Pelatihan();
          
            pl.tambahPelatihan(txtidcrPl.Text, txtnamaCRPL.Text, txtDeskCrPL.Text,dateTimemulaiPl.Value, dateTimePickerSelesaiPL.Value, txtInstCrPL.Text, txtLokasiCrPl.Text, txthargaCrPL.Text);

            this.Controls.Clear();
            this.InitializeComponent();
            txtidcrPl.Focus();
            MessageBox.Show("Data disimpan");
            FormCreatePL tambah = new FormCreatePL();
            tambah.Show();
            this.Hide();

        }


        private void FormCreatePL_Load(object sender, EventArgs e)
        {
            txtidcrPl.MaxLength = 3;
            txtnamaCRPL.MaxLength = 35;
            txtDeskCrPL.MaxLength = 255;
            txtInstCrPL.MaxLength = 35;
            txtLokasiCrPl.MaxLength = 35;
            txthargaCrPL.MaxLength = 25;
        }
        public void tampilPelatihan()
        {
            dataGridViewCreatePL.DataSource = pl.tampilPelatihan();
            dataGridViewCreatePL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExitPL_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Keluar");
                FormPelatihan cl = new FormPelatihan();
                cl.Show();
                this.Hide();
            
        }

        private void dataGridViewCreatePL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimemulaiPl.CustomFormat = "dd/mm/yyyy";
        }

        private void txtidcrPl_TextChanged(object sender, EventArgs e)
        {
            dateTimePickerSelesaiPL.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePickerSelesaiPL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtnamaCRPL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeskCrPL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidcrPl_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtnamaCRPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDeskCrPL_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
