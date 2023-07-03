using DesafioProgramacao.Modelagem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b1 = new Biblioteca();

            int op=-1;

            while(op!=0)
            {
                Console.Write($"Menu:\n" +
                    $"1 - Adicionar Usuario\n" +
                    $"2 - Adicionar Livro\n" +
                    $"3 - Adicionar Emprestimo\n" +
                    $"4 - Remover Emprestimo\n" +
                    $"8 - Remover Usuario\n" +
                    $"9 - Remover Livro\n" +
                    $"0 - Sair\n" +
                    $"Escolha: ");
                op=int.Parse( Console.ReadLine() );
                Console.WriteLine();

                switch (op)
                {
                    case 0 :
                        break;
                    case 1 :
                        b1.AdicionarUsuario();
                        break;
                    case 2 :
                        b1.AdicionarLivro();
                        break;
                    case 3 :
                        b1.AdicionarEmprestimo();
                        break;
                    case 4 :
                        Console.Write("Id Livro: ");
                        b1.RemoverEmprestimo(b1.ReturnLivro(int.Parse(Console.ReadLine())));
                        break;
                    case 8 :
                        Console.Write("Id Usuario: ");
                        b1.RemoverUsuario(b1.ReturnUsuario(int.Parse(Console.ReadLine())));
                        break;
                    case 9 :
                        Console.Write("Id Livro: ");
                        b1.RemoverLivro(b1.ReturnLivro(int.Parse(Console.ReadLine())));
                        break;
                }
            }
        }
    }
}
