using System;
using System.Collections;
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
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }


        List<double> lPrecios = new List<double>(); //lista de precios de productos
        List<String> lProductos = new List<String>(); //lista de nombres de productos

        /*Boton que agrega los datos : Nombre Producto, Precio Producto a las listas correspondientes *"Agregar"* */
        public void button2_Click(object sender, EventArgs e)
        {
            string producto = Convert.ToString(textBox1.Text);
            double precio = Convert.ToDouble(textBox2.Text);

            lProductos.Add(producto);
            lPrecios.Add(precio);
        }

        //calcula total
        public async void button1_ClickAsync(object sender, EventArgs e)
        {

            double total1 = (double)await DescuentoAsync(GeneraSumaTotal());
            MessageBox.Show("\nDetalle:\n" + GeneraTotal() + "\n" + "Descuento: Lps.\t" + (GeneraSumaTotal() - total1) + "\nTotal: Lps.\t" + total1);

        }
        public async Task<double> DescuentoAsync(double Totales)
        {
            double descuento = await Task.Run(() =>

            {
                return Totales * 0.15;
            });
            return (Totales - descuento);

        }

        public double GeneraSumaTotal()
        {
            double suma = 0;
            double[] dPrecios = lPrecios.ToArray();
            ;
            for (int i = 0; i < lPrecios.Count; i++)
            {
                suma = suma + dPrecios[i];
            }
            return suma;
        }

        public string GeneraTotal()
        {
            double[] dPrecios = lPrecios.ToArray();
            string[] sNombreProductos = lProductos.ToArray();

            String data = "\nProducto:\t" + "Precio:\n";

            for (int index = 0; index < lProductos.Count; index++)
                data += String.Format("{0} \t\t{1}\n", sNombreProductos[index], dPrecios[index]);

            return data;
        }


    }
}

