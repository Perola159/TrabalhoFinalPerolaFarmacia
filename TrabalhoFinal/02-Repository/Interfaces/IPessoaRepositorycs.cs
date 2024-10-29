using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository.Interfaces
{
    public interface IPessoaRepositorycs
    {
        void AdicionarPessoa(Pessoa P);
        List<Pessoa> ListarPessoa();
        Pessoa BuscarPessoaPorId(int id);
        void EditarPessoa(Pessoa P);
        void DeletePessoa(int id);
    }
}
