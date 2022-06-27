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

namespace P_Hospital
{
    public partial class Doktor_Detay : Form
    {
        public Doktor_Detay()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string TC;

        private void Doktor_Detay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TC;

            //Ad - Soyad Çekme
            SqlCommand kmt = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorTC=@d1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@d1", lbltc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Listesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu where RandevuDoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Doktor_BilgiDuzenle dbg = new Doktor_BilgiDuzenle();
            dbg.tcno = lbltc.Text;
            dbg.Show();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            Doktor_Duyuru dd = new Doktor_Duyuru();
            dd.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            Doktor_Giris fr = new Doktor_Giris();
            fr.Show();
            this.Hide();
        }
    }
}
