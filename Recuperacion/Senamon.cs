using System;
using System.Collections.Generic;
using System.Text;

namespace Recuperacion
{
    class Senamon
    {
        /* Cada Senamon tendrá las siguientes características: nombre, nivel(eliminarlo), 
         * tipo de Senamon (fuego, agua, hierva, volador y eléctrico), 
         * peso, puntos de salud, nivel de ataque, fase, nivel de energía(misma salud -elimnado) y 
         * una descripción breve del Senamon
         * 
         */

        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Peso { get; set; }
        public float Salud { get; set; }
        public int Ataque { get; set; }
        public int Fase { get; set; }

        public string Descripcion { get; set; }

        //Metodos Constructores
        public Senamon() { }

        public Senamon(string nombre, string tipo, double peso, float salud, int ataque, int fase, string descripcion)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Peso = peso;
            this.Salud = salud;
            this.Ataque = ataque;
            this.Fase = fase;
            this.Descripcion = descripcion;
        }

    }

}
