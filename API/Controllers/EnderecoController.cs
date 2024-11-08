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
        public EnderecoController(  IEnderecoService service)
        {
            _service= service;
        }

      
        /// <summary>
        /// Adiciona endereco do usuário 
        /// </summary>
        /// <param name="end"></param>
        [HttpPost("adicionar-Endereco")]
        public void AdicionarEndereco(Endereco end)
        {
            _service.AdicionarEndereco(end);
        }

        /// <summary>
        /// Lista os endereços dos usuários cadastrados 
        /// </summary>
        /// <returns></returns>

        [HttpGet("listar-Endereco")]
        public List<Endereco> ListarEndereco()
        {
           return _service.ListarEndereco();
        }


        /// <summary>
        /// Deleta o endereço selecionado por ID
        /// </summary>
        /// <param name="id"></param>
        /// 
        [HttpDelete("Remover-Endereco")]
        public void RemoverEndereco(int id)
        {
            _service.RemoverEndereco(id); 
        }

        /// <summary>
        /// Edita o endereço selecionado pelo usuário 
        /// </summary>
        /// <param name="P"></param>
        /// 

        [HttpPut("Editar-Endereco")]
        public void EditarEndereco(Endereco P)
        {
            _service.EditarEndereco(P);
        }
    }
}
