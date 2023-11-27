namespace XIIRPL2_15_Ticketing.MasterForm
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            panel1 = new Panel();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 594);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLightLight;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Red;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 558);
            button7.Name = "button7";
            button7.Size = new Size(147, 33);
            button7.TabIndex = 7;
            button7.Text = "Logout";
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 293);
            button5.Name = "button5";
            button5.Size = new Size(263, 38);
            button5.TabIndex = 6;
            button5.Text = "Ubah Status Penerbangan";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-2, 220);
            button4.Name = "button4";
            button4.Size = new Size(268, 38);
            button4.TabIndex = 5;
            button4.Text = "Master Kode Promo";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 145);
            button3.Name = "button3";
            button3.Size = new Size(266, 38);
            button3.TabIndex = 4;
            button3.Text = "      Master Jadwal Penerbangan";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 75);
            button2.Name = "button2";
            button2.Size = new Size(263, 40);
            button2.TabIndex = 3;
            button2.Text = "Master Maskapai";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-2, 3);
            button1.Name = "button1";
            button1.Size = new Size(268, 39);
            button1.TabIndex = 0;
            button1.Text = "Master Bandara";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(button6);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 44);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.DeepSkyBlue;
            button6.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, -3);
            button6.Name = "button6";
            button6.Size = new Size(266, 47);
            button6.TabIndex = 3;
            button6.Text = "Dashboard";
            button6.UseVisualStyleBackColor = false;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(899, 636);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmAdmin";
            Text = "Form1";
            Load += FrmAdmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button7;
    }
}