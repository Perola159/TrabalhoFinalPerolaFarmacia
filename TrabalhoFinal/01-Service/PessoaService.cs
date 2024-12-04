using CRUD_DAPPER;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{

    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepositorycs _repository;
        private readonly IEnderecoRepository _repositoryEndereco;

        public PessoaService(IPessoaRepositorycs repository, IEnderecoRepository repositoryy)
        {
            _repository = repository;
            _repositoryEndereco = repositoryy;
        }


        public void AdicionarPessoa(Pessoa P)
        {
            
            Endereco enderecoBanco = _repositoryEndereco.BuscarEndereco(P.EnderecoId);

    
            if (enderecoBanco == null)
            {
                throw new Exception("Endereço não encontrado.");
            }

            // Validação simples de CPF
            if (!ValidarCPF(P.CPF))
            {
                throw new Exception("O CPF informado é inválido.");
            }

            // Se o endereço e o CPF forem válidos, adiciona a pessoa no banco
            _repository.AdicionarPessoa(P);
        }

        private bool ValidarCPF(string cpf)
        {
            // Remove qualquer caractere não numérico do CPF
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem 11 caracteres e se não é composto apenas por números iguais
            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            return true;
        }


        public void RemoverPessoa(int id)
        {
            _repository.DeletePessoa(id);
        }

        public List<Pessoa> ListarPessoa()
        {
            return _repository.ListarPessoa();
        }

        public Pessoa BuscarPorId(int id)
        {
            return _repository.BuscarPessoaPorId(id);
        }



        public void EditarPessoa(Pessoa P)
        {
            _repository.EditarPessoa(P);
        }


    }
}
