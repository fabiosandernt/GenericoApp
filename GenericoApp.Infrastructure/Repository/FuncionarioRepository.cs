
using GenericoApp.Domain.FolhaPagamento;
using GenericoApp.Domain.FolhaPagamento.Repository;
using GenericoApp.Infrastructure.Context;
using GenericoApp.Infrastructure.Database;

namespace GenericoApp.Infrastructure.Repository
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
