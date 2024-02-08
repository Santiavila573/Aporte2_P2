using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CAPA LÓGICA


namespace Tarea_Pilas_y_Colas
{
    // Definición de la clase ColaEspera
    class ColaEspera
    {
        private NodoPaciente primero; // Nodo que representa el primer paciente en la cola
        private NodoPaciente ultimo;  // Nodo que representa el último paciente en la cola

        // Constructor de la clase ColaEspera
        public ColaEspera()
        {
            primero = null; // Al inicio, la cola está vacía, por lo que el primer y último nodo son nulos
            ultimo = null;
        }

        // Método para encolar un paciente en la cola
        public void Encolar(Paciente paciente)
        {
            NodoPaciente nuevoNodo = new NodoPaciente(paciente); // Se crea un nuevo nodo con el paciente dado
            if (ultimo == null) // Si la cola está vacía
            {
                primero = nuevoNodo; // El nuevo nodo se convierte en el primer y único nodo en la cola
            }
            else // Si la cola ya tiene elementos
            {
                ultimo.Siguiente = nuevoNodo; // Se establece el nuevo nodo como siguiente del último nodo actual
            }
            ultimo = nuevoNodo; // El nuevo nodo ahora es el último nodo en la cola
        }

        // Método para desencolar un paciente de la cola
        public Paciente Desencolar()
        {
            if (primero == null) // Si la cola está vacía
            {
                throw new InvalidOperationException("La cola de espera está vacía."); // Se lanza una excepción
            }
            Paciente paciente = primero.Paciente; // Se obtiene el paciente del primer nodo en la cola
            primero = primero.Siguiente; // Se avanza el puntero del primer nodo al siguiente nodo
            if (primero == null) // Si después de desencolar el primer nodo la cola queda vacía
            {
                ultimo = null; // El último nodo también se vuelve nulo
            }
            return paciente; // Se devuelve el paciente desencolado
        }
    }

}
