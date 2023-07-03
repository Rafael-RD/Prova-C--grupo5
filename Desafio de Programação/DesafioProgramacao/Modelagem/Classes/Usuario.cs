using DesafioProgramacao.Modelagem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Classes
{
    internal class Usuario : IMostrar
    {
        private static int nextId = 0;
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Usuario(string name)
        {
            Id = Interlocked.Increment(ref nextId);
            Name = name;
        }

        public Usuario() { }

        public void Mostrar()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Id: {Id}");
        }

        public Usuario Criar()
        {
            Console.WriteLine("Nome: ");
            this.Name=Console.ReadLine();
            return this;
        }
    }
}
