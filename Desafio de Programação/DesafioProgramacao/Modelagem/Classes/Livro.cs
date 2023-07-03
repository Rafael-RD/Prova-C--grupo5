using DesafioProgramacao.Modelagem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Classes
{
    internal class Livro : IDisponivel, IMostrar
    {
        private static int nextId = 0;
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public Usuario AlugadoPor { get; private set; }
        
        public Livro(string titulo, string autor) : this()
        {
            Titulo = titulo;
            Autor = autor;
            AlugadoPor = null;
        }

        public Livro()
        {
            Id = ++nextId;
        }

        public Disponibilidade GetDisponibilidade()
        {
            if (AlugadoPor == null) return Disponibilidade.Disponivel;
            else return Disponibilidade.Indisponivel;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Id: {Id}");
            if ( GetDisponibilidade() == Disponibilidade.Disponivel ) Console.WriteLine("Alugado Por: Disponivel");
            else Console.WriteLine($"Alugado Por: {AlugadoPor}");
        }

        public Livro Cria()
        {
            Console.Write("Titulo: ");
            this.Titulo= Console.ReadLine();
            Console.Write("Autor: ");
            this.Autor= Console.ReadLine();

            return this;
        }
    }
}
