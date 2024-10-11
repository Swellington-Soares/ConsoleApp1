// See https://aka.ms/new-console-template for more information
using ConsoleApp1.models;
using System.Text;


Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Jesus", "Cristo");
Pessoa p2 = new Pessoa("Mathes", "Cristo");
Pessoa p3 = new Pessoa("Marcos", "Cristo");
Pessoa p4 = new Pessoa("Judas", "Cristo");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

Suite suite = new Suite( "Premium", 5, 150.0f );

Reserva reserva = new Reserva();
reserva.DiasReservados = 10;
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor da Diária: {reserva.CalcularValorDiaria():C}");

