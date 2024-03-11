// Screen Sound
string mensagemDeBoasVindas = "Sejá bem vindo, o que deseja ouvir hoje!";
// List<string> listaDasBandas = new List<string> { "Linking Park", "The Beatles" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>
{
    {"Linking Park", new List<int>{9, 10, 7 }},
    {"Super Combo", new List<int>{10, 8, 7}},
};


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();

Console.Write("\nDigite sua opção: ");
string opcaoEscolhida = Console.ReadLine()!;
int opcaoNumericaEscolhida = int.Parse(opcaoEscolhida);


switch (opcaoNumericaEscolhida)
{
    case 1:
        RegistrarBanda();
        break;
    case 2:
        MostrarBandasRegistradas();
        break;
    case 3:
        AvaliarUmaBanda();
        break;
    case 4:
        Console.WriteLine("Você digitou a opção:" + opcaoEscolhida);
        break;
    case -1:
        Console.WriteLine("Até mais :)");
        break;
    default:
        Console.WriteLine("Opção invalida");
        break;
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar Banda");
    Console.Write("Digite o nome da banda que deseja registrar:");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");
    // for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //  Console.WriteLine($"Bandas: {listaDasBandas[i]}");
    //}
    foreach (string bandas in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Bandas: {bandas}");
    }
    Console.WriteLine("\nDigite uma tecla para volta para o menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome de uma banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;  
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"\nEssa banda informada {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Aperte uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}





