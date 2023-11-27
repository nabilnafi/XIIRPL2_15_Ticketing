namespace XIIRPL2_15_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterMaskapai));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtJumlahKru = new NumericUpDown();
            pictureBox1 = new PictureBox();
            btnSimpan = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(514, 562);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 33;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(615, 208);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeskripsi.Location = new Point(514, 351);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(275, 156);
            txtDeskripsi.TabIndex = 32;
            txtDeskripsi.TextChanged += txtDeskripsi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(423, 354);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 31;
            label8.Text = "Deskripsi";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPerusahaan.Location = new Point(108, 414);
            txtPerusahaan.Multiline = true;
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(246, 31);
            txtPerusahaan.TabIndex = 27;
            txtPerusahaan.TextChanged += txtPerusahaan_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(108, 352);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(246, 31);
            txtNama.TabIndex = 25;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 480);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 23;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 417);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 22;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 355);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 21;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, -61);
            label2.Name = "label2";
            label2.Size = new Size(419, 20);
            label2.TabIndex = 20;
            label2.Text = "Semua Bandara yang sudah terdaftar, akan muncul di tabel ini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, -86);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 19;
            label1.Text = "Master Bandara";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 41);
            label9.Name = "label9";
            label9.Size = new Size(371, 20);
            label9.TabIndex = 36;
            label9.Text = "Semua Maskapai yang terdaftar ada di tabel bawah ini\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(54, 16);
            label10.Name = "label10";
            label10.Size = new Size(162, 25);
            label10.TabIndex = 35;
            label10.Text = "Master Maskapai";
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtJumlahKru.Location = new Point(108, 478);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(246, 29);
            txtJumlahKru.TabIndex = 37;
            txtJumlahKru.ValueChanged += txtJumlahKru_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LightSlateGray;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.ForeColor = Color.MidnightBlue;
            btnSimpan.Location = new Point(714, 562);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 42);
            btnSimpan.TabIndex = 34;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button2_Click;
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
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 613);
            Controls.Add(pictureBox1);
            Controls.Add(txtJumlahKru);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterMaskapai";
            Text = "Bromo Airlines - Maskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label10;
        private NumericUpDown numericUpDown2;
        private PictureBox pictureBox1;
        private Button btnSimpan;
        private TextBox txtnama;
        private TextBox txtNama;
        private TextBox txtPerusahaan;
        private NumericUpDown txtJumlah;
        private NumericUpDown txtJumlahKru;
        private TextBox txtDeskripsi;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}