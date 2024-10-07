using System;

namespace ControlAsistencia
{
    public class Estudiante
    {
        public string Nombre { get; private set; }
        public int SesionesTotales { get; private set; }
        public int SesionesAsistidas { get; private set; }

        public Estudiante(string nombre, int sesionesTotales)
        {
            Nombre = nombre;
            SesionesTotales = sesionesTotales;
            SesionesAsistidas = 0;
        }
    }
}
