using System;

class Desafio {
    static void Main() {
        string[] line = Console.ReadLine().Split(" ");
        double coxinhas = int.Parse(line[0]);
        double participantes = int.Parse(line[1]);
        double media = coxinhas / participantes;
        Console.WriteLine(media.ToString("N2"));
    }
}