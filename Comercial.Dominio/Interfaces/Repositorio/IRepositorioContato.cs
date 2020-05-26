using Comercial.Dominio.Entidades;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioContato : IRepositoryBase<Contato>
    {
        void Excluir(int codEmpresa, int codigo, int seq, string tipo);
    }

    public interface IRepositorioContatoConsulta
    {
        IEnumerable<ContatoConsulta> Filtrar(string campo, string valor, int codEmpresa);
        IEnumerable<ContatoConsulta> BuscarDados(int codigo, int codEmpresa, EnContato tipoContato);
    }
}
