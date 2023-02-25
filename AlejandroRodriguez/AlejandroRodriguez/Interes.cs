using System;
using System.Windows.Forms;

namespace AlejandroRodriguez
{
    public partial class Interes : Form
    {
        public Interes()
        {
            InitializeComponent();
            CalculoInteres();
        }

        double interes = 0.015;
        int tiempo = 12;
        double interesganado;
        double capitalacumulado = 200000;
        double[] meses = new double[12];

        private void CalculoInteres()
        {
            
           for (int i = 0; i < meses.Length; i++)
            {
                interesganado = (int)((capitalacumulado * (interes * tiempo))/12);
                meses[i] = interesganado;
                capitalacumulado += interesganado;
            }

        }
        private void limpiarcontroles()
        {
            listView1.Clear();
        }

        private void MostrarInteres()
        {
            const string Enero = "Enero";
            const string Febrero = "Febrero";
            const string Marzo = "Marzo";
            const string Abril = "Abril";
            const string Mayo = "Mayo";
            const string Junio = "Junio";
            const string Julio = "Julio";
            const string Agosto = "Agosto";
            const string Septiembre = "Septiembre";
            const string Octubre = "Octubre";
            const string Noviembre = "Noviembre";
            const string Diciembre = "Diciembre";
            //listBox1.SelectedItem retornará el objeto que esté seleccionado en el ListBox
            //en este caso retornará un objeto de tipo String, que será comparado a los strings
            //que creamos como constantes.
            switch (listBox1.SelectedItem)
            {
                case Enero:
                    listView1.Items.Add(meses[0].ToString());
                    break;
                case Febrero:
                    listView1.Items.Add(meses[1].ToString());
                    break;
                case Marzo:
                    listView1.Items.Add(meses[2].ToString());
                    break;
                case Abril:
                    listView1.Items.Add(meses[3].ToString());
                    break;
                case Mayo:
                    listView1.Items.Add(meses[4].ToString());
                    break;
                case Junio:
                    listView1.Items.Add(meses[5].ToString());
                    break;
                case Julio:
                    listView1.Items.Add(meses[6].ToString());
                    break;
                case Agosto:
                    listView1.Items.Add(meses[7].ToString());
                    break;
                case Septiembre:
                    listView1.Items.Add(meses[8].ToString());
                    break;
                case Octubre:
                    listView1.Items.Add(meses[9].ToString());
                    break;
                case Noviembre:
                    listView1.Items.Add(meses[10].ToString());
                    break;
                case Diciembre:
                    listView1.Items.Add(meses[11].ToString());
                    break;
            } 
        }

        //Boton Mostrar
        private void button1_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count == 0)
            {
                MostrarInteres();
            }
            else
            {
                limpiarcontroles();
                MostrarInteres();
            }
        }

        //Boton Limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }
    
    }

}