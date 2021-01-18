using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface IDatosPersona
    {
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Nacionalidad { get; set; }
        string Genero { get; set; }
        string OrientacionSexual { get; set; }
        string IdentidadCultural { get; set; }
    }
}
