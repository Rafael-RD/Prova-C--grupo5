using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProgramacao.Modelagem.Interfaces
{
    public enum Disponibilidade
    {
        Disponivel,
        Indisponivel
    }

    internal interface IDisponivel
    {
        Disponibilidade GetDisponibilidade();
    }
}
