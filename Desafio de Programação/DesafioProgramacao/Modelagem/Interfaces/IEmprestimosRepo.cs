using DesafioProgramacao.Modelagem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Interfaces
{
    internal interface IEmprestimosRepo
    {
        void AdicionarEmprestimo();
        void RemoverEmprestimo(Livro livro);
        void MostrarEmprestimo(int id);
        void MostrarEmprestimo(Livro livro);
        void MostrarEmprestimo(Usuario usuario);
    }
}
