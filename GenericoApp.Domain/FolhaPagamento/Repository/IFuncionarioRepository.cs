using GenericoApp.Domain.Base;

namespace GenericoApp.Domain.FolhaPagamento.Repository
{
    public interface IFuncionarioRepository : IRepository<Funcionario>
    {
        //calcula o salario liquido do funcionario
        Task<decimal> CalcularSalarioLiquidoAsync(Funcionario funcionario);
    }
}
