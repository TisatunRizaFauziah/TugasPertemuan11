using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.Model;

namespace TugasPertemuan11.Controller
{
    internal class Pelatihan : Model.Connection
    {
        Connection connec = new Connection();
        public DataTable tampilPelatihan()
        {
            DataTable data = new DataTable();

            try
            {
                string tampil = "select * from pelatihan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void tambahPelatihan(string idpl, string namapelatihan, string deskripsi, DateTime mulai, DateTime selesai, string inst,string lks, string hrg)
        {
            string tambah = "insert into pelatihan values(" + "@id,@nama_pelatihan,@deskripsi,@tanggal_mulai,@tanggal_selesai,@instruktur,@lokasi,@harga)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpl;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = namapelatihan;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = deskripsi;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.VarChar).Value = mulai;
                cmd.Parameters.Add("@tanggal_selesai", MySqlConnector.MySqlDbType.VarChar).Value = selesai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = inst;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lks;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = hrg;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambah data gagal" + ex.Message);
            }

        }
        public void updatePelatihan(string idpl, string namapelatihan, string deskripsi, DateTime mulai, DateTime selesai, string inst, string lks, string hrg)
        {
            string update = "update pelatihan set " + "id=@id,nama_pelatihan=@nama_pelatihan,deskripsi=@deskripsi,tanggal_mulai=@tanggal_mulai," +
                "tanggal_selesai=@tanggal_selesai,instruktur=@instruktur,lokasi=@lokasi,harga=@harga " + "where id = " + idpl;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpl;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = namapelatihan;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = deskripsi;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.VarChar).Value = mulai;
                cmd.Parameters.Add("@tanggal_selesai", MySqlConnector.MySqlDbType.VarChar).Value = selesai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = inst;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lks;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = hrg;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data gagal" + ex.Message);
            }

        }
        public void hapusPelatihan(string id)
        {
            string delete = "delete from Pelatihan where id=" + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete" + ex.Message);
            }

        }

       
           
        public DataTable searchPelatihan(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Pelatihan WHERE CONCAT (id, nama_pelatihan, deskripsi, tanggal_mulai, tanggal_selesai, instruktur, lokasi, harga)LIKE '%" + search + "%'", connec.GetConn());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete" + ex.Message);
            }
            return table;
        }


    }
}
