using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Using System.Oledb kütüphanesinin tanımlanması
using System.Data.OleDb;
// System.Text.RegularExpression (Regex) kütüphanesinin tanımlanması
using System.Text.RegularExpressions;
//Giriş-Çıkış işlemlerine ilişkin kütüphanenin tanımlanması
using System.IO;


namespace KaracaHoldingPersonelTakibi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Veritabanı dosya yolu ve provider nesnesinin belirlenmesi 
        OleDbConnection baglantim = new OleDbConnection("provider=Microsoft.Ace.OleDb.12.0;Data Source=PersonelBilgileri.accdb");
        private void kullanicilari_goster()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select tcno AS [TC KİMLİK NO],Ad AS [ADI],soyad AS [SOYADI],kullaniciadi AS [KULLANICI ADI],parola AS [PAROLA],yetki AS [YETKİ] FROM kullanicilar Order By ad ASC", baglantim);
                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglantim.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "KARACA Holding Personel Takip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kullanicilari_goster();
        }
    }
}
