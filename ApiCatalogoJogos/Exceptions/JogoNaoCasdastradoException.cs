using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoNaoCasdastradoException : Exception
    {
        public JogoNaoCasdastradoException() : base("Este jogo já está cadastrado") { }
    }
}
