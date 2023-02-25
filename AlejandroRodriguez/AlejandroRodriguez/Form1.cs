using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlejandroRodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interes i = new Interes();
            i.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descuento d = new Descuento();
            d.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Numeros1a100 n = new Numeros1a100();
            n.Show();
        }

        
    }
}
