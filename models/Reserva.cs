using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Reserva
    {
        private List<Pessoa> Hospedes { set; get; }
        public Suite Suite { set; get; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count;
        }

        public double CalcularValorDiaria()
        {
            return Suite.ValorDiaria * DiasReservados;
        }

        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public Reserva()
        {
        }
    }
}
