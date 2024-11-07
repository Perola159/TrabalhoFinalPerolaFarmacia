using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        public readonly  IPessoaService _service;

        public PessoaController(IPessoaService config)
        {
            _service = config; //injecao de independecia aplicada 
        }


            [HttpPost("adicionar-pessoa")]
        public void AdicionarPessoa(Pessoa P)
        {
            _service.AdicionarPessoa(P);
        }

        [HttpGet("listar-Pessoa")]
        public List<Pessoa> ListarPessoa()
        {
           return _service.ListarPessoa();
        }

        [HttpDelete("Remover-pessoa")]
        public void RemoverPessoa(int id)
        {
            _service.RemoverPessoa(id); 
        }

        [HttpPut("Editar-Pessoa")]
        public void EditarPessoa(Pessoa P)
        {
            _service.EditarPessoa(P);
        }
    }
}
