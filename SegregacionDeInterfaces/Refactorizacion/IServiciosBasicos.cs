using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface IServiciosBasicos
    {
        double PagoLuz(DateTime fecha, Propiedad propiedad);
        double PagoAgua(DateTime fecha, Propiedad propiedad);
    }
}
