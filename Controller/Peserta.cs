using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11.Model;

namespace TugasPertemuan11.Controller
{
    internal class Peserta :Model.Connection
    {
        Connection connec = new Connection();
        public DataTable tampilPeserta()
        {
            DataTable data = new DataTable();

            try
            {
                string tampil = "select * from peserta";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void tambahPeserta(string idPeserta, string namaPeserta, string email,string noTelepon)
        {
            string tambah = "insert into peserta values(" + "@id,@nama_peserta,@email,@no_telepon)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idPeserta;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namaPeserta;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.Date).Value = noTelepon;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambah data gagal" + ex.Message);
            }

        }
        public void updatePeserta(string id, string namaPeserta,string emailPs,string noPs )
        {
            string update = "update peserta set " + "id=@id,nama_peserta=@nama_peserta,email=@email,no_telepon=@no_telepon " + "where id = " + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namaPeserta;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = emailPs;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noPs;
     
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data gagal" + ex.Message);
            }

        }
        public void deleteTraining(string id)
        {
            string delete = "delete from Peserta where id=" + id;

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
        public DataTable searchTeacher(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Peserta WHERE CONCAT (id,nama_peserta,email,no_telepon)LIKE '%" + search + "%'", connec.GetConn());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Gagal delete" + ex.Message);
            }
            return table;
        }

    }
}
