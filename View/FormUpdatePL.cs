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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasPertemuan11.View
{
    public partial class FormUpdatePL : Form
    {
        private Pelatihan pl;
        public FormUpdatePL()
        {
            InitializeComponent();
            pl = new Pelatihan();
            tampilPelatihan();
            
        }
        public void tampilPelatihan()
        {
            dataGridViewUpdatePL.DataSource = pl.tampilPelatihan();
            dataGridViewUpdatePL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

     


        private void btnUPNgisiPL_Click(object sender, EventArgs e)
        {
            FormNgisiUpdatePl ngisi = new FormNgisiUpdatePl();
            ngisi.Show();
            this.Hide();

            try
            {
                ngisi.txt_id_updatePL.Text = this.dataGridViewUpdatePL.CurrentRow.Cells[0].Value.ToString();
                ngisi.txt_namapl_updtPL.Text = this.dataGridViewUpdatePL.CurrentRow.Cells[1].Value.ToString();
                ngisi.txtDes_UpdtPL.Text = this.dataGridViewUpdatePL.CurrentRow.Cells[2].Value.ToString();

             
                try
                {
                    ngisi.dateTimeMulaiUPPL.Value = DateTime.Parse(this.dataGridViewUpdatePL.CurrentRow.Cells[3].Value.ToString());
                }
                catch (FormatException ex)
                {
                    
                    MessageBox.Show("Error parsing dateTimeMulaiUPPL: " + ex.Message);
                }

              
                try
                {
                    ngisi.dateTimeSelesaiUPPL.Value = DateTime.Parse(this.dataGridViewUpdatePL.CurrentRow.Cells[4].Value.ToString());
                }
                catch (FormatException ex)
                {
                    
                    MessageBox.Show("Error parsing dateTimeSelesaiUPPL: " + ex.Message);
                }

                ngisi.txtinstruktur_updtPl.Text = this.dataGridViewUpdatePL.CurrentRow.Cells[5].Value.ToString();
                ngisi.txt_lokasi_UpdtPL.Text = this.dataGridViewUpdatePL.CurrentRow.Cells[6].Value.ToString();
                ngisi.txt_harga_UpdtPl.Text = this.dataGridViewUpdatePL.CurrentRow.Cells[7].Value.ToString();
            }
            catch (FormatException ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void dataGridViewUpdatePL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar");
            FormPelatihan cl = new FormPelatihan();
            cl.Show();
            this.Hide();
        }
    }
}
