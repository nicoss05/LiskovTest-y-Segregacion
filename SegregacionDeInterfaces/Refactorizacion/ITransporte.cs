using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface ITransporte
    {
        double PagoImpuestoVerde(int año, Vehiculo vehiculo);
        
    }
}
