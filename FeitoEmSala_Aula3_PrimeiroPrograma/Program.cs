Console.WriteLine("Bem vindo à nossa calculadora da FIAP - Turma 2TDSPX");

var controleExecucao = true;
var listaExecucoes = new List<String>();
while (controleExecucao)
{

    Console.WriteLine();
    Console.WriteLine("Digite 1 para: Digitar dois números para retornar a soma entre os dois");
    Console.WriteLine("Digite 2 para: Digitar dois números para retornar a subtração entre os dois");
    Console.WriteLine("Digite 5 para: Retornar todas as operações realizadas");
    Console.WriteLine("Digite 6 para: Sair do programa");

    var opcaoEscolhida = int.Parse(Console.ReadLine());

//Console.WriteLine("A opção escolhida foi: " + opcaoEscolhida);

    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Digite o primeiro número: ");
            double primeiroNumeroSoma = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double segundoNumeroSoma = double.Parse(Console.ReadLine());

            var resultado = primeiroNumeroSoma + segundoNumeroSoma;

            //Console.WriteLine("O resultado é:" + resultado + ". Você gostou dessa forma na opção" + opcaoEscolhida);
            var mensagem1 = $"O resultado é {resultado}. Você gostou dessa forma na opção {opcaoEscolhida}?";
            Console.WriteLine(mensagem1);
            listaExecucoes.Add(mensagem1);
            //Console.WriteLine(string.Format("O resultado é {0}. Você gostou dessa forma na opção {1}", resultado, opcaoEscolhida));
            break;
        case 2:
            Console.WriteLine("Digite o primeiro número: ");
            double primeiroNumeroSub = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double segundoNumeroSub = double.Parse(Console.ReadLine());

            var resultadoSub = primeiroNumeroSub - segundoNumeroSub;

            //Console.WriteLine("O resultado é:" + resultado + ". Você gostou dessa forma na opção" + opcaoEscolhida);
            var mensagem2 = $"O resultado é {resultadoSub}. Você gostou dessa forma na opção {opcaoEscolhida}?";
            Console.WriteLine(mensagem2);
            listaExecucoes.Add(mensagem2);
            break;
        case 5:
            Console.WriteLine();
            Console.WriteLine("A lista de tarefas executadas é:");
            Console.WriteLine();

            foreach (var execucao in listaExecucoes)
            {
                Console.WriteLine($"Executado em: {DateTime.Now.ToString("dd/MM/yyyy")}: {execucao}");
            }
            break;
        case 6:
            controleExecucao = false;
            break;
        default:
            break;
    }
}