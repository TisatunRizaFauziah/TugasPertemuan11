using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TugasPertemuan11.Controller;

namespace TugasPertemuan11.View
{
    public partial class FormDeletePL : Form
    {
        private Pelatihan dl;
        public FormDeletePL()
        {
            InitializeComponent();
            dl = new Pelatihan();
            tampilPelatihan();
        }
       
        private void FormDeletePL_Load(object sender, EventArgs e)
        {

        }
        public void tampilPelatihan()
        {

            dataGridViewDeletePL.DataSource = dl.tampilPelatihan();
            dataGridViewDeletePL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridViewCreatePL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidDeletePl.Text = dataGridViewDeletePL.CurrentRow.Cells[0].Value.ToString();
            txtnamaDeletePL.Text = dataGridViewDeletePL.CurrentRow.Cells[1].Value.ToString();
            txtDeskDeletePL.Text = dataGridViewDeletePL.CurrentRow.Cells[2].Value.ToString();

            try
            {
                dtMulaiDeletePL.Value = DateTime.Parse(dataGridViewDeletePL.CurrentRow.Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                dtMulaiDeletePL.Value = DateTime.Now;
            }

            try
            {
                dtSelesaiDeletePL.Value = DateTime.Parse(dataGridViewDeletePL.CurrentRow.Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                dtSelesaiDeletePL.Value = DateTime.Now;
            }
            txtInstDeletePL.Text = dataGridViewDeletePL.CurrentRow.Cells[5].Value.ToString();
            txtLokasiDeletePl.Text = dataGridViewDeletePL.CurrentRow.Cells[6].Value.ToString();
            txthargaDeletePL.Text = dataGridViewDeletePL.CurrentRow.Cells[7].Value.ToString();
        

    }
    bool verify()
        {
            if (string.IsNullOrEmpty(txtidDeletePl.Text) || string.IsNullOrEmpty(txtnamaDeletePL.Text) || string.IsNullOrEmpty(txtDeskDeletePL.Text) ||
                dtMulaiDeletePL.Value == null || dtSelesaiDeletePL.Value == null ||
                string.IsNullOrEmpty(txtInstDeletePL.Text) || string.IsNullOrEmpty(txtLokasiDeletePl.Text) || string.IsNullOrEmpty(txthargaDeletePL.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnsaveDeletePL_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {

                    dl.hapusPelatihan(txtidDeletePl.Text);
                    ShowDialog();
                    btnClearPL.PerformClick();
                  
                    MessageBox.Show("pelatihan Deleted Suksess", "Delete pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtidDeletePl.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-pelatihan tidak terhapus", "Delete pelatihan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

    

        private void dateTimePickerSelesaiPL_ValueChanged(object sender, EventArgs e)
        {
            dtSelesaiDeletePL.CustomFormat = "dd/mm/yyyy";
        }

        private void btnClearPL_Click(object sender, EventArgs e)
        {
            txtidDeletePl.Clear();
            txtnamaDeletePL.Clear();
            txtDeskDeletePL.Clear();
            dtMulaiDeletePL.Value = DateTime.Now;
            dtSelesaiDeletePL.Value = DateTime.Now;
            txtInstDeletePL.Clear();
            txtLokasiDeletePl.Clear() ;
            txthargaDeletePL.Clear() ;
           
        }

        private void dtMulaiDeletePL_ValueChanged(object sender, EventArgs e)
        {
            dtMulaiDeletePL.CustomFormat = "dd/mm/yyyy";
        }
    }
}

