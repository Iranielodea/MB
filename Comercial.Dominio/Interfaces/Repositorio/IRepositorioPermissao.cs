using Comercial.Dominio.Entidades;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioPermissao : IRepositoryBase<Permissao>
    {
        Permissao Permitir(string tabela, string nomeUsuario, AcaoUsuario acao = AcaoUsuario.Consultar);
    }

    public interface IRepositorioPermissaoConsulta
    {
        IEnumerable<PermissaoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
