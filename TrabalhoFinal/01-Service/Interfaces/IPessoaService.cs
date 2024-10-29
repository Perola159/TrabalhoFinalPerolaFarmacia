using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface IPessoaService
    {
        void AdicionarPessoa(Pessoa P);
        void RemoverPessoa(int id);
        List<Pessoa> ListarPessoa();
        Pessoa BuscarPorId(int id);
        void EditarPessoa(Pessoa P);
    }
}
