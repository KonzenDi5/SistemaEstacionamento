// Importa o namespace que contém a classe Estacionamento
using SistemaEstacionamento.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Variáveis para armazenar os preços do estacionamento
decimal precoInicial = 0;
decimal precoPorHora = 0;

// Solicita ao usuário que insira o preço inicial
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

// Solicita ao usuário que insira o preço por hora
Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear(); // Limpa a tela a cada iteração do loop
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    // Lê a opção escolhida pelo usuário
    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo(); // Chama o método para adicionar um veículo
            break;

        case "2":
            es.RemoverVeiculo(); // Chama o método para remover um veículo
            break;

        case "3":
            es.ListarVeiculos(); // Chama o método para listar os veículos
            break;

        case "4":
            exibirMenu = false; // Encerra o loop do menu
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine(); // Espera o usuário pressionar Enter antes de continuar para que ele possa ver a saída
}

Console.WriteLine("O programa se encerrou");
