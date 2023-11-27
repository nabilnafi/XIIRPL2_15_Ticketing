namespace XIIRPL2_15_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterKodePromo));
            txtMaksimumDiskon = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            btnSimpan = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtKodePromo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtBerlakuSampai = new DateTimePicker();
            label1 = new Label();
            txtPersentaseDiskon = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaksimumDiskon.Location = new Point(161, 535);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(322, 29);
            txtMaksimumDiskon.TabIndex = 50;
            txtMaksimumDiskon.ValueChanged += txtMaksimumDiskon_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 46);
            label9.Name = "label9";
            label9.Size = new Size(459, 20);
            label9.TabIndex = 49;
            label9.Text = "Semua Kode Promo yang Terdaftar Akan Muncul Di Tabel bawah ini.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.MiddleRight;
            label10.Location = new Point(55, 21);
            label10.Name = "label10";
            label10.Size = new Size(190, 25);
            label10.TabIndex = 48;
            label10.Text = "Master Kode Promo";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LightSlateGray;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.ForeColor = Color.MidnightBlue;
            btnSimpan.Location = new Point(846, 567);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 42);
            btnSimpan.TabIndex = 47;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(626, 567);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 46;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(637, 210);
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
            // txtDeskripsi
            // 
            txtDeskripsi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeskripsi.Location = new Point(626, 360);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(295, 156);
            txtDeskripsi.TabIndex = 45;
            txtDeskripsi.TextChanged += txtDeskripsi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(546, 360);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 44;
            label8.Text = "Deskripsi";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKodePromo.Location = new Point(161, 357);
            txtKodePromo.Multiline = true;
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(322, 31);
            txtKodePromo.TabIndex = 42;
            txtKodePromo.TextChanged += txtKodePromo_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 537);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 41;
            label5.Text = "Maksimum Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 474);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 40;
            label4.Text = "Persentase Diskon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 363);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 39;
            label3.Text = "Kode Promo";
            label3.Click += label3_Click;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBerlakuSampai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBerlakuSampai.Location = new Point(161, 418);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(322, 29);
            txtBerlakuSampai.TabIndex = 61;
            txtBerlakuSampai.ValueChanged += txtBerlakuSampai_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 424);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 60;
            label1.Text = "Berlaku Sampai";
            // 
            // txtPersentaseDiskon
            // 
            txtPersentaseDiskon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPersentaseDiskon.Location = new Point(161, 472);
            txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            txtPersentaseDiskon.Size = new Size(322, 29);
            txtPersentaseDiskon.TabIndex = 62;
            txtPersentaseDiskon.ValueChanged += txtPersentaseDiskon_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 653);
            Controls.Add(pictureBox1);
            Controls.Add(txtPersentaseDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(label1);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtKodePromo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMasterKodePromo";
            Text = "Bromo Airlines - Kode Promo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown2;
        private Label label9;
        private Label label10;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private NumericUpDown txtMaksimumDiskon;
        private Button btnSimpan;
        private TextBox txtDeskripsi;
        private TextBox txtKodePromo;
        private DateTimePicker txtBerlakuSampai;
        private NumericUpDown txtPersentaseDiskon;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}