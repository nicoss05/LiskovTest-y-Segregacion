using System;

namespace SegregacionDeInterfaces
{
    public interface ICiudadano
    {
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Nacionalidad { get; set; }
        string Genero { get; set; }
        string OrientacionSexual { get; set; }
        string IdentidadCultural { get; set; }
        double PagoImpuestoRenta(int año);
        double PagoImpuestoPredial(int año, Propiedad propiedad);
        double PagoImpuestoVerde(int año, Vehiculo vehiculo);
        double PagoLuz(DateTime fecha, Propiedad propiedad);
        double PagoAgua(DateTime fecha, Propiedad propiedad);
        string ExigirDerecho(string derecho);
        string CumplirDeber(string deber);
        string AcatarLaLey(string ley);
        string ExpresarOpinion(string opinion);
        string Sufragar(Votacion votacion);
        string Postular(Candidatura candidatura);
        string Afiliar(PartidoPolitico partidoPolitico);
    }
}
