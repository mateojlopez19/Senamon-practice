using System;
using System.Collections.Generic;
using System.Text;


namespace Recuperacion
{
    class Entrenador
    {
        /* su nombre, email, fecha de nacimiento, su nivel de experiencia y 
        * la cantidad de batallas ganadas.*/
        private Senamon[] vectorSenamon = new Senamon[5];
        private string nombre;
        private string email;
        public DateTime FechaNacimiento { get; set; }
        public int NivelExperiencia { get; set; }
        public int NumVictorias { get; set; }

        //Metodo constructor
        public Entrenador() { }

        public Entrenador(string nombre, string email, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.email = email;
            this.FechaNacimiento = fechaNacimiento;
            this.NumVictorias = 0;
            this.NivelExperiencia = 400;
        }

        //Metodos set y get
        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public Senamon[] getVectorSenamon()
        {
            return this.vectorSenamon;
        }

        public void setSenamon(Senamon numSenamon)
        {
            for (int i = 0; i < vectorSenamon.Length; i++)
            {
                if (vectorSenamon[i] == null)
                {
                    vectorSenamon[i] = numSenamon;
                    break;
                }
            }
        }

        //metodos
        public void eliminarSenamon(int posicion)
        {
            this.vectorSenamon[posicion] = null;
        }

        public void aumentarVictoria()
        {
            this.NumVictorias++;
            this.NivelExperiencia = this.NivelExperiencia + 100;
        }


    }

}

