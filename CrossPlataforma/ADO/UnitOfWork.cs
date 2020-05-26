using Comercial.Infra.DataBase;

namespace CrossPlataforma.ADO
{
    public class UnitOfWork
    {
        private ConexaoFB _conexaoDB;

        public UnitOfWork()
        {
            _conexaoDB = new ConexaoFB();
            _conexaoDB.AbrirConexao();
        }

        public void BeginTransacao()
        {
            _conexaoDB.StartTransaction();
        }

        public void Commit()
        {
            _conexaoDB.Commit();
            _conexaoDB.FecharConexao();
        }

        public void Dispose()
        {
            _conexaoDB.FecharConexao();
        }

        public void RollBack()
        {
            _conexaoDB.RollBack();
            _conexaoDB.FecharConexao();
        }

        //public IServicoGrupo ServicoGrupo { get { return new ServicoGrupo(_conexaoDB); } }
        //public IServicoCadObs ServicoCadObs { get { return new ServicoCadObs(_conexaoDB); } }
        //public IServicoEstado ServicoEstado { get { return new ServicoEstado(_conexaoDB); } }
        //public IServicoCidade ServicoCidade { get { return new ServicoCidade(_conexaoDB); } }
    }
}
