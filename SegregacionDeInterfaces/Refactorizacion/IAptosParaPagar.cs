using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface IAptosParaPagar
    {
        double PagoImpuestoRenta(int año);
        double PagoImpuestoPredial(int año, Propiedad propiedad);
    }
}
