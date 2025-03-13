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
    public partial class FrmOgrKayıt : Form
    {
        public FrmOgrKayıt()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOgrKayıt_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme Komutları
            SqlCommand komut = new SqlCommand("Select Bölümad from Bölümler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOgrenciBolumu.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş Odaları Listeleme Komutları
            SqlCommand komut2 = new SqlCommand("Select Odano from Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerinin Kayıt Edilme Komutları
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTel,OgrVelAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtOgrenciAdi.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtOgrenciSoyadi.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskOgrTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskOgrDogTar.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbOgrenciBolumu.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskVeliTel.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");

                //Öğrenci id Labele Çekme Komutları
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtOgrenciAdi.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtOgrenciSoyadi.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!! Lütfen Yeniden Deneyin");
            }

            //Öğrenci Oda Kontenjanı Azaltma
            SqlCommand komutoda= new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
