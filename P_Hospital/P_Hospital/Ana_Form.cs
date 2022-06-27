using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Hospital
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnhasgiris_Click(object sender, EventArgs e)
        {
            Hasta_Giris hgiris = new Hasta_Giris();
            hgiris.Show();
            this.Hide();
        }

        private void btndokgiris_Click(object sender, EventArgs e)
        {
            Doktor_Giris dgiris = new Doktor_Giris();
            dgiris.Show();
            this.Hide();
        }

        private void btnsekgiris_Click(object sender, EventArgs e)
        {
            Sekreter_Giris sgiris = new Sekreter_Giris();
            sgiris.Show();
            this.Hide();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
