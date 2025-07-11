using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_1_vectores
{
    internal class Servicio
    {
        public int[] lista = new int[10];
        public int contador;

        public Servicio()
        {
            contador = 0;
        }

        public void RegistrarValor(int valor)
        {
            
            lista[contador] = valor;
            contador++;
            
        }

        
        public double CalcularPromedio()
        {
            double Promedio = 0;
            for (int i = 0; i < contador; i++)
            {
                Promedio += lista[i];
            }

            return Promedio / contador;
        }

        public double CalcularMaximo()
        {
            double maximo = lista[0];
            for (int i = 0; i < contador; i++)
            {
                if (lista[i] > maximo)
                {
                    maximo = lista[i];
                }
            }
            return maximo;
        }

        public double CalcularMinimo()
        {
            double minimo = lista[0];
            for (int i = 0; i < lista[contador]; i++)
            {
                if (lista[i] < minimo)
                {
                    minimo = lista[i];
                }
            }
            return minimo;
        }

        public void OrdenarLista()
        {
            for (int i = 0; i < lista[contador] - 1; i++)
            {
                for (int j = i + 1; j < lista[contador]; j++)
                {
                    if (lista[i] > lista[j])
                    {
                        Intercambiar(i, j);
                    }
                }

            }
        }

        public void Intercambiar(int i, int j)
        {
            int auxj;
            auxj = lista[i];
            lista[i] = lista[j];
            lista[j] = auxj;
        }

        public int BuscarValor(int buscado)
        {

            for (int i = 0; i < contador; i++)
            {
                if (lista[i] == buscado)
                {
                    return i;
                }
            }

            return -1;
        }

        public int[] ListaSuperioresAlPromedio(out int contadorSuperiores)
        {
            double promedio = CalcularPromedio();
            contadorSuperiores = 0;
            int[] superiores = new int[contador]; // arreglo con el tamaño máximo

            for (int i = 0; i < contador; i++)
            {
                if (lista[i] > promedio)
                {
                    superiores[contadorSuperiores] = lista[i];
                    contadorSuperiores++;
                }
            }

            // Ahora un arreglo final con el tamaño exacto
            int[] resultadoFinal = new int[contadorSuperiores];

            for (int i = 0; i < contadorSuperiores; i++)
            {
                resultadoFinal[i] = superiores[i];
            }

            return resultadoFinal;
        }
    }
}