using System;
using System.Windows.Forms;

namespace AlejandroRodriguez
{
    public partial class Interes : Form
    {
        public Interes()
        {
            InitializeComponent();
        }


        double capital = 200000;
        double interes = 0.015;
        int tiempo = 1;
        double interesganado;
        double capitalacumulado = 200000;
        double[] meses = { 12 };

        private void CalculoInteres()
        {
           interesganado = (int)(capital * interes * tiempo);
           capitalacumulado += interesganado;
            for (int i =0; i<meses.Length;i++)
            {
                
                interesganado = (int)(capitalacumulado * interes * tiempo);
                capitalacumulado += interesganado;
                meses[i + 1] = interesganado;
               
            }
         
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CalculoInteres();

        }
        private void limpiarcontroles()
        {
            listView1.Clear();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Add(interesganado.ToString());
   
            Console.WriteLine(listBox1.Items.IndexOf(0));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}