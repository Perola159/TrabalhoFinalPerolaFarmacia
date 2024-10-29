﻿using CRUD_DAPPER;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{

    public class PessoaService
    {
        private string _ConnectionString;

        public IPessoaRepositorycs Repository { get; set; }
        public EnderecoRepository enderecoRepository { get; set; }

        public PessoaService(string configuration)
        {
            Repository = new PessoaRepository(configuration);
            enderecoRepository = new EnderecoRepository(configuration);
        }

        public void AdicionarPessoa(Pessoa P)
        {
            Endereco endercoBanco = enderecoRepository.BuscarEndereco(P.EnderecoId);
            if(endercoBanco != null )
            {
                Repository.AdicionarPessoa(P);
            }    
        }


        public void RemoverPessoa(int id)
        {
            Repository.DeletePessoa(id);
        }

        public List<Pessoa> ListarPessoa()
        {
            return Repository.ListarPessoa();
        }

        public Pessoa BuscarPorId(int id)
        {
            return Repository.BuscarPessoaPorId(id);
        }



        public void EditarPessoa(Pessoa P )
        {
            Repository.EditarPessoa(P);
        }

       
    }
}
