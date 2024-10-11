using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Suite
    {
        public string TipoSuite;
        public int Capacidade;
        public double ValorDiaria;
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, double valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
