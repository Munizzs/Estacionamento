using System;
using Estacionamento.Models;

Console.WriteLine("----Bem Vindo ao Estacionamento----");

Console.WriteLine("\nDigite o preço inicial:");
decimal ini = decimal.Parse(Console.ReadLine());

Console.WriteLine("\nDigite o preço a hora:");
decimal hor = decimal.Parse(Console.ReadLine());

Estacionament est = new Estacionament(ini,hor);

int o=0;

do{
    Console.WriteLine("\n\n1. Cadastrar Veiculo\n2. Remover Veiculo\n3. Listar Veiculos\n0. Sair");
    o=int.Parse(Console.ReadLine());

    switch(o){
        case 1:
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string car = Console.ReadLine();
            est.AdicionarVeiculo(car);
        break;

        case 2:
            Console.WriteLine("\nDigite a placa do veículo para sair:");
            string carr = Console.ReadLine();

            Console.WriteLine("\nDigite quanto tempo ficou estacionado:");
            int hf = int.Parse(Console.ReadLine());

            est.RemoverVeiculo(carr,hf);
        break;

        case 3:
            est.ListarVeiculo();
        break;
    }
}while(o != 0);

