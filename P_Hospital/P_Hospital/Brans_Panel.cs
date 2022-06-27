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
    public partial class Brans_Panel : Form
    {
        public Brans_Panel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void Brans_Panel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into Tbl_Brans (BransAd) values (@b1)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@b1", txtad.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Oluşturuldu :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("Delete From Tbl_Brans where BransId=@b2", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@b2", txtid.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi :(", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("Update Tbl_Brans set BransAd=@b3 where BransId=@b4", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@b3", txtad.Text);
            kmt3.Parameters.AddWithValue("@b4", txtid.Text);
            kmt3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
