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
    public partial class Sekreter_Detay : Form
    {
        public Sekreter_Detay()
        {
            InitializeComponent();
        }
        public string tcno;

        sqlbaglanti bgl = new sqlbaglanti();

        private void Sekreter_Detay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcno;

            //Ad - Soyad Çekme
            SqlCommand kmt1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@t1", bgl.baglanti());
            kmt1.Parameters.AddWithValue("@t1", lbltc.Text);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları DataGridView Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Brans", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGridView Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans From Tbl_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşları ComboBox Aktarma
            SqlCommand kmt2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@r1", mskdtarih.Text);
            kmt3.Parameters.AddWithValue("@r2", mskdsaat.Text);
            kmt3.Parameters.AddWithValue("@r3", cmbbrans.Text);
            kmt3.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            kmt3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand kmt4 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorBrans=@d1", bgl.baglanti());
            kmt4.Parameters.AddWithValue("d1", cmbbrans.Text);
            SqlDataReader dr4 = kmt4.ExecuteReader();
            while (dr4.Read())
            {
                cmbdoktor.Items.Add(dr4[0] + " " + dr4[1]);
            }
            bgl.baglanti().Close();
        }

        private void btndyrolus_Click(object sender, EventArgs e)
        {
            SqlCommand kmt5 = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@d1)", bgl.baglanti());
            kmt5.Parameters.AddWithValue("@d1", rchduyuru.Text);
            kmt5.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndoktorpnl_Click(object sender, EventArgs e)
        {
            Doktor_Panel dp = new Doktor_Panel();
            dp.Show();
        }

        private void btnbranspnl_Click(object sender, EventArgs e)
        {
            Brans_Panel bp = new Brans_Panel();
            bp.Show();
        }
        //Değerleri başka forma yükleyip güncellemek
        private void btnliste_Click(object sender, EventArgs e)
        {
            Randevu_Panel frm2 = new Randevu_Panel();
            frm2.frm1 = this;
            frm2.Show();
        }
        //Değerleri başka forma yükleyip güncellemek
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt6 = new SqlCommand("Update Tbl_Randevu set RandevuTarih=@r1,RandevuSaat=@r2,RandevuBrans=@r3,RandevuDoktor=@r4,RandevuDurum=@r5,HastaTCC=@r6 where RandevuId=@r7", bgl.baglanti());
            kmt6.Parameters.AddWithValue("@r1", mskdtarih.Text);
            kmt6.Parameters.AddWithValue("@r2", mskdsaat.Text);
            kmt6.Parameters.AddWithValue("@r3", cmbbrans.Text);
            kmt6.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            kmt6.Parameters.AddWithValue("@r5", chkdurum.Text);
            kmt6.Parameters.AddWithValue("@r6", mskdtc.Text);
            kmt6.Parameters.AddWithValue("@r7", txtid.Text);
            kmt6.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor_Duyuru dy = new Doktor_Duyuru();
            dy.Show();
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            Sekreter_Giris fr = new Sekreter_Giris();
            fr.Show();
            this.Hide();
        }
    }
}
