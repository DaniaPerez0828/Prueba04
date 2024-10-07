using System;
using System.Collections.Generic;

namespace ControlAsistencia
{
    public class Asistencia
    {
        private const double MINIMO_ASISTENCIA = 75;

        public static double CalcularPorcentaje(int asistidas, int totales)
        {
            if (totales == 0)
                return 0;
            return (double)asistidas / totales * 100;
        }

    }
}


