using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan11.Controller
{
    internal class Validasi
    {
        public bool valName(string nama)
        {
            for(int a=0;a<nama.Length;a++)
            {
                if (nama[a] >='0' && nama[a] <='9' || nama[0] == ' ' || nama[nama.Length-1] == ' ' || nama[a] == ':'||
                    nama[a] == ','|| nama[0] == '_' || nama[nama.Length-1]== '_' || nama[a] =='/'|| nama[a] == '\\' || nama[a]=='?')
                {
                    MessageBox.Show("Nama tidak Valid ", "Tambah Pelatihan ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool ValLok(string lok)
        {
            for (int i = 0; i <lok.Length; i++)
            {
                char currentChar = lok[i];

                if (!char.IsLetterOrDigit(currentChar) && currentChar != ' ' && currentChar != '-' && currentChar != '\'' &&
                    currentChar != ',' && currentChar != ':' && currentChar != '_' && currentChar != '/' && currentChar != '?')
                {
                    MessageBox.Show("Lokasi tidak valid", "Validasi Lokasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Pastikan lokasi tidak dimulai atau diakhiri dengan spasi, tanda strip, garis bawah, atau tanda tanya.
            if (lok[0] == ' ' || lok[0] == '-' || lok[0] == '_' || lok[0] == '?' ||
                lok[lok.Length - 1] == ' ' || lok[lok.Length - 1] == '-' || lok[lok.Length - 1] == '_' || lok[lok.Length - 1] == '?')
            {
                MessageBox.Show("Lokasi tidak valid", "Validasi Lokasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public bool valInstruktur(string ins)
        {
            for (int a = 0; a < ins.Length; a++)
            {
                if (ins[a] >= '0' && ins[a] <= '9' || ins[0] == ' ' || ins[ins.Length - 1] == ' ' || ins[a] == ':' ||
                    ins[a] == '!' || ins[a] == ',' || ins[0] == '_' || ins[ins.Length - 1] == '_' || ins[a] == '/' || ins[a] == '\\' || ins[a] == '?')
                {
                    MessageBox.Show("instruktur tidak Valid ", "Tambah Pelatihan ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool ValDes(string deskripsi)
        {
            // Deskripsi dapat mengandung huruf, angka, spasi, tanda baca, dan karakter lain yang biasa digunakan dalam deskripsi.
            // Anda dapat menyesuaikan aturan ini sesuai kebutuhan Anda.
            if (!string.IsNullOrWhiteSpace(deskripsi))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Deskripsi tidak Valid ", "Tambah Pelatihan ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        public bool ValID(string id)
        {
            // ID hanya boleh mengandung angka.
            // Jika mengandung karakter selain angka, maka dianggap tidak valid.
            if (!string.IsNullOrWhiteSpace(id) && Regex.IsMatch(id, "^[0-9]+$"))
            {
               
                return true;
            }
            else
            {
                MessageBox.Show("ID tidak Valid ", "Tambah Pelatihan ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool ValEmail(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                char currentChar = email[i];

                if (!char.IsLetterOrDigit(currentChar) && currentChar != '@' && currentChar != '.' && currentChar != '_' && currentChar != '-')
                {
                    MessageBox.Show("Email tidak valid", "Validasi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Pastikan ada tepat satu karakter '@' dalam email
            int atSymbolCount = email.Count(c => c == '@');
            if (atSymbolCount != 1)
            {
                MessageBox.Show("Email tidak valid", "Validasi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public bool Valharga(string hrg)
        {
            // Harga dapat terdiri dari angka, tanda koma, dan tanda titik sebagai pemisah desimal.
            if (!string.IsNullOrWhiteSpace(hrg) && Regex.IsMatch(hrg, @"^[0-9]+(\.|,)?[0-9]*$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Harga tidak valid", "Validasi Harga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        int minLength = 8;  
        int maxLength = 15; 
        public bool ValNo(string nomor,int minLenght,int maxlenght)
        {
            // Nomor telepon hanya boleh mengandung angka, tanda tambah (+), dan tanda strip (-).
            // Selain itu, validasi panjang nomor telepon harus berada dalam rentang minLength dan maxLength.
            if (!string.IsNullOrWhiteSpace(nomor) &&
                Regex.IsMatch(nomor, @"^[0-9+\-]+$") &&
                nomor.Length >= minLength && nomor.Length <= maxLength)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nomor telepon tidak valid atau tidak memenuhi panjang yang diizinkan", "Validasi Nomor Telepon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
       

    }

}

