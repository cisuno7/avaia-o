using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AVALIACAO.Interface;

namespace AVALIACAO.Service
{
    public class CalculadoraService : CalculadoraInterface
    {
        public int RealizarSoma(int ValorA, int ValorB)
        {
            int Resultado = ValorA + ValorB;

            return Resultado;
        }

        public int RealizarSubtracao(int ValorA, int ValorB)
        {
            int Resultado = ValorA - ValorB;

            return Resultado;
        }

        public int RealizarMultiplicacao(int ValorA, int ValorB)
        {
            int Resultado = ValorA * ValorB;

            return Resultado;
        }

        public int RealizarDivisao(int ValorA, int ValorB)
        {
            int Resultado = ValorA / ValorB;

            return Resultado;
        }
    }
}