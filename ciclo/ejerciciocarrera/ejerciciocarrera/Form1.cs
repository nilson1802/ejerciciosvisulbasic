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

namespace ejerciciocarrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, carrera, documento;
            nombre = Interaction.InputBox("digite su nombre");
            carrera = Interaction.InputBox("digite carrera");
            documento = Interaction.InputBox("digite documento");
            MessageBox.Show("su nombre es\n" +  nombre  + carrera + documento);
                
        }
    }
}
