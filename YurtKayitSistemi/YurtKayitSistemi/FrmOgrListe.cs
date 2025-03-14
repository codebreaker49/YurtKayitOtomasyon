﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmOgrListe : Form
    {
        public FrmOgrListe()
        {
            InitializeComponent();
        }

        private void FrmOgrListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtOtomasyonDataSet4.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtKayıtOtomasyonDataSet4.Ogrenci);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.ogrtel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.ogrdogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.ogrbolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.ogrmail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.ogrodano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.ogrveliadsoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.ogrvelitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.ogradres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
