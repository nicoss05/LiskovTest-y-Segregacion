namespace SegregacionDeInterfaces.Refactorizacion
{
    public interface IElectoral
    {
        string Sufragar(Votacion votacion);
        string Postular(Candidatura candidatura);
        string Afiliar(PartidoPolitico partidoPolitico);
    }
}
