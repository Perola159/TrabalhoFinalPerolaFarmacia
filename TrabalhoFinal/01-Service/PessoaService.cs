using CRUD_DAPPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{

    public class PessoaService
    {
        public PessoaRepository repository { get; set; }
        public EnderecoRepository enderecoRepository { get; set; }

        public PessoaService(string configuration)
        {
            repository = new PessoaRepository(configuration);
            enderecoRepository = new EnderecoRepository(configuration);
        }

        public void AdicionarPessoa(Pessoa P)
        {
            Endereco enderecoBanco = enderecoRepository.BuscarEndereco(P.ID);
            if (enderecoBanco != null)
            {
                repository.AdicionarContrib(P);
            }
            
        }


        public void RemoverPessoa(int id)
        {
            repository.DeletePessoa(id);
        }

        public List<Pessoa> ListarPessoa()
        {
            return repository.ListarPessoa();
        }

        public Pessoa BuscarPorId(int id)
        {
            return repository.BuscarPessoaPorId(id);
        }



        public void EditarPessoa(Pessoa P )
        {
            repository.EditarPessoa(P);
        }

       
    }
}
