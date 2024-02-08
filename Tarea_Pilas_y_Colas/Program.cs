// Clase principal del programa
using Tarea_Pilas_y_Colas;
// CAPA DE PRESENTACIÓN

class Program
{
    static void Main(string[] args)
    {
        // Cola de espera de pacientes
        ColaEspera colaEspera = new ColaEspera();

        // Pila de historiales médicos
        PilaHistoriales historialesMedicos = new PilaHistoriales();

        // Registro de pacientes en la cola de espera
        colaEspera.Encolar(new Paciente("Juan", 35));
        colaEspera.Encolar(new Paciente("María", 45));
        colaEspera.Encolar(new Paciente("Pedro", 25));

        // Atender pacientes en orden de llegada
        while (true)
        {
            try
            {
                Paciente pacienteActual = colaEspera.Desencolar(); // Se desencola al paciente de la cola

                // Simular atención médica
                Console.WriteLine($"Atendiendo a {pacienteActual.Nombre}...");

                // Guardar historial médico en la pila
                historialesMedicos.Apilar(pacienteActual); // Se apila el paciente atendido en la pila de historiales
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }
        }

        // Mostrar historiales médicos en orden de atención
        Console.WriteLine("\nHistoriales médicos:");
        while (true)
        {
            try
            {
                Paciente historialActual = historialesMedicos.Desapilar(); // Se desapila el historial médico de la pila
                Console.WriteLine($"Nombre: {historialActual.Nombre}, Edad: {historialActual.Edad}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }
        }
    }
}