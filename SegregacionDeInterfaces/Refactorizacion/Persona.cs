using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    class Persona : IElectoral, IServiciosBasicos, IDatosPersona, ITransporte, IAptosParaPagar
    {
        public string Cedula { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nacionalidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Genero { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OrientacionSexual { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdentidadCultural { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Afiliar(PartidoPolitico partidoPolitico)
        {
            throw new NotImplementedException();
        }
        public string Postular(Candidatura candidatura)
        {
            throw new NotImplementedException();
        }

        public string Sufragar(Votacion votacion)
        {
            throw new NotImplementedException();
        }
        public double PagoAgua(DateTime fecha, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public double PagoLuz(DateTime fecha, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public double PagoImpuestoVerde(int año, Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public double PagoImpuestoRenta(int año)
        {
            throw new NotImplementedException();
        }

        public double PagoImpuestoPredial(int año, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }
    }
}
