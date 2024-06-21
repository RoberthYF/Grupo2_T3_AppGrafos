using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2_T3_AppGrafos
{
    internal class Nodo
    {
        public string dato; // De ingreso
        // dato: Validar dese interfáz grafica con Expresiones regulares 
            // capturar excepciones
            // de Over flow
            // y Genreales (e) en el formulario particular
        public Nodo sgte;
        public Arista ady;

        public int distanciaFuente; // De salida
        public Nodo predecesor;
        public char estado;

    }
}
