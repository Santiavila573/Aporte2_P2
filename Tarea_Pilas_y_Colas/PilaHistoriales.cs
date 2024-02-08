using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CAPA ACCESO A DATOS.

namespace Tarea_Pilas_y_Colas
{
    // Definición de la clase PilaHistoriales para los historiales médicos
    class PilaHistoriales
    {
        private NodoPaciente cima; // Nodo que representa el último paciente en la pila

        // Constructor de la clase PilaHistoriales
        public PilaHistoriales()
        {
            cima = null; // Al inicio, la pila está vacía, por lo que la cima es nula
        }

        // Método para apilar un historial médico en la pila
        public void Apilar(Paciente paciente)
        {
            NodoPaciente nuevoNodo = new NodoPaciente(paciente); // Se crea un nuevo nodo con el paciente dado
            nuevoNodo.Siguiente = cima; // El nuevo nodo apunta al nodo que actualmente está en la cima
            cima = nuevoNodo; // El nuevo nodo se convierte en la nueva cima de la pila
        }

        // Método para desapilar un historial médico de la pila
        public Paciente Desapilar()
        {
            if (cima == null) // Si la pila está vacía
            {
                throw new InvalidOperationException("La pila de historiales está vacía."); // Se lanza una excepción
            }
            Paciente paciente = cima.Paciente; // Se obtiene el paciente de la cima de la pila
            cima = cima.Siguiente; // Se avanza el puntero de la cima al siguiente nodo
            return paciente; // Se devuelve el paciente desapilado
        }
    }

}
