using DesafioProgramacao.Modelagem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Classes
{
    internal class Biblioteca : ILivrosRepo, IUsuariosRepo, IEmprestimosRepo
    {
        private static int nextId = 0;
        public int Id { get; private set; }
        private List<Livro> Livros { get; set; } = new List<Livro>();
        private List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        private List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

        public Biblioteca()
        {
            Id = Interlocked.Increment(ref nextId);
        }

        public void AdicionarUsuario()
        {
            Usuarios.Add(new Usuario().Criar());
            Console.WriteLine($"Id: {Usuarios[Usuarios.Count-1].Id}\n");
        }

        public void RemoverUsuario(Usuario usuario)
        {
            Usuarios.Remove(usuario);
        }

        public void MostrarUsuario(int id)
        {
            Usuarios.Single(u => u.Id == id).Mostrar();
        }

        public Usuario ReturnUsuario(int id)
        {
            return Usuarios.Single(u=>u.Id==id);
        }

        public void AdicionarLivro()
        {
            Livros.Add(new Livro().Cria());
            Console.WriteLine($"Id: {Livros[Livros.Count - 1].Id}\n");
        }

        public void RemoverLivro(Livro livro)
        {
            Livros.Remove(livro);
        }

        public void ListarLivros()
        {
            foreach (Livro livro in Livros)
            {
                Console.WriteLine(livro.Titulo);
            }
        }
        public void MostrarLivro(int id)
        {
            Livros.Single(l => l.Id == id).Mostrar();
        }

        public Livro ReturnLivro(int id)
        {
            return Livros.Single(l => l.Id == id);
        }

        public void AdicionarEmprestimo()
        {
            Emprestimos.Add(new Emprestimo().Criar(this));
            Console.WriteLine($"Id: {Emprestimos[Emprestimos.Count - 1].Id}\n");
        }

        public void RemoverEmprestimo(Livro livro)
        {
            Emprestimo emprestimo=Emprestimos.Single(e=>e.Livro==livro);
            Emprestimos.Remove(emprestimo);
        }

        public void MostrarEmprestimo(int id)
        {
            Emprestimos.Single(e=>e.Id==id).Mostrar();
        }

        public void MostrarEmprestimo(Livro livro)
        {
            Emprestimos.Single(e=>e.Livro==livro).Mostrar();
        }

        public void MostrarEmprestimo(Usuario usuario)
        {
            List<Emprestimo> emprestimosUsuario=Emprestimos.FindAll(e=>e.Usuario==usuario);
            foreach (Emprestimo emprestimo in emprestimosUsuario)
            {
                emprestimo.Mostrar();
            }
        }
    }
}
