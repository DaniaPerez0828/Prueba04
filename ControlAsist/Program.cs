using System;
using System.Collections.Generic;

namespace ControlAsistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            int numeroEstudiantes;

            Console.Write("¿Cuántos estudiantes deseas registrar? ");
            while (!int.TryParse(Console.ReadLine(), out numeroEstudiantes) || numeroEstudiantes <= 0)
            {
                Console.Write("Por favor, ingresa un número válido de estudiantes: ");
            }

            for (int i = 0; i < numeroEstudiantes; i++)
            {
                Console.Write($"Ingresa el nombre del estudiante #{i + 1}: ");
                string nombre = Console.ReadLine();

                Console.Write($"Ingresa el número total de sesiones de {nombre}: ");
                int sesionesTotales;
                while (!int.TryParse(Console.ReadLine(), out sesionesTotales) || sesionesTotales <= 0)
                {
                    Console.Write("Por favor, ingresa un número válido de sesiones: ");
                }

                Estudiante estudiante = new Estudiante(nombre, sesionesTotales);
                estudiantes.Add(estudiante);

                Console.Write($"¿Cuántas sesiones asistió {nombre}? ");
                int sesionesAsistidas;
                while (!int.TryParse(Console.ReadLine(), out sesionesAsistidas) || sesionesAsistidas < 0 || sesionesAsistidas > sesionesTotales)
                {
                    Console.Write("Por favor, ingresa un número válido de sesiones asistidas: ");
                }

                estudiante.RegistrarAsistencia(sesionesAsistidas);
            }

            
        }
    }
}
