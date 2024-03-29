using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiyarıimasiprojesi
{
    public partial class bilgiyarimasi : Form
    {
        public bilgiyarimasi()
        {
            InitializeComponent();
        }

        int dogru = 0, yanlis = 0,soru=0;
       
        private void btnbasla_Click(object sender, EventArgs e)
        {

            
            btnbasla.Enabled = false;
           

            soru++;

            richTextBox1.Text = "10.08.2023 güncel tarihi ile dünyadaki en popüler programlama dili hangisidir?";
            btnA.Text = "C++";
            btnB.Text = "C";
            btnC.Text = "Python";
            btnD.Text = "Java";
            dogrucevap.Text = btnC.Text;
           
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbasla.Enabled = false;
            btnsonraki.Enabled = true;


            verilencevap.Text = btnB.Text;
            if (verilencevap.Text == dogrucevap.Text)
            {
                greenpic.Visible = true;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                redpic.Visible = true;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();

            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbasla.Enabled = false;
            btnsonraki.Enabled = true;


            verilencevap.Text = btnC.Text;
            if (verilencevap.Text == dogrucevap.Text)
            {
                greenpic.Visible = true;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                redpic.Visible = true;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbasla.Enabled = false;
            btnsonraki.Enabled = true;


            verilencevap.Text = btnD.Text;
            if (verilencevap.Text == dogrucevap.Text)
            {
                greenpic.Visible = true;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                redpic.Visible = true;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();

            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnbasla.Enabled = false;
            btnsonraki.Enabled = true;

            verilencevap.Text = btnA.Text;
            if (verilencevap.Text == dogrucevap.Text)
            {
                greenpic.Visible = true;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                redpic.Visible = true;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();

            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            soru++;
            lblsoru.Text = soru.ToString();

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnbasla.Enabled = false;
            greenpic.Visible = false;
            redpic.Visible = false;
            btnsonraki.Enabled = false;
            if (soru == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi web programlama için öğrenilmesi gerekmez?";
                btnA.Text = "HTML";
                btnB.Text = "CSS";
                btnC.Text = "Java";
                btnD.Text = "JavaScript";
                dogrucevap.Text = btnC.Text;
            }
            if (soru == 3)
            {
                richTextBox1.Text = "Romen Rakamında Hangi Sayı Yoktur?";
                btnA.Text = "0";
                btnB.Text = "50";
                btnC.Text = "100";
                btnD.Text = "1000";
                dogrucevap.Text = btnA.Text;
            }
            if (soru == 4)
            {
                richTextBox1.Text = "Aspirinin Hammaddesi Nedir?";
                btnA.Text = "Söğüt";
                btnB.Text = "Köknar";
                btnC.Text = "Kavak ";
                btnD.Text = "Gürgen";
                dogrucevap.Text = btnA.Text;
            }
            if (soru == 5)
            {
                richTextBox1.Text = "Bayrağında çift başlı kartal figürü bulunan Türk devleti hangisidir?";
                btnA.Text = "Avrupa Hun";
                btnB.Text = "Büyük Selçuklu";
                btnC.Text = "Altın Orda";
                btnD.Text = "Ak hun";
                dogrucevap.Text = btnB.Text;
            }
            if (soru == 6)
            {
                richTextBox1.Text = "Türk halk ozanı ve şairi olan Aşık Veysel'in soyadı nedir?";
                btnA.Text = "Şatıroğlu";
                btnB.Text = "Şakıroğlu";
                btnC.Text = "Çakıroğlu";
                btnD.Text = "Şadıroğlu";
                dogrucevap.Text = btnA.Text;
            }
            if (soru == 7)
            {
                richTextBox1.Text = "Küçük Prens kitabının yazarı kimdir?";
                btnA.Text = "Victor Hugo";
                btnB.Text = "Antoine de Snait-Exupery";
                btnC.Text = "Charles Baudelaire";
                btnD.Text = "Pierre Corneille";
                dogrucevap.Text = btnB.Text;
            }
            if (soru == 8)
            {
                richTextBox1.Text = "Rüzgarı takip et;ama arkanı kolla sözü kime aiitir?";
                btnA.Text = "Sokrates";
                btnB.Text = "Kaisa";
                btnC.Text = "Heimnderiger";
                btnD.Text = "Yasuo";
                dogrucevap.Text = btnD.Text;
            }
            if (soru == 9)
            {
                richTextBox1.Text = "En çok takip edilen lol yayınının spikerleri tarafından 'Dünyanın gelmiş geçmiş en iyi  mechanics oyuncusu olarak övülen eski IG profosyonel e-sporcusu kimdir?";
                btnA.Text = "Oner";
                btnB.Text = "Faker";
                btnC.Text = "Theshy";
                btnD.Text = "Viper";
                dogrucevap.Text = btnC.Text;
            }
            if (soru == 10)
            {
                richTextBox1.Text = "Uşak ili hangi bölgededir?";
                btnA.Text = "Ege bölgesi";
                btnB.Text = "Marmara bölgesi";
                btnC.Text = "Akdeniz bölgesi";
                btnD.Text = "Karadeniz bölgesi";
                dogrucevap.Text = btnA.Text;
               
                
            }
            if (soru == 11)
            {
                btnsonraki.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                if (dogru>=0 && dogru <= 4)
                {
                    MessageBox.Show("Ortalama bir insansınız :)");
                }
                if (dogru >= 5 && dogru <= 7)
                {
                    MessageBox.Show("Yüksek zeka ve kültür seviyesine saip bir insansınız :)");
                }
                if (dogru >= 8 && dogru <= 10)
                {
                    MessageBox.Show("İnanılmaz bir başarı, gerçekten takdire şayan!!!!!!");
                }

            }
            


        }
    }
}
