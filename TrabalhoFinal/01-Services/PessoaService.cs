using CRUD_DAPPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services
{

    public class PessoaService
    {
        public PessoaRepository repository { get; set; }

        public PessoaService(string configuration)
        {
            repository = new PessoaRepository(configuration);
        }

        public void AdicionarPessoa(Pessoa P)
        {
            repository.AdicionarContrib(P);
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
            return repository.BuscarPessoa(id);
        }



        public void EditarPessoa(Pessoa P )
        {
            repository.EditarPessoa(P);
        }

       
    }
}
