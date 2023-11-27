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
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO tbl_jadwal_penerbangan" + "(kode_penerbangan,bandara_keberangkatan_id,bandara_tujuam_id,maskapai_id,tanggal_waktu_keberangkatan,durasi_penerbangan,harga_per_ticket )" + "VALUES" + "('" + txtKode_Penerbangan.Text + "','" + txtDari.Text + "',"  + txtKe.Text + "','" + txtMaskapai.Text + "','" + txtTanggal_Keberangkatan.Text + "'," + txtDurasi_Penerbangan.Text + "'," + txtHarga_Ticket.Text  + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Jadwal Penerbangan");
                Koneksi.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter
                ("SELECT * FROM tbl_jadwal_penerbangan", Koneksi.conn);
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
                    String sql = "DELETE FROM tbl_jadwal_penerbangan WHERE id=@id";
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
