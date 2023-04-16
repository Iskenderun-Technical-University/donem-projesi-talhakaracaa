using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KaracaHoldingPersonelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Veritabanı Dosya yolu
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=KaracaHoldingPersonel.accdb");

        // Formlar Arası Değişkenler 

        public static string tcno, adi, soyadi, yetki;

        // Yerel Değişkenler 

        int hak = 3;bool durum =false;
         

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " Kullanıcı Girişi";
            this.AcceptButton = button1;
            this.CancelButton = button2;
            label5.Text = Convert.ToString(hak);
            radioButton1.Checked = true; 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;


        }
    }
}
