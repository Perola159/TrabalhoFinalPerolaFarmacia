﻿using CRUD_DAPPER;
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

        public Pessoa FazerLogin(UsuarioLoginDTO usuarioLogin)
        {
            List<Pessoa> listUsuario = ListarPessoa();

            foreach (Pessoa usuario in listUsuario)
            {
                if (usuario.Username == usuarioLogin.Username
                     && usuario.Senha == usuarioLogin.Senha)
                {
                    return usuario;
                }

            }

            return null;
        }


        public void AdicionarPessoa(Pessoa P)
        {
            _repository.AdicionarPessoa(P);
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
