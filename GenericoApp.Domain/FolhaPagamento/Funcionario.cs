using GenericoApp.Domain.Base;

namespace GenericoApp.Domain.FolhaPagamento
{
    public class Funcionario : Entity<Guid>
    {        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public decimal Salario { get; set; }
        public bool Ativo { get; set; }
        public Guid EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        protected Funcionario()
        {
                
        }

    }
}
