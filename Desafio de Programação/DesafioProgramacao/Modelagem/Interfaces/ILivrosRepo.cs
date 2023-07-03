using DesafioProgramacao.Modelagem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Interfaces
{
    internal interface ILivrosRepo
    {
        void AdicionarLivro();
        void RemoverLivro(Livro livro);
        void ListarLivros();
        void MostrarLivro(int id);
        Livro ReturnLivro(int id);
    }
}
