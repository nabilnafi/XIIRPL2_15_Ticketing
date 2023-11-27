namespace XIIRPL2_15_Ticketing.MasterForm
{
    partial class FrmUbahStatusPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbahStatusPenerbangan));
            label9 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 44);
            label9.Name = "label9";
            label9.Size = new Size(458, 20);
            label9.TabIndex = 52;
            label9.Text = "Anda bisa mengubah status jadwal penerbangan di tabel bawah ini.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.MiddleRight;
            label10.Location = new Point(56, 19);
            label10.Name = "label10";
            label10.Size = new Size(243, 25);
            label10.TabIndex = 51;
            label10.Text = "Ubah Status Penerbangan";
            label10.Click += label10_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(720, 392);
            dataGridView1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // UbahStatusPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 493);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UbahStatusPenerbangan";
            Text = "Bromo Airlines - Ubah Status Penerbangan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label10;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}