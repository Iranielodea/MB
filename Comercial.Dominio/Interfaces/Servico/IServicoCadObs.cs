using Comercial.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoCadObs
    {
        IEnumerable<CadObs> ObterPorCodigoCliente(int codigo, int codEmpresa = 1);
        IEnumerable<CadObs> ObterPorCodigoCarga(int codigo, int codEmpresa = 1);
        void Excluir(CadObs cadObs);
        CadObs ObterUmRegistroCarga(int codigo, int numLinha, int codEmpresa = 1);
        CadObs ObterUmRegistroCliente(int codigo, int numLinha, int codEmpresa = 1);
        void InserirCliente(CadObs cadObs);
        void AlterarCliente(CadObs cadObs);
        void InserirCarga(CadObs cadObs);
        void AlterarCarga(CadObs cadObs);
    }
}
