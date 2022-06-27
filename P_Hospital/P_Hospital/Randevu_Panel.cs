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
    public partial class Randevu_Panel : Form
    {
        public Randevu_Panel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void Randevu_Panel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //Değerleri başka forma yükleyip güncellemek
        public Sekreter_Detay frm1;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            frm1.txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm1.mskdtarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm1.mskdsaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm1.cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm1.cmbdoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm1.chkdurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm1.mskdtc.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();    
        }
    }
}
