using Comercial.Dominio.Interfaces;
using Comercial.Infra.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioBase : IRepositorioBase
    {
        protected Persistencia _persistencia;

        public RepositorioBase()
        {
            _persistencia = new PersistenciaFactory().Instanciar();
        }

        public string Insert(object obj, string tabela, string campoId)
        {
            return _persistencia.Inserir(obj, tabela, campoId);
        }

        public string GetById(object obj, string tabela, string campoId, int id)
        {
            return _persistencia.GetId(obj, tabela, campoId, id);
        }

        public string Remove(string tabela, string campoId, int valorId)
        {
            return _persistencia.Delete(tabela, campoId, valorId);
        }

        public string Update(object obj, string tabela, string campoId, int id)
        {
            return _persistencia.Update(obj, tabela, campoId, id);
        }
    }
}
