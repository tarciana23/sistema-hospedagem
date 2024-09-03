using System.Text;
using sistema_hospedagem.Modelos;

Console.OutputEncoding = Encoding.UTF8;

//Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

//Adicionando as pessoas a lista de hóspedes
hospedes.Add(p1);
hospedes.Add(p2);

//Criando suite
Suite suite = new Suite(tipoSuite: "Premium",capacidade:2,valorDiaria:30);

//Cria uma nova Reserva, passando a suite e os hospedes

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibindo a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
