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

namespace Memoria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] botones;
        private const int alto = 4, ancho = 4;
        private int numero1, numero2;
        private int filanum, colnum;
        public MainWindow()
        {
            numero1 = -1;
            numero2 = -1;


            InitializeComponent();
            botones = new Button[alto, ancho];
            Numeros num = new Numeros();
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    botones[i, j] = new Button();
                    botones[i, j].Click += clickBoton;
                    int numero = num.obtenernumero();
                    botones[i, j].Content = numero.ToString();
                    botones[i, j].Foreground = new SolidColorBrush(Colors.Transparent);
                    Grid.SetColumn(botones[i, j], i);
                    Grid.SetRow(botones[i, j], j);
                    pantalladejuego.Children.Add(botones[i, j]);
                }
            }
        }
        private async void clickBoton(object sender, RoutedEventArgs e)
        {
            //cambio de un tipo de object a un boton y cambiamos de color de la fuente;
            ((Button)sender).Foreground = new SolidColorBrush(Colors.Blue);
            if (numero1 == 0)
            {
               numero1 = int.Parse (((Button)sender).Content.ToString());
                colnum = Grid.GetColumn((Button)sender);
                filanum = Grid.GetRow((Button)sender);


            }
                else
	{
        numero2 = int.Parse (((Button)sender).Content.ToString());
        await Task.Delay(1000);
                if (numero1 == -1)
	{

MessageBox.Show("usted acerto");
 ((Button)sender).IsEnabled = false;
 botones[colnum, filanum].IsEnabled = false;


	}
                else

	{
                    ((Button)sender).Foreground = new  SolidColorBrush((Colors.Transparent));
                    MessageBox.Show("usted fallo");
                    botones[colnum, filanum].Foreground = new SolidColorBrush(Colors.Transparent);

	}
                numero1 = -1;
	
            }
        }
    }
}
