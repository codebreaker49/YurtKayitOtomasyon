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
    public partial class frmGelirIstatistik : Form
    {
        public frmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void frmGelirIstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Tutar
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblPara.Text = oku[0].ToString() + " TL" ;
            }
            bgl.baglanti().Close();

            //Tekrarsız Olarak Ayları Listeleme
            SqlCommand komut2 = new SqlCommand("Select distinct(OdenenAy) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAySec.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            //Grafiklere veritabanından veri çekme
            SqlCommand komut3 = new SqlCommand("select OdenenAy, sum(OdemeMiktar) from Kasa group by OdenenAy", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbAySec_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen Aya Göre Kazancı Listeleme
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from Kasa Where OdenenAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAySec.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblSecilenAy.Text=oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
