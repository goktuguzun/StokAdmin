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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=StokTakip;Integrated Security=True");

        public string KullaniciAd { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = 0;
            label1.Text = "3. Organize Merkez";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           label1.Text=comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text== "3. Organize Merkez")
            {
                MessageBox.Show("3. Organize Merkez");
            }
            else if (label1.Text== "3. Organize Ticari Araç")
            {
                MessageBox.Show("3. Organize Ticari Araç");

            }
            else if (label1.Text== "5. Organize Balata-Disk")
            {
                MessageBox.Show("5. Organize Balata-Disk");
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Şube Seçiniz.");

            }
        }
    }
}
