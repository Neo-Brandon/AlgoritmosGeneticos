using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos
{
    public class Flores
    {
        //Variables necesarias para la clase 
        private int x;
        // Posicion en la ventana

        private double adaptacion;
        // Nivel de adaptacion del oraanismo
        // Creamos el cromosoma de la flor
        // 0-Altura
        // 1-Color de la flor
        // 2-Color del tallo
        // 3-Ancho del tallo
        //4-Tamaño de la flor
        //I 5-Tamaño del centro de la flor

        public int[] cromosoma = new int[6];

        // Creamos las propiedades
        public int CoordX
        {
            set
            { x = value; }
            get { return x; }
        }

        public double Adaptacion
        {
            set { adaptacion = value; }
            get { return adaptacion; }
        }
        public Flores()
        {
            // TODO: agregar aquí la lógica del constructor
        }
    }
}