using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaControllers : ControllerBase
    {
        public readonly string _ConnectionString;
        private PessoaService _service;
        public PessoaControllers(IConfiguration configuration)
        {
            _ConnectionString = configuration.GetConnectionString("DefaultConnection");
            _service = new PessoaService(_ConnectionString);
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
            _service.RemoverPessoa(id); //controller chama a service passando --
                                        //parametro por id (que seria o id do time para executar a remoção)
        }

        [HttpPut("Editar-Pessoa")]
        public void EditarPessoa(Pessoa P)
        {
            _service.EditarPessoa(P);
        }
    }
}
