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

           
        }
    }
}
