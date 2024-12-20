﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._02_Repository.DATA
{
    public static class InicializadorBd
    {


        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=PerolinhaFarmacêutica.db"); // criar conexão

            string criarTabela = @"   
                CREATE TABLE IF NOT EXISTS Pessoas(
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                Username TEXT NOT NULL ,
                Senha TEXT NOT NULL,
                Email TEXT NOT NULL
               );";




            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Produtos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Preco DECIMAL NOT NULL,
                 QuantidadeEstoque INT NOT NULL
                );";

            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Enderecos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Rua TEXT NOT NULL,
                 Bairro TEXT NOT NULL,
                 Numero INTEGER NOT NULL,
                 PessoaID INTEGER NOT NULL
                );";

            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Carrinhos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdProduto INTEGER NOT NULL,
                 IdPessoa INTEGER NOT NULL                  
                );";

            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Vendas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdCarrinho INTEGER NOT NULL   
                );";


            criarTabela += @"   
                CREATE TABLE IF NOT EXISTS MetodoPagamentos (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT,
                Tipo TEXT,
                Ativo BOOLEAN,
                TaxaTransacao DECIMAL
             ); ";




            connection.Execute(criarTabela);
        }
    }
}

