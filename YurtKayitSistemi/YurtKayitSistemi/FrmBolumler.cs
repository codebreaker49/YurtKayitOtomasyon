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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtOtomasyonDataSet.Bölümler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bölümlerTableAdapter.Fill(this.yurtKayıtOtomasyonDataSet.Bölümler);

        }

        private void pcbEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("insert into Bölümler(Bölümad) values (@p1)",bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm eklendi");
                this.bölümlerTableAdapter.Fill(this.yurtKayıtOtomasyonDataSet.Bölümler);
            }
            catch
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin");
            }
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from Bölümler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi");
                this.bölümlerTableAdapter.Fill(this.yurtKayıtOtomasyonDataSet.Bölümler);
            }
            catch(Exception)
            {
                MessageBox.Show("Hata, İşlem Gerçekleşmedi");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumID.Text = id;
            txtBolumAd.Text = bolumad;
        }

        private void pcbDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut3 = new SqlCommand("update Bölümler set Bölümad=@p1 where Bolumid=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", txtBolumID.Text);
                komut3.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı");
                this.bölümlerTableAdapter.Fill(this.yurtKayıtOtomasyonDataSet.Bölümler);
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
