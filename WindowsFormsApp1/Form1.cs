using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=StokTakip;Integrated Security=True");
        public string kad { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string komut = "select * from WebUser where (UserName = '" + txtAd.Text + "' and Pass ='"+textBox1.Text+"' )";
            SqlCommand islem = new SqlCommand(komut, baglanti);
            SqlDataReader oku = islem.ExecuteReader();

            if (txtAd.Text != "" && textBox1.Text !="")
            {
               
                if (oku.Read())
                {
                    baglanti.Close();
                    MessageBox.Show("Sisteme Hoşgeldiniz Sayın " + txtAd.Text, "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 frm = new Form2();

                    baglanti.Open();
                    string kod = "Select UserName From WebUser where UserName='" + txtAd.Text + "'";
                    SqlCommand komut2 = new SqlCommand(kod, baglanti);
                    SqlDataReader reading = komut2.ExecuteReader();
                    while (reading.Read())
                    {
                        frm.KullaniciAd = kad;

                        kad = reading[0].ToString();
                        break;
                    }
                    baglanti.Close();
                    this.Hide();
                    frm.Show();



                }
                else
                {
                    MessageBox.Show("Sisteme Kayıtlı Kullanıcı Bulunamadı Lütfen Tekrar Deneyiniz.", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Boş Olamaz", "Stok Takip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
