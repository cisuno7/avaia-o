using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AVALIACAO.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Amqp;

namespace AVALIACAO.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly CalculadoraInterface _calculadoraInterface;

        public CalculadoraController()
        {
        }

        public CalculadoraController(CalculadoraInterface calculadoraInterface)
        {
            _calculadoraInterface = calculadoraInterface;
        }

        // GET: Calculadora
        public ActionResult Calculadora()
        {
            return View();
        }

        public int Somar(int ValorA, int ValorB)
        {
            return _calculadoraInterface.RealizarSoma(ValorA, ValorB); ;
        }

        public int Subtrair(int ValorA, int ValorB)
        {
            return _calculadoraInterface.RealizarSubtracao(ValorA, ValorB);
        }

        public int Multiplicar(int ValorA, int ValorB)
        {
            return _calculadoraInterface.RealizarMultiplicacao(ValorA, ValorB);
        }

        public int Dividir(int ValorA, int ValorB)
        {
            return _calculadoraInterface.RealizarDivisao(ValorA, ValorB);
        }
    }
}