using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades.DTOS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        public readonly string _ConnectionString;
        private EnderecoService _service;
        public EnderecoController(IConfiguration configuration)
        {
            _ConnectionString = configuration.GetConnectionString("DefaultConnection");
            _service = new EnderecoService(_ConnectionString);
        }


        [HttpPost("adicionar-Endereco")]
        public void AdicionarEndereco(Endereco P)
        {
            _service.AdicionarEndereco(P);
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
