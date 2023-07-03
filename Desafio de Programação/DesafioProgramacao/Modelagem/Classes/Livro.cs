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
        
        public Livro(string titulo, string autor)
        {
            Id = Interlocked.Increment(ref nextId);
            Titulo = titulo;
            Autor = autor;
            AlugadoPor = null;
        }

        public Livro() { }

        public bool isDisponivel()
        {
            return AlugadoPor == null;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Id: {Id}");
            if ( isDisponivel() ) Console.WriteLine("Alugado Por: Disponivel");
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
