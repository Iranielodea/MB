using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace CrossPlataforma.Comum
{
    public static class PermissaoGeral
    {
        public static List<Permissao> Permissoes { get; set; }
        public static int IdUsuario { get; set; }

        public static void ListarPermissoes(string nomeUsuario, int codEmpresa)
        {
            //var dadosFixos = new DadosFixos();
            //using (var work = new UnitOfWork(dadosFixos))
            //{
            //   // Permissoes = work.ServicoPermissao.ObterPorUsuario(nomeUsuario, codEmpresa).ToList();
            //}
        }
    }
}
