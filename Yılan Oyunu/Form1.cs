namespace Yılan_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Panel Kuyruk;
        Panel Yem = new Panel();
        List<Panel> Yilan = new List<Panel>();

        String Yon = "Sağ";


        private void label1_Click(object sender, EventArgs e)
        {

            Skor.Text = "0";
            Basla();

            Kuyruk = new Panel();
            Kuyruk.Location = new Point(300, 300);
            Kuyruk.Size = new Size(20, 20);
            Kuyruk.BackColor = Color.Green;
            Yilan.Add(Kuyruk);
            panel1.Controls.Add(Yilan[0]);
            timer1.Start();
            YemOlustur();
        }


        void Basla()
        {
            panel1.Controls.Clear();
            Yilan.Clear();
            Yazı.Visible = false;
        }

        void Kontrol()
        {
            for(int i = 2; i < Yilan.Count; i++)
            {
                if (Yilan[0].Location == Yilan[i].Location)
                {
                    Yazı.Text = "Kaybettin";
                    Yazı.Visible = true;
                    timer1.Stop();
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int konumX = Yilan[0].Location.X;
            int konumY = Yilan[0].Location.Y;
            Çarpışma();
            ekle();
            Kontrol();
            if (Yon == "Sağ")
            {
                if (konumX < 680)
                {
                    konumX += 20;
                }
                else
                {
                    konumX = 0;
                }
            }


            if (Yon == "Sol")
            {
                if (konumX > 0)
                {
                    konumX -= 20;
                }
                else
                {
                    konumX = 680;
                }
            }



            if (Yon == "Aşağı")
            {
                if (konumY < 440)
                {
                    konumY += 20;
                }
                else
                {
                    konumY = 0;
                }
            }



            if (Yon == "Yukarı")
            {
                if (konumY > 0)
                {
                    konumY -= 20;
                }
                else
                {
                    konumY = 440;
                }
            }


            Yilan[0].Location = new Point(konumX, konumY);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && Yon!="Sol")
            {
                Yon = "Sağ";
            }

            if (e.KeyCode == Keys.Left && Yon != "Sağ")
            {
                Yon = "Sol";
            }

            if (e.KeyCode == Keys.Up && Yon != "Aşağı")
            {
                Yon = "Yukarı";
            }

            if (e.KeyCode == Keys.Down && Yon != "Yukarı")
            {
                Yon = "Aşağı";
            }
        }

        void YemOlustur()
        {

            Random Rastgele=new Random();
            int YemX, YemY;
            YemX = Rastgele.Next(680);
            YemY = Rastgele.Next(440);


            YemX -= YemX % 20;
            YemY -= YemY % 20;

            Yem.Size = new Size(20, 20);
            Yem.BackColor = Color.OrangeRed;
            Yem.Location = new Point(YemX,YemY);
            panel1.Controls.Add(Yem);
        }

        void Çarpışma()
        {

            int puan = int.Parse(Skor.Text);

            if (Yilan[0].Location==Yem.Location)
            {
                panel1.Controls.Remove(Yem);
                puan += 10;
                Skor.Text=puan.ToString();
                YemOlustur();
                YılanOLustur();
            }
          
        }

        void YılanOLustur()
        {
            Panel Parca = new Panel();
            Parca.Size=new Size(20, 20);
            Parca.BackColor=Color.Green;
            Yilan.Add(Parca);
            panel1.Controls.Add(Parca);
        }

        void ekle()
        {
            for (int i = Yilan.Count-1; i > 0; i--)
            {
                Yilan[i].Location = Yilan[i - 1].Location;
            }
        }

    }
}
