using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CAPA ACCESO A DATOS

namespace Tarea_Pilas_y_Colas
{
     class Paciente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor de la clase Paciente
        public Paciente(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}

