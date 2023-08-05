namespace Proje___Bilgi_Yarışması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            LblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = soruNo + "-) Hangi ünlü, Üniversite mezunudur?";
                BtnA.Text = "Tarkan Tevetoğlu";
                BtnB.Text = "Bülent Ecevit";
                BtnC.Text = "Yılmaz Erdoğan";
                BtnD.Text = "Kadir İnanır";

                label4.Text = "Kadir İnanır";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = soruNo + "-) Yedi renkten oluşan gökkuşağının ortasındaki renk hangisidir?";
                BtnA.Text = "Mavi";
                BtnB.Text = "Sarı";
                BtnC.Text = "Yeşil";
                BtnD.Text = "Kırmızı";

                label4.Text = "Yeşil";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = soruNo + "-) Son kuşlar hangi yazarımıza aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Attila İlhan";
                BtnD.Text = "Reşat Nuri";

                label4.Text = "Sait Faik";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = soruNo + "-) Ülkemiz Avrupa Birliğine tam üyelik müzakerelerine hangi yılda başlamıştır ??";
                BtnA.Text = "2000";
                BtnB.Text = "2002";
                BtnC.Text = "2003";
                BtnD.Text = "2005";

                label4.Text = "2005";
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = soruNo + "-) Her 100 yılda yere 7cm yaklaşan Pisa Kulesi hangi yöne doğru eğilmektedir?";
                BtnA.Text = "Batı";
                BtnB.Text = "Kuzey";
                BtnC.Text = "Güney";
                BtnD.Text = "Doğu";

                label4.Text = "Güney";
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = soruNo + "-) Türkiye'nin ilk hapis cezası alan ilk bilgisayar korsanı kimdir?";
                BtnA.Text = "Burak Çağlar";
                BtnB.Text = "Mahir Arabul";
                BtnC.Text = "Tolga Bilge";
                BtnD.Text = "Tamer Şahin";

                label4.Text = "Tamer Şahin";
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = soruNo + "-) Ülkemizde 'Devlet Sanatçısı'unvanını alan ilk isim kimdir?";
                BtnA.Text = "Cüneyt Gökçer";
                BtnB.Text = "Ahmet Adnan Saygun";
                BtnC.Text = "Yıldız Kenter";
                BtnD.Text = "Cemal Reşit Bey";

                label4.Text = "Ahmet Adnan Saygun";
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = soruNo + "-) Asprinin ham maddesi olan ağaç hangisidir?";
                BtnA.Text = "Sığla";
                BtnB.Text = "Söğüt";
                BtnC.Text = "Gülibrişim";
                BtnD.Text = "Çobanpüskülü";

                label4.Text = "Söğüt";
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = soruNo + "-) 100'e, 100'ün yüzde 10'u eklendiğinde çıkan sonuç 100'ün yüzde kaçı olur?";
                BtnA.Text = "Yüzde 10'u";
                BtnB.Text = "Yüzde 100'ü";
                BtnC.Text = "Yüzde 110'u";
                BtnD.Text = "Yüzde 1000'i";

                label4.Text = "Yüzde 110'u";
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = soruNo + "-) Eylül 2021'de nerede eski bir geleneği devam ettirmek için 1428 yunus öldürülmüştür?";
                BtnA.Text = "Danimarka'ya bağlı Faroe Adaları'nda";
                BtnB.Text = "Japonya'ya bağlı Ryukyu Adaları'nda";
                BtnC.Text = "Birleşik Krallık'a bağlı Falkland Adaları'nda";
                BtnD.Text = "ABD'ye bağlı Hawaii Adaları'nda";

                label4.Text = "Danimarka'ya bağlı Faroe Adaları'nda";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruNo == 11)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}