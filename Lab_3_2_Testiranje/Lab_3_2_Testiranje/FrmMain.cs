using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_2_Testiranje
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPravokutnik_Click(object sender, EventArgs e)
        {
            FrmPravokutnik forma = new FrmPravokutnik();
            forma.ShowDialog();
        }

        private void btnKvadrat_Click(object sender, EventArgs e)
        {
            FrmKvadrat forma = new FrmKvadrat();
            forma.ShowDialog();
        }
    }
}
