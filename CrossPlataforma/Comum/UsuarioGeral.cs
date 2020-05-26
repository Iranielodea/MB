using Comercial.Dominio.Entidades;

namespace CrossPlataforma.Comum
{
    public static class UsuarioGeral
    {
        public static DadosFixos DadosFixos { get; set; }

        public static void BuscarUsuario(string nomeUsuario, string senha, int codEmpresa)
        {

            //using (var work = new UnitOfWork(DadosFixos))
            //{
            //    var usuario = work.ServicoUsuario.ObterPorUsuarioSenha(nomeUsuario, senha, codEmpresa);

            //    if (DadosFixos == null)
            //        DadosFixos = new DadosFixos();

            //    DadosFixos.IdEmpresa = 1;
            //    DadosFixos.IdUsuario = usuario.Id_Usuario;
            //    DadosFixos.NomeUsuario = usuario.Nome;
            //    DadosFixos.NomeEmpresa = "Empresa Marcos & Biazus";
            //}
        }
    }
}
