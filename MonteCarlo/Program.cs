// See https://aka.ms/new-console-template for more information

using MonteCarlo;

Calculo c = new Calculo();

Console.WriteLine("Gerando Números!");

var pontos = c.GerarPontos(100000);

Console.WriteLine("Números Gerados!");

var pi = c.Aproximacao(pontos);

Console.WriteLine($"A Aproximação é {pi}");
