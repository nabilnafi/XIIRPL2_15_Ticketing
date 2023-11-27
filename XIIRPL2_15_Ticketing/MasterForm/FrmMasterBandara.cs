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
    public partial class FrmMasterBandara : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;




        public FrmMasterBandara()
        {
            InitializeComponent();
        }

        private void FrmMasterBandara_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO tbl_bandara" + "(nama,kode_iata,kota,negara_id,jumlah_terminal,alamat)" + "VALUES" + "('" + txtNama.Text + "','" + txtKodeIata.Text + "'," + "'" + txtKota.Text + "','" + txtNegara.Text + "'," + "'" + txtJumlahTerminal.Text + "','" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                Koneksi.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter
                ("SELECT * FROM tbl_bandara", Koneksi.conn);
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
                    String sql = "DELETE FROM tbl_bandara WHERE id=@id";
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

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
