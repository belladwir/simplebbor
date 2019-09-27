using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Modul4
{
    public partial class Form1 : Form
    {
        //Prepare the connection
        private static string connectuinString = "server=localhost;port=3306;username=root;password=;database=perpustakaan";
        private MySqlConnection databaseConnection = new MySqlConnection(connectuinString);

        private void refresh()
        {
            listBuku.Items.Clear();
            string query = "SELECT * FROM data_buku WHERE jumlah != 0";
            MySqlCommand cmd2 = new MySqlCommand(query, databaseConnection);
            cmd2.CommandTimeout = 60;
            MySqlDataReader reader = cmd2.ExecuteReader();

            //IMPORTANT :
            //if your query returns result, use the following processor :
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                    listViewItem.SubItems.Add(reader["judul"].ToString());
                    listViewItem.SubItems.Add(reader["pengarang"].ToString());
                    listViewItem.SubItems.Add(reader["jumlah"].ToString());
                    listBuku.Items.Add(listViewItem);
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("No rows found.");
            }
        }

        public void refreshPeminjaman()
        {
            list_pinjam.Items.Clear();
            string query = "SELECT * FROM `data_peminjaman` INNER JOIN mahasiswa ON data_peminjaman.id_mahasiswa = mahasiswa.id_mahasiswa INNER JOIN data_buku ON data_peminjaman.kode_buku = data_buku.id_buku WHERE status = 'pinjam'";
            try
            {
                databaseConnection.Open();
                MySqlCommand cmd2 = new MySqlCommand(query, databaseConnection);
                cmd2.CommandTimeout = 60;
                MySqlDataReader reader = cmd2.ExecuteReader();

                //IMPORTANT :
                //if your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listpinjaman = new ListViewItem(reader["id_peminjaman"].ToString());
                        listpinjaman.SubItems.Add(reader["nama_mhs"].ToString());
                        listpinjaman.SubItems.Add(reader["judul"].ToString());
                        listpinjaman.SubItems.Add(reader["pengarang"].ToString());
                        listpinjaman.SubItems.Add(reader["jumlah_buku"].ToString());
                        listpinjaman.SubItems.Add(reader["status"].ToString());
                        listpinjaman.SubItems.Add(reader["tanggal_pinjam"].ToString());
                        list_pinjam.Items.Add(listpinjaman);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
            
        }

        public void getmhs()
        {
            string query = "SELECT * FROM `mahasiswa`;";
            try
            {
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        comboBox_mhs.Items.Add(r.GetString("nama_mhs"));
                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Tidak ada mahasiswa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_tambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_buku (id_buku, judul, pengarang, jumlah) VALUES (@id, @judul, @pengarang, @jumlah)";
            
            try
            {
                //Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
                refresh();
            }
            catch (Exception ex)
            {
                //Show any error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void Button_hapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_buku where id_buku = @id";
            try
            {
                //Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
                refresh();
            }
            catch(Exception ex)
            {
                //Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_buku SET judul = @judul, pengarang = @pengarang, jumlah = @jumlah WHERE id_buku = @id";
            try
            {
                //Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupadate");
                refresh();
            }
            catch(Exception ex)
            {
                //Show any error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshPeminjaman();
            getmhs();
            string query = "SELECT * FROM data_buku WHERE jumlah != 0";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();

                //IMPORTANT :
                //if your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
                        
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                //Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void Button_cari_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM data_buku WHERE (judul LIKE '%" +textBox_cari.Text + "%' OR pengarang LIKE '%" + textBox_cari.Text + "%') AND (judul LIKE '%" + textBox_cari.Text + "%' OR pengarang LIKE '%" + textBox_cari.Text + "%')";
            try
            {
                listBuku.Items.Clear();
                //Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                //cmd.Parameters.AddWithValue("@cari", textBox_cari.Text);
                //cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                //IMPORTANT :
                //if your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                //Show any error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        ListViewItem listview;
        private void ListBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pengecekan ada yang di select atau tidak
            if (listBuku.SelectedItems.Count > 0)
            {
                listview = listBuku.SelectedItems[0];
                text_id.Text = listview.SubItems[0].Text;
                text_judul.Text = listview.SubItems[1].Text;
                text_pengarang.Text = listview.SubItems[2].Text;
                text_jumlah.Text = listview.SubItems[3].Text;
                btn_pinjam.Enabled = true;
            }
            else
            {
                text_id.Text = "";
                text_judul.Text = "";
                text_pengarang.Text = "";
                text_jumlah.Text = "";
                btn_pinjam.Enabled = false;
            }
        }

        public void clearText()
        {
            text_id.Text = "";
            text_judul.Text = "";
            text_pengarang.Text = "";
            text_jumlah.Text = "";
            textBox1.Text = "";
        }

        String pilih_mhs;
        private void ComboBox_mhs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object mhs = comboBox_mhs.SelectedItem;
            pilih_mhs = mhs.ToString();

            string query = "SELECT id_mahasiswa FROM mahasiswa WHERE nama_mhs = @pilih";

            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            cmd.Parameters.AddWithValue("@pilih", pilih_mhs);
            cmd.ExecuteNonQuery();
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    label10.Text = r["id_mahasiswa"].ToString();
                }
                r.Close();
            }
            databaseConnection.Close();
        }

        private void Btn_pinjam_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_peminjaman (id_mahasiswa, kode_buku, jumlah_buku, tanggal_pinjam, status) VALUES (@id, @kode_buku, @jumlah, @tanggal_pinjam, 'pinjam');";
            try
            {
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", label10.Text);
                cmd.Parameters.AddWithValue ("@kode_buku", text_id.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.Parameters.AddWithValue("@tanggal_pinjam", date_pinjam.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menambahkan peminjaman");
                refresh();
                clearText();
                btn_pinjam.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                refreshPeminjaman();
            }
        }

        string id_pengembalian;
        private void List_pinjam_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Pengecekan ada yang di select atau tidak
            if (list_pinjam.SelectedItems.Count > 0)
            {
                listview = list_pinjam.SelectedItems[0];
                id_pengembalian = listview.SubItems[0].Text;
                textBox1.Text = listview.SubItems[1].Text;
                btn_pengembalian.Enabled = true;
            }
            else
            {
                textBox1.Text = "";
                btn_pengembalian.Enabled = false;
            }
        }

        private void Btn_pengembalian_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_peminjaman SET status = 'kembali', tanggal_kembali = @tanggal WHERE id_peminjaman = @id";
            try
            {
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", id_pengembalian);
                cmd.Parameters.AddWithValue("@tanggal", date_kembali.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pengembalian berhasil");
                refresh();
                clearText();
                btn_pengembalian.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                refreshPeminjaman();
            }
        }
    }
}
