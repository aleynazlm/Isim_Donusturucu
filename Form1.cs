using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorselProgramlamaProje
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        static Random random = new Random();
        string kullanici_adi;
        string harf;

        public object FontDialog1 { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cb_font.Items.Add(font.Name.ToString());
            }
        }

        private void btn_uygula_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string baslangic;
            string bitis;

            kullanici_adi = "";

            do
            {
                int sayi_adb = random.Next(ad.Length - 1);
                int sayi_ads = random.Next(ad.Length - sayi_adb + 1);

                int sayi_soyadb = random.Next(soyad.Length - 1);
                int sayi_soyads = random.Next(soyad.Length - sayi_soyadb + 1);

                baslangic = ad.Substring(sayi_adb, sayi_ads);
                bitis = soyad.Substring(sayi_soyadb, sayi_soyads);
                kullanici_adi += baslangic + bitis;
            } while (kullanici_adi.Length < 5);

            if (Int32.TryParse(textBox3.Text, out int eklenecekSayi))
            {
                if (radioButton4.Checked)
                    kullanici_adi = textBox3.Text + kullanici_adi;
                else if (radioButton5.Checked)
                    kullanici_adi += textBox3.Text;
            }

            label9.Text = kullanici_adi;

            epostaGetir();
        }

        private void epostaGetir()
        {
            if (radioButton1.Checked)
            {
                label7.Text = kullanici_adi + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                label7.Text = kullanici_adi + radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                label7.Text = kullanici_adi + radioButton3.Text;
            }
        }

        private void btn_morsalfabe_Click(object sender, EventArgs e)
        {
            if(kullanici_adi != null)
            {
            char[] harfler = kullanici_adi.ToCharArray();
            string kullaniciMors = "";

            foreach (char h in harfler)
            {
                switch (h)
                {
                    case 'A':
                    case 'a':
                        harf = ".-";
                        break;

                    case 'B':
                    case 'b':
                        harf = "-...";
                        break;

                    case 'C':
                    case 'c':
                        harf = "-.-.";
                        break;

                    case 'Ç':
                    case 'ç':
                        harf = "-.-..";
                        break;

                    case 'D':
                    case 'd':
                        harf = "-..";
                        break;

                    case 'E':
                    case 'e':
                        harf = ".";
                        break;

                    case 'F':
                    case 'f':
                        harf = "..-.";
                        break;

                    case 'G':
                    case 'g':
                        harf = "--.";
                        break;

                    case 'Ğ':
                    case 'ğ':
                        harf = "--.-.";
                        break;

                    case 'H':
                    case 'h':
                        harf = "....";
                        break;

                    case 'I':
                    case 'ı':
                        harf = "..";
                        break;

                    case 'İ':
                    case 'i':
                        harf = ".-..-";
                        break;

                    case 'J':
                    case 'j':
                        harf = ".---";
                        break;

                    case 'K':
                    case 'k':
                        harf = "-.-";
                        break;

                    case 'L':
                    case 'l':
                        harf = ".-..";
                        break;

                    case 'M':
                    case 'm':
                        harf = "--";
                        break;

                    case 'N':
                    case 'n':
                        harf = "-.";
                        break;

                    case 'O':
                    case 'o':
                        harf = "---";
                        break;

                    case 'Ö':
                    case 'ö':
                        harf = "---.";
                        break;

                    case 'P':
                    case 'p':
                        harf = ".--.";
                        break;

                    case 'Q':
                    case 'q':
                        harf = "--.-";
                        break;

                    case 'R':
                    case 'r':
                        harf = ".-.";
                        break;

                    case 'S':
                    case 's':
                        harf = "...";
                        break;

                    case 'Ş':
                    case 'ş':
                        harf = ".--..";
                        break;

                    case 'T':
                    case 't':
                        harf = "-";
                        break;

                    case 'U':
                    case 'u':
                        harf = "..-";
                        break;

                    case 'Ü':
                    case 'ü':
                        harf = "..--";
                        break;

                    case 'V':
                    case 'v':
                        harf = "...-";
                        break;

                    case 'W':
                    case 'w':
                        harf = ".--";
                        break;

                    case 'X':
                    case 'x':
                        harf = "-..-";
                        break;

                    case 'Y':
                    case 'y':
                        harf = "-.--";
                        break;

                    case 'Z':
                    case 'z':
                        harf = "--..";
                        break;

                    case '1':
                        harf = ".----";
                        break;

                    case '2':
                        harf = "..---";
                        break;

                    case '3':
                        harf = "...--";
                        break;

                    case '4':
                        harf = "....-";
                        break;

                    case '5':
                        harf = ".....";
                        break;

                    case '6':
                        harf = "-....";
                        break;

                    case '7':
                        harf = "--...";
                        break;

                    case '8':
                        harf = "---..";
                        break;

                    case '9':
                        harf = "----.";
                        break;

                    case '0':
                        harf = "-----";
                        break;

                    default:
                        textBox8.Text = "Kullanıcı adını dönüştürülemiyor";
                        break;
                }
                kullaniciMors = kullaniciMors + " " + harf;
                textBox8.Text = kullaniciMors;
            }

            }

        }

        private void btn_bykharf_Click(object sender, EventArgs e)
        {
            label9.Text = kullanici_adi.ToUpper();
        }

        private void btn_kckharf_Click(object sender, EventArgs e)
        {
            label9.Text = kullanici_adi.ToLower();
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            string degistirilecek = textBox4.Text;
            string degistirilen = textBox5.Text;

            kullanici_adi = kullanici_adi.Replace(degistirilecek, degistirilen);
            label9.Text = kullanici_adi;

            epostaGetir();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string degistirilecek = textBox6.Text;
            kullanici_adi = kullanici_adi.Replace(degistirilecek, "");
            label9.Text = kullanici_adi;
            epostaGetir();

        }

        private void cb_font_SelectedIndexChanged(object sender, EventArgs e)
        {

            label9.Font = new Font(cb_font.Text,label9.Font.Size);
        }

        
    }
}
