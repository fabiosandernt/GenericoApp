

namespace GenericoApp.Application.FolhaPagamento.Dtos
{
    public class FuncionarioDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public decimal Salario { get; set; }
        public bool Ativo { get; set; }
        public Guid EmpresaId { get; set; }
        
    }
}
