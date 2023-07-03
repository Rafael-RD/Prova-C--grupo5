using DesafioProgramacao.Modelagem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Classes
{
    internal class Emprestimo : IMostrar
    {
        private static int nextId = 0;
        public int Id { get; private set; }
        public Livro Livro { get; private set; }
        public Usuario Usuario { get; private set; }

        public Emprestimo(Livro livro, Usuario usuario)
        {
            Interlocked.Increment(ref nextId);
            Livro = livro;
            Usuario = usuario;
        }

        public Emprestimo() { }

        public Emprestimo Criar(Biblioteca biblioteca)
        {
            Console.Write("Id Livro: ");
            int idLivro=int.Parse(Console.ReadLine());
            Console.Write("Id Usuario: ");
            int idUsuario=int.Parse(Console.ReadLine());

            this.Livro=biblioteca.ReturnLivro(idLivro);
            this.Usuario=biblioteca.ReturnUsuario(idUsuario);

            return this;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Livro: {Livro.Titulo} Id: {Livro.Id}");
            Console.WriteLine($"Usuario: {Usuario.Name} Id: {Usuario.Id}");
        }
    }
}
