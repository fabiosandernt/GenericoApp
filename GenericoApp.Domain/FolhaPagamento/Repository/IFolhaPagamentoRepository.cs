
namespace GenericoApp.Domain.FolhaPagamento.Repository
{
    public interface IFolhaPagamentoRepository
    {        
        Task<string> CalculaSalarioLiquido(Guid idFuncionario);
    }
}
