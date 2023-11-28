using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        // Construtor que recebe os preços iniciais e por hora do estacionamento
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para adicionar um veículo à lista de veículos
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();

            // Verifica se a placa já está na lista de veículos
            if (!veiculos.Contains(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"O veículo com placa {placa} foi estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Este veículo já está estacionado aqui.");
            }
        }

        // Método para remover um veículo da lista e calcular o preço total
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            // Verifica se a placa está na lista de veículos
            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Tenta converter a entrada do usuário para um número inteiro
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    // Calcula o preço total e remove a placa da lista
                    decimal valorTotal = precoInicial + precoPorHora * horas;
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida para a quantidade de horas.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        // Método para listar os veículos estacionados
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
