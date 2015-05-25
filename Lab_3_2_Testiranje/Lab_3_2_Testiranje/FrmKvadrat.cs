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
    public partial class FrmKvadrat : Form
    {
        public FrmKvadrat()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float stranicaA = float.Parse(txtStranicaA.Text);
            float dijagonala = 0;
            float povrsina = 0;
            float opseg = 0;

            Kvadrat k = new Kvadrat(stranicaA);
            dijagonala = k.IzracunajDijagonalu();
            povrsina = k.IzracunajPovrsinu();
            opseg = k.IzracunajOpseg();

            txtDijagonala.Text = dijagonala.ToString();
            txtPovrsina.Text = povrsina.ToString();
            txtOpseg.Text = opseg.ToString();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
