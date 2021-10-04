using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inicio_RC
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Add(textBox3.Text);
            }
            {
                listBox1.Items.Add(DateTime.Now.Date.ToShortDateString());
                listBox1.Items.Add(DateTime.Now.TimeOfDay.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox3.Text = (" ");
        }
    }
}
