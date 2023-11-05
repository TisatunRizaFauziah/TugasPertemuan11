using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan11.View
{
    public partial class FormPeserta : Form
    {
        public FormPeserta()
        {
            InitializeComponent();
        }

        private void btnCreatePL_Click(object sender, EventArgs e)
        {
            FormPesertaCreate tambah = new FormPesertaCreate();
            tambah.Show();
            this.Hide();
        }

        private void btnExitPeserta_Click(object sender, EventArgs e)
        {
      
            Form1 cl = new Form1();
            cl.Show();
            this.Hide();
        }

        private void btnUpdatePL_Click(object sender, EventArgs e)
        {
            FormUpdatePeserta ps = new FormUpdatePeserta();
            ps.Show();
            this.Hide();    
        }

        private void btndeletePL_Click(object sender, EventArgs e)
        {
            FormDeletePeserta ps = new FormDeletePeserta();
            ps.Show();
            this.Hide();

            
        }

        private void FormPeserta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSearchPeserta sr = new FormSearchPeserta();
            sr.Show();
            this.Hide();
        }
    }
}
