using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_RC
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulario f2 = new Formulario();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComunicaUDP f3 = new ComunicaUDP();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
