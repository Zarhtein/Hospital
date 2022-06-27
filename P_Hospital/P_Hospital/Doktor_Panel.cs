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
    public partial class Doktor_Panel : Form
    {
        public Doktor_Panel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void Doktor_Panel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1= new SqlDataAdapter("Select * From Tbl_Doktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branşları ComboBox Aktarma
            SqlCommand kmt = new SqlCommand ("Select BransAd From Tbl_Brans",bgl.baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand("insert into Tbl_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            kmt1.Parameters.AddWithValue("@d1", txtad.Text);
            kmt1.Parameters.AddWithValue("@d2", txtsoyad.Text);
            kmt1.Parameters.AddWithValue("@d3", cmbbrans.Text);
            kmt1.Parameters.AddWithValue("@d4", mskdtc.Text);
            kmt1.Parameters.AddWithValue("@d5", txtsifre.Text);
            kmt1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdtc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("Delete From Tbl_Doktor where DoktorTC=@d1", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@d1", mskdtc.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi :(", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("Update Tbl_Doktor set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d4 where DoktorTC=@d5", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@d1", txtad.Text);
            kmt3.Parameters.AddWithValue("@d2", txtsoyad.Text);
            kmt3.Parameters.AddWithValue("@d3", cmbbrans.Text);
            kmt3.Parameters.AddWithValue("@d4", txtsifre.Text);
            kmt3.Parameters.AddWithValue("@d5", mskdtc.Text);
            kmt3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
