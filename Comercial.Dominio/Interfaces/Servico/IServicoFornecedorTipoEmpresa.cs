using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoFornecedorTipoEmpresa
    {
        FornecedorTipoEmpresa ObterPorId(int id);
        IEnumerable<FornecedorTipoEmpresaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(FornecedorTipoEmpresa grupo, string nomeUsuario);
        int Salvar(FornecedorTipoEmpresa grupo, string nomeUsuario);
    }
}
