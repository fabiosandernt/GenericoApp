using GenericoApp.Application.FolhaPagamento.Dtos;
using GenericoApp.Domain.FolhaPagamento;

namespace GenericoApp.Application.Profile
{
    public class GenericoProfile : AutoMapper.Profile
    {
        public GenericoProfile()
        {
            CreateMap<Funcionario, FuncionarioDto>();
            CreateMap<FuncionarioDto, Funcionario>();

        }
    }
    
}
