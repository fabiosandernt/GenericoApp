using AutoMapper;
using GenericoApp.Application.FolhaPagamento.Dtos;
using GenericoApp.Domain.FolhaPagamento;
using GenericoApp.Domain.FolhaPagamento.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericoApp.Application.FolhaPagamento.Services
{
    public class FuncionarioService : IFuncionarioSevice
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IMapper _mapper;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository, IMapper mapper)
        {
            _funcionarioRepository = funcionarioRepository;
            _mapper = mapper;
        }

        public async Task<FuncionarioDto> CreateFuncionarioAsync(FuncionarioDto funcionarioDto)
        {
            if (funcionarioDto == null)
                throw new Exception("Funcionario nulo");

            var funcionario = _mapper.Map<Funcionario>(funcionarioDto);
           
            await _funcionarioRepository.SaveAsync(funcionario);                      
            
            return _mapper.Map<FuncionarioDto>(funcionario);

        }

        public Task<bool> DeleteFuncionarioAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FuncionarioDto>> GetAllFuncionarioAsync()
        {            
            var funcionarios = await _funcionarioRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<FuncionarioDto>>(funcionarios);
        }

        public Task<FuncionarioDto> GetFuncionarioAsync(Guid id)
        {
           var funcionario = _funcionarioRepository.GetByIdAsync(id);

            return _mapper.Map<Task<FuncionarioDto>>(funcionario);
        }

        public Task<FuncionarioDto> UpdateFuncionarioAsync(Guid id, FuncionarioDto funcionarioDto)
        {
            throw new NotImplementedException();
        }
    }
}
