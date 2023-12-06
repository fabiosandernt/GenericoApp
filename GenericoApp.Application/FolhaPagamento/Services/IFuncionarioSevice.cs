using GenericoApp.Application.FolhaPagamento.Dtos;

namespace GenericoApp.Application.FolhaPagamento.Services
{
    public interface IFuncionarioSevice
    {
        Task<FuncionarioDto> CreateFuncionarioAsync(FuncionarioDto funcionarioDto);
        Task<FuncionarioDto> UpdateFuncionarioAsync(Guid id, FuncionarioDto funcionarioDto);
        Task<bool> DeleteFuncionarioAsync(Guid id);
        Task<FuncionarioDto> GetFuncionarioAsync(Guid id);
        Task<IEnumerable<FuncionarioDto>> GetAllFuncionarioAsync();
    }
}
