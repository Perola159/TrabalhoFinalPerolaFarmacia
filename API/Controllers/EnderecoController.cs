using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades.DTOS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _service;

        /// <summary>
        /// Endpoint para criar usuarios no banco de dados 
        /// </summary>
        /// <param name="end"></param>
        /// 
        public EnderecoController(IEnderecoService service)
        {
            _service = service;
        }


        /// <summary>
        /// Adiciona endereco do usuário 
        /// </summary>
        /// <param name="end"></param>
        [HttpPost("adicionar-Endereco")]
        public IActionResult AdicionarEndereco(Endereco end)
        {
            try
            {
                _service.AdicionarEndereco(end);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro +" +
                    "o erro foi: " + erro.Message);

            }
            
        }

        /// <summary>
        /// Lista os endereços de um usuário específico pelo ID.
        /// </summary>
        /// <param name="id">ID do usuário cujos endereços serão listados.</param>
        /// <returns>Lista de endereços do usuário.</returns>
        [HttpGet("listar-endereco-por-id")]
        public IActionResult ListarEnderecoPorId(int id)
        {
            try
            {
                var enderecos = _service.ListarEnderecoPorId(id);

                if (enderecos == null || !enderecos.Any())
                {
                    return NotFound($"Nenhum endereço encontrado para o usuário com ID {id}.");
                }

                return Ok(enderecos);
            }
            catch (Exception erro)
            {
                return StatusCode(500, $"Ocorreu um erro ao listar os endereços: {erro.Message}");
            }
        }

        

        /// <summary>
        /// Deleta o endereço selecionado por ID
        /// </summary>
        /// <param name="id"></param>
        /// 
        [HttpDelete("Remover-Endereco")]
        public IActionResult RemoverEndereco(int id)
        {
            try
            {
                _service.RemoverEndereco(id);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro +" +
                    "o erro foi: " + erro.Message);

            }
        }

        /// <summary>
        /// Edita o endereço selecionado pelo usuário 
        /// </summary>
        /// <param name="P"></param>
        /// 

        [HttpPut("Editar-Endereco")]
        public IActionResult EditarEndereco(Endereco P)
        {
            try
            {
                _service.EditarEndereco(P);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro +" +
                    "o erro foi: " + erro.Message);

            }
        }
    }
}
