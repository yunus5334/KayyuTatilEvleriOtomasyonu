using KayyuTatilEvleri.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayyuTatilEvleri
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        TatilEviContext db = new TatilEviContext();
        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Rezervasyon.ToList();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            Rezervasyon ekle = new Rezervasyon();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAnasayfa fmanasayfa = new frmAnasayfa();
            this.Hide();
            fmanasayfa.Show();
        }
    }
}
