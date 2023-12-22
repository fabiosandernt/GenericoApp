using GenericoApp.Domain.Base;
using GenericoApp.Domain.Base.ValueObjects;

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
        public Endereco Endereco { get; set; }

        //create funcionario
        public void Create(string nome, string cpf, DateTime dataNascimento, DateTime dataAdmissao, decimal salario, Guid empresaId)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            DataAdmissao = dataAdmissao;
            Salario = salario;
            EmpresaId = empresaId;
            Ativo = true;
        }

        protected Funcionario()
        {
                
        }

    }
}
