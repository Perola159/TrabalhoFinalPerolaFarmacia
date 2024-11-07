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
        
        public EnderecoController(  IEnderecoService service)
        {
            _service= service;
        }

        /// <summary>
        /// Endpoint para criar usuarios no banco de dados 
        /// </summary>
        /// <param name="end"></param>
        /// 

        [HttpPost("adicionar-Endereco")]
        public void AdicionarEndereco(Endereco end)
        {
            _service.AdicionarEndereco(end);
        }

        [HttpGet("listar-Endereco")]
        public List<Endereco> ListarEndereco()
        {
           return _service.ListarEndereco();
        }

        [HttpDelete("Remover-Endereco")]
        public void RemoverEndereco(int id)
        {
            _service.RemoverEndereco(id); //controller chama a service passando --
                                        //parametro por id (que seria o id do time para executar a remoção)
        }

        [HttpPut("Editar-Endereco")]
        public void EditarEndereco(Endereco P)
        {
            _service.EditarEndereco(P);
        }
    }
}
