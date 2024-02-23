//instruções básicas

//Declaração de Variáveis
int idade =10;
string nome;
string descricao = "";
var endereco = "";

nome = "nome teste";

//controles de fluxo
if (idade > 15)
{
    Console.WriteLine(nome);
    Console.WriteLine(descricao);
}

if (idade < 10)
{
    Console.WriteLine(nome);
}
else if (idade > 15)
{
    
}
else
{
    
}

var mesAno = 1;

switch (mesAno)
{
    case 1:
        Console.WriteLine("Tem o feriado do Ano Novo");
        break;
    case 4:
        Console.WriteLine("Tem o feriado de Tiradentes");
        break;
    default:
        break;
}

//Laços de repetição

var contador = 1;
while (contador <10)
{
    Console.WriteLine($"contador: {contador}");
    contador++;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

var listaNomes = new List<String>();
listaNomes.Add("Nome 1");
listaNomes.Add("Nome 2");
listaNomes.Add("Nome 3");
foreach (var s in listaNomes)
{
    Console.WriteLine(s);
}

//////////////////////////////////////////////
ExibirMensagem();
ExibirMensagemTexto("Teste parâmetro");
void ExibirMensagem()
{
    Console.WriteLine("Testando um método");
}

void ExibirMensagemTexto(string texto)
{
    Console.WriteLine(texto);
}

