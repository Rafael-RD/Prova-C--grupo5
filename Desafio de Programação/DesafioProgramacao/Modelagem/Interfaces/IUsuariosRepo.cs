using DesafioProgramacao.Modelagem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Interfaces
{
    internal interface IUsuariosRepo
    {
        void AdicionarUsuario();
        void RemoverUsuario(Usuario usuario);
        void MostrarUsuario(int id);
        Usuario ReturnUsuario(int id);
    }
}
