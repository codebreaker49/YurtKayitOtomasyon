using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string elektrik, su, dogalgaz, gida,internet, diger, personel,id;
        SqlBaglantim bgl = new SqlBaglantim();
        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,İnternet=@p4,Gıda=@p5,Personel=@p6,Diger=@p7 where Odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", txtGiderid.Text);
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", txtInternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGida.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu! Yeniden Deneyiniz");
            }
        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtGiderid.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalGaz.Text = dogalgaz;
            txtGida.Text = gida;
            txtInternet.Text = internet;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
        }
    }
}
