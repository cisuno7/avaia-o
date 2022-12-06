using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVALIACAO.Interface
{
    public interface CalculadoraInterface
    {
        int RealizarSoma(int ValorA, int ValorB);
        int RealizarSubtracao(int ValorA, int ValorB);
        int RealizarMultiplicacao(int ValorA, int ValorB);
        int RealizarDivisao(int ValorA, int ValorB);
    }
}
