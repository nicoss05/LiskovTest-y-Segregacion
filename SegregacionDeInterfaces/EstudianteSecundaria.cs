using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces
{
    class EstudianteSecundaria : Estudiante
    {
        public new string Sufragar(Votacion votacion)
        {
            if (DateTime.Now.Subtract(FechaNacimiento).TotalDays< 16 * 365)
            {
                return "No puedo Votar";
            }
            return base.Sufragar(votacion);
        }
        public new double PagoImpuestoRenta(int año)
        {
            throw new Exception ("Este Método no puede ejecutarse en el EstudianteSecuandaria");
        }
    }
}
