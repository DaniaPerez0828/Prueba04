using System;

namespace ControlAsistencia
{
    public class ResumenEstudiante
    {
        public string ObtenerInformacionEstudiante(Estudiante estudiante)
        {
            double porcentaje = (double)estudiante.SesionesAsistidas / estudiante.SesionesTotales * 100;
            string estado = porcentaje >= 75 ? "Aprobado" : "Reprobado"; // Ejemplo de lógica para el estado

            return $"| Estudiante         | {estudiante.Nombre}                          |\n" +
                   $"|--------------------|---------------------------------------------|\n" +
                   $"| Asistencias        | {estudiante.SesionesAsistidas}/{estudiante.SesionesTotales} |\n" +
                   $"| Porcentaje         | {porcentaje:F2}%                            |\n" +
                   $"| Estado             | {estado}                                    |";
        }
    }
}

