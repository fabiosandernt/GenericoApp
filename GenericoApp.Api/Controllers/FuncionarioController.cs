using GenericoApp.Application.FolhaPagamento.Dtos;
using GenericoApp.Application.FolhaPagamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenericoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioSevice _funcionarioService;

        public FuncionarioController(IFuncionarioSevice funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpPost("criar")]
        public async Task<IActionResult> CriarFuncionario([FromQuery] FuncionarioDto funcionarioDto)
        {
            try
            {

                if (funcionarioDto == null)
                    return BadRequest("Funcionario não pode ser nulo");

                var novoFuncionario = await _funcionarioService.CreateFuncionarioAsync(funcionarioDto);
                
                return Ok(novoFuncionario);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Ocorreu um erro interno.");
            }
        }

        [HttpGet("listarTodos")]
        public async Task<IActionResult> ListarTodosFuncionarios()
        {
            try
            {
                var funcionarios = await _funcionarioService.GetAllFuncionarioAsync();

                return Ok(funcionarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
