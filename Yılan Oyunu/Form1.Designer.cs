namespace Yılan_Oyunu
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Yazı = new Label();
            label1 = new Label();
            label2 = new Label();
            Skor = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(4, 10);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 440);
            panel1.TabIndex = 0;
            // 
            // Yazı
            // 
            Yazı.AutoSize = true;
            Yazı.BackColor = SystemColors.ActiveCaption;
            Yazı.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Yazı.Location = new Point(589, 114);
            Yazı.Margin = new Padding(4, 0, 4, 0);
            Yazı.Name = "Yazı";
            Yazı.Size = new Size(239, 65);
            Yazı.TabIndex = 4;
            Yazı.Text = "Kaybetin!!";
            Yazı.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(712, 214);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 1;
            label1.Text = "BAŞLA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(726, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "SKOR";
            // 
            // Skor
            // 
            Skor.AutoSize = true;
            Skor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Skor.Location = new Point(747, 57);
            Skor.Margin = new Padding(4, 0, 4, 0);
            Skor.Name = "Skor";
            Skor.Size = new Size(32, 37);
            Skor.TabIndex = 3;
            Skor.Text = "0";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(692, 304);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 75);
            label3.TabIndex = 5;
            label3.Text = "⚠  Oyunu Oynamak i\r\nçin\"BAŞLA\" butonuna \r\nbasınız.Yılanı hareket\r\nettirmek için yön\r\ntuşlarını kullanınız.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 499);
            Controls.Add(label3);
            Controls.Add(Yazı);
            Controls.Add(Skor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Yılan Oyunu";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label Skor;
        private System.Windows.Forms.Timer timer1;
        private Label Yazı;
        private Label label3;
    }
}
