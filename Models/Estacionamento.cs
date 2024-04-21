using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionament
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;

         public Estacionament(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
        private List<string> veiculos = new List<string>();

        

        public void AdicionarVeiculo(string carro){
            veiculos.Add(carro);
        }

        public void RemoverVeiculo(string carro, int hf){
            if(veiculos.Any(veiculos => veiculos == carro))
            {
                veiculos.Remove(carro);
                decimal vl = (precoInicial * hf)/precoHora;
                Console.WriteLine($"\nSaida do veiculo com a Placa: {carro}\nTotal a pagar: R${vl}");
            }
            else
            {
                Console.WriteLine("\nEsse veiculo não se encontra estacionado");
            }
        }

        public void ListarVeiculo(){
            int cont=1;
            if(veiculos.Any())
            {
            Console.WriteLine("\n");
            foreach(string show in veiculos)
            {
                Console.WriteLine($"{cont}# {show}");
                cont++;
            }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}