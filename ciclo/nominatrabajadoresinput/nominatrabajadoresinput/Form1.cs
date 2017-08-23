using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace nominatrabajadoresinput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nombre, area, operacion, cad="" ;
        int salario;
        int ns;
        int i = 0;

        private void button1_Click(object sender, EventArgs e)

        {
           

            while (i < 2)

            {
                i = i + 1;
                operacion = Interaction.InputBox("Ingrese Operacion", "Mensaje", "", 50, 50);
                area = Interaction.InputBox("Ingrese Area De Trabajo", "Mensaje", "", 50, 50);
                nombre = Interaction.InputBox("Ingrese Su Nombre", "Mensaje", "", 50, 50);
                salario = (int.Parse(Interaction.InputBox("Ingrese valor", "Mensaje", "", 50, 50)));
                cad = nombre  + area + operacion;
               
            }
            ns = (i * salario);
            MessageBox.Show("Los Trabajadores Son:" + cad + "\n" + "El Valor De La Nomina Es:" + ns);


        }
    }
}
