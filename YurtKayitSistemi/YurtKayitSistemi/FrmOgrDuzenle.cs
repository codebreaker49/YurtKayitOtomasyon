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

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, TC, ogrtel, ogrdogum, ogrbolum, ogrmail, ogrodano, ogrveliadsoyad,ogrvelitel,ogradres;

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci Silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", txtOgrID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //Odanın Aktif Öğrenci Kontenjanını Azaltma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", txtOgrID.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTel=@p11,OgrVelAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrID.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskOgrTC.Text);
                komut.Parameters.AddWithValue("@p5", mskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskOgrDogTar.Text);
                komut.Parameters.AddWithValue("@p7", cmbOgrenciBolumu.Text);
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTel.Text);
                komut.Parameters.AddWithValue("@p12", rchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");  
            }
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrID.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskOgrTC.Text = TC;
            mskOgrTelefon.Text = ogrtel;
            mskOgrDogTar.Text = ogrdogum;
            cmbOgrenciBolumu.Text = ogrbolum;
            txtMail.Text = ogrmail;
            cmbOdaNo.Text = ogrodano;
            txtVeliAdSoyad.Text = ogrveliadsoyad;
            mskVeliTel.Text = ogrvelitel;
            rchAdres.Text = ogradres;
        }
    }
}
