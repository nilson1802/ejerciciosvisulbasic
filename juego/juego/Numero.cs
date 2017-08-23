using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    class Numero
    {
        private int[] numeros;

        public Numero()
        {
            numeros = new int[16];
            for (int i = 0; i < 8; i++)
            {
                numeros[i] = i;
                numeros[i + 8] = i;

            }
        }
        public int obtenerNumeros()
        {
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, 3);
            int aux = numeros[numeroAleatorio];
            List<int> lista = numeros.OfType<int>().ToList<int>();
            lista.RemoveAt(numeroAleatorio);
            numeros = lista.ToArray();
            return aux;
        }
    }
}
