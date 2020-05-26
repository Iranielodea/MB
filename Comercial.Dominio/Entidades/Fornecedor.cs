namespace Comercial.Dominio.Entidades
{
    public class Fornecedor : PessoaBase
    {
        public int Cod_For { get; set; }
        public string Fantasia { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CNPJ { get; set; }
        public string Insc_Estadual { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
        public string Num_Banco { get; set; }
        public string Nome_Banco { get; set; }
        public string Num_Agencia { get; set; }
        public string Num_Conta { get; set; }
        public string Nome_Titular { get; set; }
        public string CPF { get; set; }
        public string Nome_Despositante { get; set; }
        public string Marcar { get; set; }
        public int? Id_Tipo_Empresa { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual FornecedorTipoEmpresa FornecedorTipoEmpresa { get; set; }
    }

    public class FornecedorConsulta
    {
        public int Cod_For { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Insc_Estadual { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
    }
}
