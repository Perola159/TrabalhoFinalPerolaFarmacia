using CRUD_DAPPER;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{

    public class EnderecoService : IEnderecoService
    {

        private readonly IEnderecoRepository repository;

        public EnderecoService(IEnderecoRepository configuration)
        {
            repository = configuration;
        }

        public void AdicionarEndereco(Endereco P)
        {
            repository.AdicionarContrib(P);
        }


        public void RemoverEndereco(int id)
        {
            repository.DeleteEndereco(id);
        }

        //public List<Endereco> ListarEndereco()
        //{
        //    return repository.ListarEndereco();
        //}
        public List<Endereco> ListarEnderecoPorId(int id)
        {
            return repository.ListarEnderecoPorId(id);
        }
        public Endereco BuscarPorId(int id)
        {
            return repository.BuscarEndereco(id);
        }



        public void EditarEndereco(Endereco P)
        {
            repository.EditarEndereco(P);
        }


    }
}
