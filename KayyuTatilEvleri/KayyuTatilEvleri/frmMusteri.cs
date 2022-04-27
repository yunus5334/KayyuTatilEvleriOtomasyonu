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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAnasayfa fmanasayfa = new frmAnasayfa();
            this.Hide();
            fmanasayfa.Show();
        }
    }
}
