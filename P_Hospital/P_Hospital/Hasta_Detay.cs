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
    public partial class Hasta_Detay : Form
    {
        public Hasta_Detay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglanti bgl = new sqlbaglanti();

        private void Hasta_Detay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            //Ad - Soyad Çekme
            SqlCommand kmt = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hasta where HastaTC=@t1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@t1", lbltc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Randevu where HastaTCC=" + tc, bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branş Çekme
            SqlCommand kmt2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand kmt3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorBrans=@b1", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@b1", cmbbrans.Text);
            SqlDataReader dr3 = kmt3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu where RandevuBrans='" + cmbbrans.Text + "'" + "and RandevuDoktor='" + cmbdoktor.Text + "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkdüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta_BilgiDuzenle hduzenle = new Hasta_BilgiDuzenle();
            hduzenle.tcno = lbltc.Text;
            hduzenle.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            txtrndvid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update Tbl_Randevu set RandevuDurum=1,HastaTCc=@p1,HastaSikayet=@p2 where RandevuId=@p3", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", lbltc.Text);
            kmt.Parameters.AddWithValue("@p2", rchsikayet.Text);
            kmt.Parameters.AddWithValue("@p3", txtrndvid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            Hasta_Giris fr = new Hasta_Giris();
            fr.Show();
            this.Hide();
        }
    }
}
