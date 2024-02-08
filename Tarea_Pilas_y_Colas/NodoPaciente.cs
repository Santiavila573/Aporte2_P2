using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas_y_Colas
{
    // Definición de la clase NodoPaciente para la cola de espera
    class NodoPaciente
    {
        public Paciente Paciente { get; set; }
        public NodoPaciente Siguiente { get; set; }

        // Constructor de la clase NodoPaciente
        public NodoPaciente(Paciente paciente)
        {
            Paciente = paciente;
            Siguiente = null;
        }
    }
}
