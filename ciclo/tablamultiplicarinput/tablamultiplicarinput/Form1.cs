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

namespace tablamultiplicarinput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
      

        private void button1_Click(object sender, EventArgs e)
        { 
            int n;
            int multiplicar;
      
           
            n = (int.Parse(Interaction.InputBox("Ingrese Numero  A Multiplicar")));
            int i=1;
            while(i <10)
            
            {
                  i = i + 1;
                multiplicar = (n * i);

               
                MessageBox.Show(i+"*"+n+"=" + multiplicar);
            }
           
        }
    }
}