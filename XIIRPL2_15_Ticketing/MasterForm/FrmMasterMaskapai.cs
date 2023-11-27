using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL2_15_Ticketing.MasterForm
{
    public partial class FrmMasterMaskapai : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;

        public FrmMasterMaskapai()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO tbl_maskapai" + "(nama,perusahaan,jumlah_kru,deskripsi )" + "VALUES" + "('" + txtNama.Text + "','" + txtPerusahaan.Text + "'," + "'" + txtJumlahKru.Text + "','" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Maskapai");
                Koneksi.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMasterMaskapai_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void txtJumlahKru_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPerusahaan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter
                ("SELECT * FROM tbl_maskapai", Koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_maskapai WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, Koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }
            }
        }
    }
}
