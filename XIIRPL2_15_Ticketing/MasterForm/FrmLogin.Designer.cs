namespace XIIRPL2_15_Ticketing
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(154, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 155);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(154, 254);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(154, 298);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(253, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(253, 295);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 29);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(582, 344);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(376, 423);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 8;
            label3.Text = "Belum Punya Akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(530, 423);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 21);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Daftar Sekarang!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(861, 488);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "Bromo Airlines_Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}