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
    public partial class FormDeletePeserta : Form
    {
        private Peserta ps;
        public FormDeletePeserta()
        {
            ps = new Peserta();
            InitializeComponent();
            tampilPeserta();
        }
        public void tampilPeserta()
        {

            dataGridViewDeletePS.DataSource = ps.tampilPeserta();
            dataGridViewDeletePS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewDeletePL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidDeletePS.Text = dataGridViewDeletePS.CurrentRow.Cells[0].Value.ToString();
            txtnamaDeletePS.Text = dataGridViewDeletePS.CurrentRow.Cells[1].Value.ToString();
            txtDeleteEmailPS.Text = dataGridViewDeletePS.CurrentRow.Cells[2].Value.ToString();
            txtNotDeletePs.Text = dataGridViewDeletePS.CurrentRow.Cells[3].Value.ToString();

            
            
        }

        private void txtidDeletePS_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDeletePeserta_Load(object sender, EventArgs e)
        {

        }
        bool verify()
        {
            
            if (string.IsNullOrEmpty(txtidDeletePS.Text) || string.IsNullOrEmpty(txtnamaDeletePS.Text ) || string.IsNullOrEmpty(txtDeleteEmailPS.Text )|| string.IsNullOrEmpty(txtNotDeletePs.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnDeletePL_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {

                    ps.deleteTraining(txtidDeletePS.Text);
                    tampilPeserta();
                    btnClearPL.PerformClick();

                    MessageBox.Show("Training Deleted Succesfully", "Delete Training", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtidDeletePS.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Training not delete", "Delete Training",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnClearPL_Click(object sender, EventArgs e)
        {
            txtidDeletePS.Clear();
            txtnamaDeletePS.Clear();
            txtDeleteEmailPS.Clear();
            txtNotDeletePs.Clear();
    
        }

        private void btnexitDeletePS_Click(object sender, EventArgs e)
        {
            FormPeserta ps = new FormPeserta();
            ps.Show();
            this.Hide();
        }
    }
    
}
