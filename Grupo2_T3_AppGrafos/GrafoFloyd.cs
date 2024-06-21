using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2_T3_AppGrafos
{
    internal class GrafoFloyd
    {
        private const int MAX = 10;
        private char[] nodos = new char[MAX];
        private int[,] adyacencias = new int[MAX, MAX];
        private int cantidadNodos;

        private int[,] distancias = new int[MAX, MAX];
        private char[,] recorridos = new char[MAX, MAX];

        public GrafoFloyd()
        {
            for (int i = 0; i <= MAX - 1; i++)
            {
                for (int j = 0; j <= MAX - 1; j++)
                {
                    if (i == j) adyacencias[i, j] = 0;
                    else
                    {
                        adyacencias[i, j] = -1;
                    }
                }
                cantidadNodos = 0;
            }
        }

        private int obtenerPosicionNodo(char valor)
        {
            for (int i = 0; i <= cantidadNodos - 1; i++)
            {
                if (nodos[i] == valor)
                    return i;
            }
            return -1;
        }

        public void insertarNodo(char valor)
        {
            if (obtenerPosicionNodo(valor) == -1)
            {
                nodos[cantidadNodos] = valor;
                cantidadNodos++;
            }
        }

        public void insertarArista(char origen, char destino, int distancia)
        {
            int i, j;
            i = obtenerPosicionNodo(origen);
            j = obtenerPosicionNodo(destino);
            if (i != -1 && j != -1)
            {
                adyacencias[i, j] = distancia;
            }
        }

        private void inicializarMatrices()
        {
            for (int i = 0; i <= cantidadNodos - 1; i++)
            {
                for (int j = 0; j <= cantidadNodos - 1; j++)
                {
                    recorridos[i, j] = nodos[j];
                    distancias[i, j] = adyacencias[i, j];
                }
            }
        }

        public void floyd()
        {
            inicializarMatrices();
            for (int k = 0; k <= cantidadNodos - 1; k++)
            {
                for (int i = 0; i <= cantidadNodos - 1; i++)
                {
                    for (int j = 0; j <= cantidadNodos - 1;
                    j++)
                    {
                        if (i != j && i != k && j != k &&
                        distancias[i, k] != -1 && distancias[k, j] != -1)
                        {
                            if (distancias[i, k] +
                            distancias[k, j] < distancias[i, j] || distancias[i, j] == -1)
                            {
                                distancias[i, j] =
                                distancias[i, k] + distancias[k, j];
                                recorridos[i, j] =
                                nodos[k];
                            }
                        }
                    }
                }
            }
        }
    }
}