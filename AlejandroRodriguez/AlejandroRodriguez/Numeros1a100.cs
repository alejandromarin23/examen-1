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
    public partial class Numeros1a100 : Form
    {
        public Numeros1a100()
        {
            InitializeComponent();
        }

        List<int> lNumeros = new List<int>();
        public void GeneraNumeros()
        {
            for (int i=0;i<101; i++ )
            {
                lNumeros.Add(i+1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GeneraNumeros();
            for(int i = 1; i < lNumeros.Count; i++ )
            {
                string s = i.ToString();
                if(i % 3 == 0 && i % 5 == 0) //Mostrará las iniciales de Nombre y apellido si el numero es multiplo de 3 y 5
                {
                    listView1.Items.Add("JR");
                }else if(i%3==0) //Mostrará el Nombre si el numero es multiplo de 3
                {
                    listView1.Items.Add("Josue");
                } else if(i%5==0 && i%5==0) //Mostrará el apellido si el numero es multiplo de 5
                {
                    listView1.Items.Add("Rodriguez");
                }else
                     listView1.Items.Add(s);

            }
        }
    }
}
