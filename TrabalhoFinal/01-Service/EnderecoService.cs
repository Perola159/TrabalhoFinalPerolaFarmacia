using CRUD_DAPPER;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{

    public class EnderecoService
    {
        public IEnderecoRepository repository { get; set; }

        public EnderecoService(string configuration)
        {
            repository = new EnderecoRepository(configuration);
        }

        public void AdicionarEndereco(Endereco P)
        {
            repository.AdicionarContrib(P);
        }


        public void RemoverEndereco(int id)
        {
            repository.DeleteEndereco(id);
        }

        public List<Endereco> ListarEndereco()
        {
            return repository.ListarEndereco();
        }

        public Endereco BuscarPorId(int id)
        {
            return repository.BuscarEndereco(id);
        }



        public void EditarEndereco(Endereco P )
        {
            repository.EditarEndereco(P);
        }

       
    }
}
