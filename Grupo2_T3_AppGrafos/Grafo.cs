using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2_T3_AppGrafos
{
    public class Grafo
    {
        //Dijkstra

        private Nodo inicio;
        private const int MAX = 999999;

        public Grafo()
        {
            inicio = null;
        }
        private Nodo obtenerNodo(string valor)
        {
            Nodo nodo = inicio;
            while (nodo != null && (nodo.dato != valor))
            {
                nodo = nodo.sgte;
            }
            return nodo;
        }

        private Arista obtenerArista(Nodo nodoOrigen, Nodo nodoDestino)
        {
            Arista arista = nodoOrigen.ady;
            while (arista != null && arista.destino !=
            nodoDestino)
            {
                arista = arista.sgte;
            }
            return arista;
        }

        private Nodo obtenerMinimo()
        {
            Nodo nodoMinimo = null, nodoActual = inicio;
            int minimo = MAX;
            while (nodoActual != null)
            {
                if (nodoActual.estado == 'N' &&
                nodoActual.distanciaFuente < minimo)
                {
                    nodoMinimo = nodoActual;
                    minimo = nodoMinimo.distanciaFuente;
                }
                nodoActual = nodoActual.sgte;
            }
            return nodoMinimo;
        }

        private void inicializarNodos()
        {
            Nodo nodoActual = inicio;
            while (nodoActual != null)
            {
                nodoActual.predecesor = null;
                nodoActual.distanciaFuente = MAX;
                nodoActual.estado = 'N';
                nodoActual = nodoActual.sgte;
            }
        }

        public void insertarNodo(string valor)
        {
            Nodo nuevoNodo, nodoUltimo;
            if (obtenerNodo(valor) == null)
            {
                nuevoNodo = new Nodo();
                nuevoNodo.dato = valor;
                nuevoNodo.sgte = null;
                nuevoNodo.ady = null;
                if (inicio == null)
                    inicio = nuevoNodo;
                else
                {
                    nodoUltimo = inicio;
                    while (nodoUltimo.sgte != null)
                        nodoUltimo = nodoUltimo.sgte;
                    nodoUltimo.sgte = nuevoNodo;
                }
            }
        }

        public void insertarArista(string origen, string destino, int distancia)
        {
            Arista nuevaArista, ultimaArista;
            Nodo nodoOrigen, nodoDestino;
            nodoOrigen = obtenerNodo(origen);
            if (nodoOrigen != null)
            {
                nodoDestino = obtenerNodo(destino);
                if (nodoDestino != null)
                {
                    if (obtenerArista(nodoOrigen, nodoDestino) == null)
                    {
                        nuevaArista = new Arista();
                        nuevaArista.destino = nodoDestino;
                        nuevaArista.distancia = distancia;
                        nuevaArista.sgte = null;
                        if (nodoOrigen.ady == null)
                        {
                            nodoOrigen.ady = nuevaArista;
                        }
                        else
                        {
                            ultimaArista = nodoOrigen.ady;
                            while (ultimaArista.sgte != null)
                                ultimaArista = ultimaArista.sgte;
                            ultimaArista.sgte = nuevaArista;
                        }
                    }
                }
            }
        }

        public void dijkstra(string origen)
        {
            Nodo nodoOrigen = obtenerNodo(origen);
            Nodo nodoMinimo, nodoDestino;
            Arista adyacencias, aristaActual;
            inicializarNodos();
            if (nodoOrigen != null)
            {
                nodoOrigen.distanciaFuente = 0;
                nodoMinimo = obtenerMinimo();
                while (nodoMinimo != null)
                {
                    nodoMinimo.estado = 'V';
                    adyacencias = nodoMinimo.ady;
                    aristaActual = adyacencias;
                    while (aristaActual != null)
                    {
                        nodoDestino = aristaActual.destino;
                        if (nodoDestino.distanciaFuente > nodoMinimo.distanciaFuente + aristaActual.distancia)
                        {
                            nodoDestino.distanciaFuente = nodoMinimo.distanciaFuente + aristaActual.distancia;
                            nodoDestino.predecesor = nodoMinimo;
                        }
                        aristaActual = aristaActual.sgte;
                    }
                    nodoMinimo = obtenerMinimo();
                }
            }
        }

    }
}
