using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    class PersonaConCapacidadesEpeciales : IElectoral, IDatosPersona
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
    }
}
