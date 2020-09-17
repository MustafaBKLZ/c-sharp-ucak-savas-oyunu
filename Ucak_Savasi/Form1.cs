using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ucak_Savasi
{
    public partial class Form1 : Form
    {
        int PlayerHareketHizi = 0, DusmanUcakHareketHiz = 3, MermiHiz = 8, Can = 5, Puan = 0, MukemmelZorluk = 20, Iyi_Puan = 10, MukemmelPuan = 50, EkCan = 1, PatlamaKacTick = 100;
        PictureBox dusman, mermi;

        // Can gösterge PictureBox nesnesini dinamik üretmek için...
        private PictureBox p_can()
        {
            PictureBox p_can = new PictureBox();
            p_can.Image = global::Ucak_Savasi.Properties.Resources.can;
            p_can.SizeMode = PictureBoxSizeMode.StretchImage;
            p_can.Size = new Size(20, 20);
            return p_can;
        }

        // Mermi PictureBox nesnesini dinamik üretmek için...
        PictureBox Mermi = new PictureBox();
        private PictureBox p_mermi()
        {
            Mermi = new PictureBox();
            Mermi.Name = "mermi";
            Mermi.Image = global::Ucak_Savasi.Properties.Resources.ates;
            Mermi.SizeMode = PictureBoxSizeMode.StretchImage;
            Mermi.Size = new Size(20, 20);
            savas_alani.Controls.Add(Mermi);
            Mermi.Location = new Point(0, 0);
            return Mermi;
        }

        // Düşman PictureBox nesnesini dinamik üretmek için...
        PictureBox Dusman = new PictureBox();
        private PictureBox p_dusman()
        {
            Dusman = new PictureBox();
            Dusman.Name = "dusman";
            Dusman.Image = global::Ucak_Savasi.Properties.Resources.dusman1;
            Dusman.SizeMode = PictureBoxSizeMode.StretchImage;
            Dusman.Size = new Size(100, 84);
            savas_alani.Controls.Add(Dusman);
            // Her üretilen düşman uçağı formun dışından random koordinatlarda başlayacak
            Random rnd_X = new Random();
            Dusman.Left = rnd_X.Next(20, 480);
            Random rnd_Y = new Random();
            Dusman.Top = rnd_Y.Next(100, 1500) * -1;
            return Dusman;
        }


        public Form1()
        {
            InitializeComponent();
            lbl_durum.Top = -100;
            lbl_puan.Top = -100;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                flowLayoutPanel1.Controls.Add(p_can());

            ortaToolStripMenuItem.Checked = true; // orta zorlukla başladık
            rad_orta.Checked = true;
            patlama.Location = new Point(-100, -100);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point SolSinir = new Point(0, 555);
            Point SagSinir = new Point(540, 555);


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
                if (player.Location.X < SolSinir.X) //eğer çok fazla gidipte formdan çıkarsa
                    player.Location = SagSinir;//  X (yatay) koordinatta soldan formdan çıkarsa formun sağından tarafıgeri gelsin.

                PlayerHareketHizi = -10; // from sınırlarını aşmıyorsa -10 yani sola gitsin
            }
            else if (e.KeyCode == Keys.Right)// sağ oka bastığmızda sağa gidecek
            {
                if (player.Location.X > SagSinir.X)//eğer çok fazla gidipte formdan çıkarsa
                    player.Location = SolSinir; //   X (yatay) koordinatta sağından formdan çıkarsa formun solundan tarafıgeri gelsin.

                PlayerHareketHizi = 10;// from sınırlarını aşmıyorsa +10 yani sağa gitsin
            }
            else if (e.KeyCode == Keys.Space) // boşluk tuşu ateş eder.
            {
                p_mermi(); // her space tuşu ile dinamik olarak bir mermi ürettik
                foreach (Control item in savas_alani.Controls)
                {
                    if (item.Name.Contains("mermi"))
                    {
                        MermiHiz = 1; // merminin hızı
                        Mermi.Left = player.Left + 40; // mersinin görsel olarak çıkacağı yer. Uçağın ortasından; 
                        Mermi.Top = player.Top; // mersinin görsel olarak çıkacağı yer. Uçağın ucundan;
                        //Mermi = (PictureBox)item;
                    }
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // sol ok tuşuna artık basılmıyorsa hızı kes
            {
                PlayerHareketHizi = 0;
            }
            else if (e.KeyCode == Keys.Right) // sağ ok tuşuna artık basılmıyorsa hızı kes
            {
                PlayerHareketHizi = 0;
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            // NOT: Timer1'in İnterval'i 10'dur. Tuşlar saniyede 100 defa kontrol ediliyor

            player.Left += PlayerHareketHizi; // oyuncu uçağının koordinatını, tuşa basılı olduğu sürece değiştir.
            lblsonuc.Text = "" + Puan; // puanı yazdık
            if (Can > 0) // canlarımız tükenmediyse...
            {
                foreach (Control item in savas_alani.Controls) // savaş alanındaki nesneleri kontrol ediyoruz
                {
                    if (item.Name.Contains("dusman")) // eğer düşman adında bir nesne var ise
                    {
                        item.Top += DusmanUcakHareketHiz; // düşman uçaklarının hareketi sağlanıyor. 

                        if (item.Bottom >= player.Top + player.Height / 2)
                        // düşman uçağının alt çizgisi, player'in yarısına kadar gelmiş ise
                        {
                            if ((item.Right > player.Left && item.Right < player.Right) || (item.Left > player.Left && item.Left < player.Right))
                            // Düşman uçağının sağ çizgisi; player uçağının sol çizgisininden içeri girmişse yada player uçağının sağ çizgisininden içeri girmiş ise 
                            // Yani düşman uçağının sağ çizgisi ya da sol çizgisi, player uçağınına değmiş ise
                            // Yani bir çarpışma var ise
                            {
                                Random rnd_Y = new Random();
                                item.Top = rnd_Y.Next(100, 3000) * -1;
                                Can--;
                                canlar();
                            }
                            if (item.Bottom >= 630)
                            // eğer düşman uçak player uçağa çarpmamış ama onu geçmiş gitmiş ise..
                            {
                                Random rnd_Y = new Random();
                                item.Top = rnd_Y.Next(100, 3000) * -1;
                                Can--;
                                canlar();
                            }
                        }
                        Vurulma(); // düşman uçağı vurma
                    }
                }
            }
            else
            {
                oyunSonu(); // can biterse oyun biter
            }

            foreach (Control item in savas_alani.Controls)
            {
                if (item.Name.Contains("mermi"))
                {
                    MermiHiz = 10; // merminin hızı
                    item.Top -= MermiHiz;
                }
            }

            // labeller çarpışma noktasına giderek ve yukarı doğru çıkarak kaybolacak.
            lbl_puan.Top -= 5;
            lbl_durum.Top -= 5;
            PatlamaKacTick--;
        }


        private void basla()
        {
            foreach (Control item in savas_alani.Controls) // savaş alanında kalan uçak ver mermiler kaldırılsın.
            {
                if (item.Name.Contains("dusman")) savas_alani.Controls.Remove(item);
                if (item.Name.Contains("mermi")) savas_alani.Controls.Remove(item);
            }
            Can = 5;
            p_dusman();// bir düşman ekledik
            p_mermi(); // bir mermi ekledik
            player.Location = new Point(250, 550);//formun ortasından başlasın.

            kolayToolStripMenuItem.Enabled = false;
            ortaToolStripMenuItem.Enabled = false;
            zorlukToolStripMenuItem.Enabled = false;
            oyunaBaşlaToolStripMenuItem.Enabled = false;
            oyunuBitirToolStripMenuItem.Enabled = true;

            // seçilen zorluğa göre düşman uçaklarının hızını ayarlıyoruz.
            if (kolayToolStripMenuItem.Checked == true) DusmanUcakHareketHiz = 3;
            if (ortaToolStripMenuItem.Checked == true) DusmanUcakHareketHiz = 5;
            if (zorlukToolStripMenuItem.Checked == true) DusmanUcakHareketHiz = 7;

            panel1.Enabled = false;
            timer1.Start();
        }
        private void oyunSonu()
        {
            // oyun biter, bildirimverişir herşey sıfırlanır
            timer1.Stop();
            timer1.Enabled = false;
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
        private void canlar()
        {
            // canların azalması ve kalplerin kaybolması
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < Can; i++)
            {
                this.flowLayoutPanel1.Controls.Add(p_can());
            }
        }
        private void can_ekle()
        {
            //kazanılan puanlara göre can ekleme işlemi. Sadece 5 kere can alınabilir. Şimdilik
            if (Puan > 100 && EkCan == 1)
            {
                Can++; EkCan = 2; canlar();
            }
            if (Puan > 200 && EkCan == 2)
            {
                Can++; EkCan = 3; canlar();
            }
            if (Puan > 300 && EkCan == 3)
            {
                Can++; EkCan = 4; canlar();
            }
            if (Puan > 400 && EkCan == 4)
            {
                Can++; EkCan = 5; canlar();
            }
            if (Puan > 500 && EkCan == 5)
            {
                Can++; EkCan = 6; canlar();
            }
        }
        private void Vurulma()
        {
            if (PatlamaKacTick == 0)
            {
                PatlamaKacTick = 100;
                patlama.Location = new Point(-100, -100);
            }

            // vurulma işlemleri
            // düşman ve merminin kaybolması, puan ve durum labellerinin görünmesi.
            foreach (Control item_dusman in savas_alani.Controls) // savaş alanıdaki nesnelerin kontrolü
            {
                if (item_dusman.Name.Contains("dusman")) // bulunan nesnenin adı dusman ise
                {
                    dusman = (PictureBox)item_dusman; // Controls olarak elde ettiğimiz için picturebox'a dönüştürdük.

                    foreach (Control item_mermi in savas_alani.Controls) // savaş alanıdaki nesnelerin kontrolü
                    {
                        //Her dusman için formdaki tüm mermileri kontrol etmiş oluyoruz.
                        if (item_mermi.Name.Contains("mermi"))// bulunan nesnenin adı mermi ise
                        {
                            mermi = (PictureBox)item_mermi; // Controls olarak elde ettiğimiz için picturebox'a dönüştürdük.

                            if (mermi.Bounds.IntersectsWith(dusman.Bounds)) // mermi düşman uçak 1 e değdi ise
                            {
                                // eğer mermi, düşman uçaklrının tam ortasına değdi ise 2 puan, kanatlarına değdi ise 1 puan verilecek.
                                // Bu sebeple merminin nereye değdiğini bulmamaız gerekiyor.
                                int ucde_biri = dusman.Width / 3;
                                int left = dusman.Left;
                                int right = dusman.Right;

                                // burada amacımız puan ve durum labelleri ateş ile uçağın çarpışma noktasına gidip oradan 
                                // yukarı çıkarak kaybolması

                                lbl_puan.Location = mermi.Bounds.Location;
                                lbl_durum.Location = new Point(mermi.Bounds.Location.X, mermi.Bounds.Location.Y + 25);
                                patlama.Location = new Point(mermi.Bounds.Location.X - 30, mermi.Bounds.Location.Y - 50);

                                // mükemmel puanın aralığını parametrik olarak azalttık.
                                // bu sayede burada istersek, seçilen zorluğua göre mükemmeli de zorlaştırabiliriz.
                                if (mermi.Right < left + ucde_biri + MukemmelZorluk || mermi.Left > right - ucde_biri - MukemmelZorluk)
                                {
                                    Puan += Iyi_Puan;
                                    lbl_puan.Text = "+" + Iyi_Puan + " Puan";
                                    lbl_durum.Text = "GÜZEL!";
                                }
                                else
                                {
                                    Puan += MukemmelPuan;
                                    lbl_puan.Text = "+" + MukemmelPuan + " Puan";
                                    lbl_durum.Text = "MÜKEMMEL!";
                                }

                                can_ekle(); // puanve can kontrol edilior
                                savas_alani.Controls.Remove(dusman); // vurulan uçak formdan silinir
                                p_dusman(); // yeni düşman eklenir.

                                // Mermi sıfırlanır.
                                MermiHiz = 0;
                                mermi.Top = -100;
                                mermi.Left = -100;
                            }
                        }
                    }
                }
            }
        }
    }
}
