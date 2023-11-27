namespace XIIRPL2_15_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterBandara));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNama = new TextBox();
            txtKota = new TextBox();
            txtKodeIata = new TextBox();
            txtNegara = new ComboBox();
            label7 = new Label();
            txtJumlahTerminal = new NumericUpDown();
            label8 = new Label();
            txtAlamat = new TextBox();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            btnBatal = new Button();
            btnSimpan = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 16);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 1;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(419, 20);
            label2.TabIndex = 2;
            label2.Text = "Semua Bandara yang sudah terdaftar, akan muncul di tabel ini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 357);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 420);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 483);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 544);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(107, 359);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(246, 31);
            txtNama.TabIndex = 7;
            // 
            // txtKota
            // 
            txtKota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKota.Location = new Point(107, 485);
            txtKota.Multiline = true;
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(246, 31);
            txtKota.TabIndex = 8;
            // 
            // txtKodeIata
            // 
            txtKodeIata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKodeIata.Location = new Point(107, 422);
            txtKodeIata.Multiline = true;
            txtKodeIata.Name = "txtKodeIata";
            txtKodeIata.Size = new Size(246, 31);
            txtKodeIata.TabIndex = 9;
            // 
            // txtNegara
            // 
            txtNegara.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(107, 541);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(246, 29);
            txtNegara.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(446, 362);
            label7.Name = "label7";
            label7.Size = new Size(123, 21);
            label7.TabIndex = 11;
            label7.Text = "Jumlah Terminal";
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtJumlahTerminal.Location = new Point(575, 355);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(238, 29);
            txtJumlahTerminal.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(446, 425);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 14;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlamat.Location = new Point(575, 420);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(238, 150);
            txtAlamat.TabIndex = 15;
            txtAlamat.TextChanged += txtAlamat_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(737, 249);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // btnBatal
            // 
            btnBatal.BackColor = Color.LightSlateGray;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.ForeColor = Color.MidnightBlue;
            btnBatal.Location = new Point(575, 600);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 42);
            btnBatal.TabIndex = 16;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LightSlateGray;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.ForeColor = Color.MidnightBlue;
            btnSimpan.Location = new Point(738, 600);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 42);
            btnSimpan.TabIndex = 17;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(836, 659);
            Controls.Add(pictureBox2);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(dataGridView1);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(label7);
            Controls.Add(txtNegara);
            Controls.Add(txtKodeIata);
            Controls.Add(txtKota);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterBandara";
            Text = "Master Bandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNama;
        private TextBox txtKota;
        private TextBox txtKodeIata;
        private ComboBox txtNegara;
        private Label label7;
        private NumericUpDown txtJumlahTerminal;
        private Label label8;
        private TextBox txtAlamat;
        private DataGridView dataGridView1;
        private Button btnBatal;
        private Button btnSimpan;
        private PictureBox pictureBox2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}