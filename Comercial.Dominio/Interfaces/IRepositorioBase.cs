namespace Comercial.Dominio.Interfaces
{
    public interface IRepositorioBase
    {
        string Insert(object obj, string tabela, string campoId);
        string GetById(object obj, string tabela, string campoId, int id);
        string Update(object obj, string tabela, string campoId, int valorId);
        string Remove(string tabela, string campoId, int id);
    }
}
