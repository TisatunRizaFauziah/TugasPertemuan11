using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.View;

namespace TugasPertemuan11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnpelatihan_Click(object sender, EventArgs e)
        {
            FormPelatihan frm2 = new FormPelatihan();
            frm2.Show();
            this.Hide();
        }

        private void btnpeserta_Click(object sender, EventArgs e)
        {
            FormPeserta peserta = new FormPeserta();
            peserta.Show();
            this.Hide();
        }
    }
}
