using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArreglos
{
    class Persona
    {
        private string nombre;
        private string apellidos;
        private DateTime? fechaNac;

        public Persona(string nombre, string apellidos, DateTime? fechaNac)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;

            }
            set
            {
                apellidos = value;
            }
        }

        public DateTime? FechaNac { get => fechaNac; set => fechaNac = value; }
        public Persona()
        {
            nombre = "";
            apellidos = "";
            FechaNac = null;

        }
        public override string ToString()
        {
            return nombre+ ""+ apellidos+ ""+ fechaNac;
        }
    }

    

}
