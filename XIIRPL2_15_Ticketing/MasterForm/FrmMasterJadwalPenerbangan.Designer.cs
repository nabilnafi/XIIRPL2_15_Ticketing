namespace XIIRPL2_15_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterJadwalPenerbangan));
            label9 = new Label();
            label10 = new Label();
            btnSimpan = new Button();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtKode_Penerbangan = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtMaskapai = new ComboBox();
            txtDari = new ComboBox();
            txtKe = new ComboBox();
            btnBatal = new Button();
            label8 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTanggal_Keberangkatan = new DateTimePicker();
            txtHarga_Ticket = new NumericUpDown();
            txtWaktu_Keberangkatan = new TextBox();
            txtDurasi_Penerbangan = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHarga_Ticket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 42);
            label9.Name = "label9";
            label9.Size = new Size(373, 20);
            label9.TabIndex = 49;
            label9.Text = "Semua Jadwal penerbangan muncul di tabel bawah ini.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(43, 17);
            label10.Name = "label10";
            label10.Size = new Size(262, 25);
            label10.TabIndex = 48;
            label10.Text = "Master Jadwal Penerbangan";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LightSlateGray;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.ForeColor = Color.MidnightBlue;
            btnSimpan.Location = new Point(894, 606);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 42);
            btnSimpan.TabIndex = 47;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(23, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 233);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtKode_Penerbangan
            // 
            txtKode_Penerbangan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKode_Penerbangan.Location = new Point(172, 353);
            txtKode_Penerbangan.Multiline = true;
            txtKode_Penerbangan.Name = "txtKode_Penerbangan";
            txtKode_Penerbangan.Size = new Size(246, 31);
            txtKode_Penerbangan.TabIndex = 42;
            txtKode_Penerbangan.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 481);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 41;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 418);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 40;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 356);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 39;
            label3.Text = "Kode Peberbangan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 541);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 51;
            label1.Text = "Maskapai";
            // 
            // txtMaskapai
            // 
            txtMaskapai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(172, 539);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(246, 29);
            txtMaskapai.TabIndex = 52;
            txtMaskapai.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtDari
            // 
            txtDari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(172, 415);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(246, 29);
            txtDari.TabIndex = 53;
            txtDari.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtKe
            // 
            txtKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(172, 478);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(246, 29);
            txtKe.TabIndex = 54;
            txtKe.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.LightSlateGray;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.ForeColor = Color.MidnightBlue;
            btnBatal.Location = new Point(647, 606);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 42);
            btnBatal.TabIndex = 46;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(446, 356);
            label8.Name = "label8";
            label8.Size = new Size(171, 21);
            label8.TabIndex = 55;
            label8.Text = "Tanggal Keberangkatan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(446, 418);
            label2.Name = "label2";
            label2.Size = new Size(162, 21);
            label2.TabIndex = 56;
            label2.Text = "Waktu Keberangkatan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(446, 481);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 57;
            label6.Text = "Durasi Penerbangan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(446, 539);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 58;
            label7.Text = "Harga Per-Tiket";
            // 
            // txtTanggal_Keberangkatan
            // 
            txtTanggal_Keberangkatan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTanggal_Keberangkatan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTanggal_Keberangkatan.Location = new Point(647, 355);
            txtTanggal_Keberangkatan.Name = "txtTanggal_Keberangkatan";
            txtTanggal_Keberangkatan.Size = new Size(322, 29);
            txtTanggal_Keberangkatan.TabIndex = 59;
            txtTanggal_Keberangkatan.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtHarga_Ticket
            // 
            txtHarga_Ticket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHarga_Ticket.Location = new Point(647, 539);
            txtHarga_Ticket.Name = "txtHarga_Ticket";
            txtHarga_Ticket.Size = new Size(322, 29);
            txtHarga_Ticket.TabIndex = 60;
            txtHarga_Ticket.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // txtWaktu_Keberangkatan
            // 
            txtWaktu_Keberangkatan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWaktu_Keberangkatan.Location = new Point(647, 415);
            txtWaktu_Keberangkatan.Multiline = true;
            txtWaktu_Keberangkatan.Name = "txtWaktu_Keberangkatan";
            txtWaktu_Keberangkatan.Size = new Size(322, 31);
            txtWaktu_Keberangkatan.TabIndex = 61;
            txtWaktu_Keberangkatan.TextChanged += textBox2_TextChanged;
            // 
            // txtDurasi_Penerbangan
            // 
            txtDurasi_Penerbangan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDurasi_Penerbangan.Location = new Point(647, 478);
            txtDurasi_Penerbangan.Multiline = true;
            txtDurasi_Penerbangan.Name = "txtDurasi_Penerbangan";
            txtDurasi_Penerbangan.Size = new Size(322, 31);
            txtDurasi_Penerbangan.TabIndex = 62;
            txtDurasi_Penerbangan.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 685);
            Controls.Add(pictureBox1);
            Controls.Add(txtDurasi_Penerbangan);
            Controls.Add(txtWaktu_Keberangkatan);
            Controls.Add(txtHarga_Ticket);
            Controls.Add(txtTanggal_Keberangkatan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(txtKe);
            Controls.Add(txtDari);
            Controls.Add(txtMaskapai);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(dataGridView1);
            Controls.Add(txtKode_Penerbangan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterJadwalPenerbangan";
            Text = "Bromo Airlines - Jadwal Penerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHarga_Ticket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label10;
        private Button btnSimpan;
        private DataGridView dataGridView1;
        private TextBox txtKode_Penerbangan;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox txtMaskapai;
        private ComboBox txtDari;
        private ComboBox txtKe;
        private Button btnBatal;
        private Label label8;
        private Label label2;
        private Label label6;
        private Label label7;
        private DateTimePicker txtTanggal_Keberangkatan;
        private NumericUpDown txtHarga_Ticket;
        private TextBox txtWaktu_Keberangkatan;
        private TextBox txtDurasi_Penerbangan;
        private PictureBox pictureBox1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}