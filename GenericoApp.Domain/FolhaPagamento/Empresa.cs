using GenericoApp.Domain.Base;
using GenericoApp.Domain.Base.ValueObjects;

namespace GenericoApp.Domain.FolhaPagamento
{
    public class Empresa : Entity<Guid>
    {        
        public string Nome { get; set; }
        public string Cnpj { get; set; }        
        public bool Ativo { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
        public Endereco Endereco { get; set; }

        protected Empresa()
        {
                
        }
    }
}
