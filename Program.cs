using System;
using System.Collections.Generic;
using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria a lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>
{
    new Pessoa("Hóspede 1", "Sobrenome1"),
    new Pessoa("Hóspede 2", "Sobrenome2")
};

// Cria a suíte
Suite suite = new Suite("Premium", 3, 30); // Capacidade para 3 pessoas, valor de 30 por diária

// Cria a reserva para 11 dias
Reserva reserva = new Reserva(11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor total da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");
