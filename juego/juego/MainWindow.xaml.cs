using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace juego
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] botones;
        private const int alto = 4, ancho = 4;
        private int numero1, numero2;
        public MainWindow()
        {
            numero1 = -0;
            numero2 = -0;
            InitializeComponent();
            botones = new Button[alto, ancho];
            Numero num = new Numero();
            for(int i=0; i<alto; i++)
            {
                for(int j=0; j<ancho;j++)
                {
                    botones[i, j] = new Button();
                    botones[i, j].Click += clickBoton;
                    int numero = num.obtenerNumeros();
                    botones[i, j].Content = numero.ToString();
                    botones[i, j].Foreground = new SolidColorBrush(Colors.Transparent);
                    Grid.SetColumn(botones[i, j], i);
                    Grid.SetRow(botones[i, j], j);
                    pantalladejuego.Children.Add(botones[i,j]);
                }
            }
        }
        private void clickBoton(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Foreground = new SolidColorBrush(Colors.Red);
            if (numero1==0)
            {
                numero1=int.Parse(((Button)sender).Content.ToString());
            }
            else
            {
                numero2= int.Parse(((Button)sender).Content.ToString());
                if (numero1==numero2)
                {
                    ((Button)sender).IsEnabled = false;

                    MessageBox.Show("Usted Acerto");
                }
                else
                {
                    ((Button)sender).Foreground = new SolidColorBrush(Colors.Transparent);
                    MessageBox.Show("Usted Fallo");


                }
                numero1 = -1;
            }
        }
    }
}
