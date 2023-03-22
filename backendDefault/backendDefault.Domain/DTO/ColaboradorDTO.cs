namespace backendDefault.Domain.DTO
{
    public partial class ColaboradorDTO
    {
        public int IdColaborador { get; set; }
        public int IdEmpresa { get; set; }
        public string Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
