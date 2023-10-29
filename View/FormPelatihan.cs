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
using TugasPertemuan11.View;

namespace TugasPertemuan11
{
    public partial class FormPelatihan : Form
    {
        private Pelatihan pl;
        private Pelatihan plth;
        public FormPelatihan()
        {
            plth = new Pelatihan();
            pl = new Pelatihan();
            InitializeComponent();
        }
        
        private void FormPelatihan_Load(object sender, EventArgs e)
        {


        }

        private void btnCreatePL_Click(object sender, EventArgs e)
        {
          
            FormCreatePL pl = new FormCreatePL();
            pl.Show();
            this.Hide();
        }

        private void btnUpdatePL_Click(object sender, EventArgs e)
        {
            FormUpdatePL plth = new FormUpdatePL();
            plth.Show(); 
            this.Hide();
            
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar");
            Form1 cl = new Form1();
            cl.Show();
            this.Hide();
        }

        private void btndeletePL_Click(object sender, EventArgs e)
        {
          
            FormDeletePL dl = new FormDeletePL();
            dl.Show();
            this.Hide();
        }
    }
}
