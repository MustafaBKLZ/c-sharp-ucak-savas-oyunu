using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucak_Savasi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int solHareket = 0, ducakHareketHiz = 3, mermiHiz = 8, can = 5, Puan = 0, mukemmel_zorluk = 20, iyi_puan = 10, muk_puan = 50, ekcan = 1;
        private PictureBox p_can()
        {
            PictureBox p_can = new PictureBox();
            p_can.Image = global::Ucak_Savasi.Properties.Resources.can;
            p_can.SizeMode = PictureBoxSizeMode.StretchImage;
            p_can.Size = new Size(20, 20);
            return p_can;
        }
        PictureBox Mermi = new PictureBox();

        private PictureBox p_ates()
        {
            Mermi = new PictureBox();
            Mermi.Name = "mermi";
            Mermi.Image = global::Ucak_Savasi.Properties.Resources.ates;
            Mermi.SizeMode = PictureBoxSizeMode.StretchImage;
            Mermi.Size = new Size(20, 20);
            this.Controls.Add(Mermi);
            Mermi.Location = new Point(-100, -100);
            return Mermi;
        }


        public Form1()
        {
            InitializeComponent();

            // düşman uçağını formun dışına atıyoruz
            dusman_1.Top = -500;
            dusman_2.Top = -900;
            dusman_3.Top = -1300;
            //farklı olmalarının sebebi aynı anda ekrana gelmesinler.


            // labelleri formun dışına atıyoruz.
            lbl_durum.Top = -100;
            lbl_puan.Top = -100;

            // mermiyi formun dışına atıyoruz.
            Mermi.Top = -100;
            Mermi.Left = -100;
            p_ates();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                flowLayoutPanel1.Controls.Add(p_can());


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                basla(); // ENTER tuşu ile başlar
            }
            if (e.KeyCode == Keys.S)
            {
                oyunSonu(); // S, STOP tuşu ile oyun biter.
            }

            if (e.KeyCode == Keys.Left) // sol oka bastığmızda sola gidecek
            {
                if (player.Location.X < 0) //eğer çok fazla gidipte formdan çıkarsa
                {
                    solHareket = 0;
                    player.Location = new Point(0, 498); // orada kalsın. X (yatay) koordinatta formdan çıkamasın.
                }
                else
                {
                    solHareket = -10; // from sınırlarını aşmıyorsa -10 yani sola gitsin
                }
            }

            else if (e.KeyCode == Keys.Right)// sağ oka bastığmızda sağa gidecek
            {
                if (player.Location.X > 512)//eğer çok fazla gidipte formdan çıkarsa
                {
                    player.Location = new Point(512, 498);// orada kalsın. X (yatay) koordinatta formdan çıkamasın.
                    solHareket = 0;
                }
                else
                {
                    solHareket = 10;// from sınırlarını aşmıyorsa +10 yani sağa gitsin
                }
            }

            else if (e.KeyCode == Keys.Space) // boşluk tuşu ateş eder.
            {
                p_ates();
                foreach (Control item in this.Controls)
                {
                    if (item.Name.Contains("mermi"))
                    {
                        mermiHiz = 1; // merminin hızı
                        Mermi.Left = player.Left + 40; // mersinin görsel olarak çıkacağı yer. Uçağın ortasından; 
                        Mermi.Top = player.Top; // mersinin görsel olarak çıkacağı yer. Uçağın ucundan;
                    }
                }


            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // sol ok tuşuna artık basılmıyorsa hızı kes
            {
                solHareket = 0;
            }
            else if (e.KeyCode == Keys.Right) // sağ ok tuşuna artık basılmıyorsa hızı kes
            {
                solHareket = 0;
            }
        }


        private void oyunaBaşlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basla();
        }
        private void oyunuBitirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oyunSonu();
        }
        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zorToolStripMenuItem.Checked = true;
            ortaToolStripMenuItem.Checked = false;
            kolayToolStripMenuItem.Checked = false;
            rad_zor.Checked = true;
        }
        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zorToolStripMenuItem.Checked = false;
            ortaToolStripMenuItem.Checked = true;
            kolayToolStripMenuItem.Checked = false;
            rad_orta.Checked = true;
        }
        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zorToolStripMenuItem.Checked = false;
            ortaToolStripMenuItem.Checked = false;
            kolayToolStripMenuItem.Checked = true;
            rad_kolay.Checked = true;
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            basla();
        }
        private void btn_duraklat_Click(object sender, EventArgs e)
        {
            oyunSonu();
        }

        private void basla()
        {
            // oyunu sıfırlıyoruz. Başlangıçta nasılsa o hale gelecek.
            dusman_1.Top = -500;
            dusman_2.Top = -900;
            dusman_3.Top = -1300;
            Mermi.Top = -100;
            Mermi.Left = -100;

            can = 5;

            player.Location = new Point(258, 498);

            kolayToolStripMenuItem.Enabled = false;
            ortaToolStripMenuItem.Enabled = false;
            zorlukToolStripMenuItem.Enabled = false;
            oyunaBaşlaToolStripMenuItem.Enabled = false;
            oyunuBitirToolStripMenuItem.Enabled = true;

            // seçilen zorluğa göre düşman uçaklarının hızını ayarlıyoruz.
            if (kolayToolStripMenuItem.Checked == true) ducakHareketHiz = 2;
            if (ortaToolStripMenuItem.Checked == true) ducakHareketHiz = 5;
            if (zorlukToolStripMenuItem.Checked == true) ducakHareketHiz = 7;

            panel1.Enabled = false;
            timer1.Start();
        }
        private void oyunSonu()
        {
            // oyun biter, bildirimverişir herşey sıfırlanır
            timer1.Stop();
            timer1.Enabled = false;

            dusman_1.Top = -500;
            dusman_2.Top = -900;
            dusman_3.Top = -1300;
            Mermi.Top = -100;
            Mermi.Left = -100;
            MessageBox.Show("Oyun Bitti! - " + Puan + " Puan Kazandınız....", "Uçak Oyunu V1.0 www.bilisimogretmeni.com", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Puan = 0;
            lblsonuc.Text = "0";
            panel1.Enabled = true;

            oyunaBaşlaToolStripMenuItem.Enabled = true;
            kolayToolStripMenuItem.Enabled = true;
            ortaToolStripMenuItem.Enabled = true;
            zorlukToolStripMenuItem.Enabled = true;
            oyunuBitirToolStripMenuItem.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // NOT: Timer1'in İnterval'i 10'dur. Tuşlar saniyede 100 defa kontrol ediliyor

            player.Left += solHareket; // oyuncu uçağının koordinatını, tuşa basılı olduğu sürece değiştir.


            dusman_1.Top += ducakHareketHiz; // düşman uçaklarının hareketi sağlanıyor. 
            dusman_2.Top += ducakHareketHiz; // düşman uçaklarının hareketi sağlanıyor. 
            dusman_3.Top += ducakHareketHiz; // düşman uçaklarının hareketi sağlanıyor. 

            lblsonuc.Text = "" + Puan; // puanı yazdık

            if (can > 0) // canlarımız tükenmediyse...
            {
                if (dusman_1.Bottom >= player.Top + player.Height / 2)
                // düşman uçağının alt çizgisi, player'in yarısına kadar gelmiş ise
                {
                    if ((dusman_1.Right > player.Left && dusman_1.Right < player.Right) || (dusman_1.Left > player.Left && dusman_1.Left < player.Right))
                    // Düşman uçağının sağ çizgisi; player uçağının sol çizgisininden içeri girmişse yada player uçağının sağ çizgisininden içeri girmiş ise 
                    // Yani düşman uçağının sağ çizgisi ya da sol çizgisi, player uçağınına değmiş ise
                    // Yani bir çarpışma var ise
                    {
                        dusman_1.Top = -500;
                        can--;
                        canlar();

                    }
                }
                else if (dusman_2.Bottom >= player.Top + player.Height / 2)
                {
                    if ((dusman_2.Right > player.Left && dusman_2.Right < player.Right) || (dusman_2.Left > player.Left && dusman_2.Left < player.Right))
                    {
                        dusman_2.Top = -900;
                        can--;
                        canlar();
                    }
                }
                else if (dusman_3.Bottom >= player.Top + player.Height / 2)
                {
                    if ((dusman_3.Right > player.Left && dusman_3.Right < player.Right) || (dusman_3.Left > player.Left && dusman_3.Left < player.Right))
                    {
                        dusman_3.Top = -1300;
                        can--;
                        canlar();
                    }
                }
                if (dusman_1.Bottom >= 630)
                // eğer düşman uçak player uçağa çarpmamış ama onu geçmiş gitmiş ise..
                {
                    dusman_1.Top = -500;
                    can--;
                    canlar();
                }
                else if (dusman_2.Bottom >= 630)
                {
                    dusman_2.Top = -900;
                    can--;
                    canlar();
                }
                else if (dusman_3.Bottom >= 630)
                {
                    dusman_3.Top = -1300;
                    can--;
                    canlar();
                }
            }
            else
            {
                oyunSonu(); // can biterse oyun biter
            }

            foreach (Control item in this.Controls)
            {
                if (item.Name.Contains("mermi"))
                {
                    mermiHiz = 10; // merminin hızı
                    item.Top -= mermiHiz;
                }
            }


            // labeller çarpışma noktasına giderek ve yukarı doğru çıkarak kaybolacak.
            lbl_puan.Top -= 5;
            lbl_durum.Top -= 5;


            Vurulma(); // düşman uçağı vurma
        }

        private void canlar() // canların azalması ve kalplerin kaybolması
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < can; i++)
            {
                flowLayoutPanel1.Controls.Add(p_can());
            }
        }
        private void can_ekle()
        {
            if (Puan > 100 && ekcan == 1)
            {
                can++; ekcan = 2; canlar();
            }
            if (Puan > 200 && ekcan == 2)
            {
                can++; ekcan = 3; canlar();
            }
            if (Puan > 300 && ekcan == 3)
            {
                can++; ekcan = 4; canlar();
            }
            if (Puan > 400 && ekcan == 4)
            {
                can++; ekcan = 5; canlar();
            }
            if (Puan > 500 && ekcan == 5)
            {
                can++; ekcan = 6; canlar();
            }
        }
        private void Vurulma()
        {
            if (Mermi.Bounds.IntersectsWith(dusman_1.Bounds)) // mermi düşman uçak 1 e değdi ise
            {
                // eğer mermi, düşman uçaklrının tam ortasına değdi ise 2 puan, kanatlarına değdi ise 1 puan verilecek.
                // Bu sebeple merminin nereye değdiğini bulmamaız gerekiyor.
                int ucde_biri;
                ucde_biri = dusman_1.Width / 3;
                int left = dusman_1.Left;
                int right = dusman_1.Right;

                // burada amacımız puan ve durum labelleri ateş ile uçağın çarpışma noktasına gidip oradan 
                // yukarı çıkarak kaybolması

                lbl_puan.Location = Mermi.Bounds.Location;
                lbl_durum.Location = new Point(Mermi.Bounds.Location.X, Mermi.Bounds.Location.Y + 25);

                // mükemmel puanın aralığını parametrik olarak azalttık.
                // bu sayede burada istersek, seçilen zorluğua göre mükemmeli de zorlaştırabiliriz.
                if (Mermi.Right < left + ucde_biri + mukemmel_zorluk || Mermi.Left > right - ucde_biri - mukemmel_zorluk)

                {
                    Puan += iyi_puan;
                    lbl_puan.Text = "+" + iyi_puan + " Puan";
                    lbl_durum.Text = "GÜZEL!";
                }
                else
                {
                    Puan += muk_puan;
                    lbl_puan.Text = "+" + muk_puan + " Puan";
                    lbl_durum.Text = "MÜKEMMEL!";
                }

                can_ekle();

                dusman_1.Top = -500; // vurulan düşman geriye gider.
                int ranP = rnd.Next(1, 300); //random bir sayı alır ve
                dusman_1.Left = ranP; // o hizadan başlar.

                // Mermi sıfırlanır.
                mermiHiz = 0;
                Mermi.Top = -100;
                Mermi.Left = -100;
            }
            else if (Mermi.Bounds.IntersectsWith(dusman_2.Bounds))
            {
                int ucde_biri;
                ucde_biri = dusman_2.Width / 3;
                int left = dusman_2.Left;
                int right = dusman_2.Right;

                lbl_puan.Location = Mermi.Bounds.Location;
                lbl_durum.Location = new Point(Mermi.Bounds.Location.X, Mermi.Bounds.Location.Y + 25);

                if (Mermi.Right < left + ucde_biri + mukemmel_zorluk || Mermi.Left > right - ucde_biri - mukemmel_zorluk)
                {
                    Puan += iyi_puan;
                    lbl_puan.Text = "+" + iyi_puan + " Puan";
                    lbl_durum.Text = "GÜZEL!";
                }
                else
                {
                    Puan += muk_puan;
                    lbl_puan.Text = "+" + muk_puan + " Puan";
                    lbl_durum.Text = "MÜKEMMEL!";
                }

                can_ekle();

                dusman_2.Top = -900;
                int ranP = rnd.Next(1, 400);
                dusman_2.Left = ranP;
                mermiHiz = 0;
                Mermi.Top = -100;
                Mermi.Left = -100;
            }
            else if (Mermi.Bounds.IntersectsWith(dusman_3.Bounds))
            {
                int ucde_biri;
                ucde_biri = dusman_3.Width / 3;
                int left = dusman_3.Left;
                int right = dusman_3.Right;

                lbl_puan.Location = Mermi.Bounds.Location;
                lbl_durum.Location = new Point(Mermi.Bounds.Location.X, Mermi.Bounds.Location.Y + 25);

                if (Mermi.Right < left + ucde_biri + mukemmel_zorluk || Mermi.Left > right - ucde_biri - mukemmel_zorluk)
                {
                    Puan += iyi_puan;
                    lbl_puan.Text = "+" + iyi_puan + " Puan";
                    lbl_durum.Text = "GÜZEL!";
                }
                else
                {
                    Puan += muk_puan;
                    lbl_puan.Text = "+" + muk_puan + " Puan";
                    lbl_durum.Text = "MÜKEMMEL!";
                }

                can_ekle();

                dusman_3.Top = -1300;
                int ranP = rnd.Next(1, 500);
                dusman_3.Left = ranP;
                mermiHiz = 0;
                Mermi.Top = -100;
                Mermi.Left = -100;
            }
        }
    }
}
