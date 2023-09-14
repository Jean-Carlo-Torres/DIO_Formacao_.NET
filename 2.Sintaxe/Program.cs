
using _2.Sintaxe.Models;

string mensagem = "Good morning, Welcome";
int quantidade = 5;
decimal valor = 49M;
double altura = 1.5;
bool condicao = true;

Console.WriteLine(mensagem);
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("Valor: " + valor);
Console.WriteLine("Altura: " + altura.ToString("0.00"));
Console.WriteLine("Liberado para venda: " + condicao);

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy MM:mm"));


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Luffy";
// pessoa1.Idade = 19;
// pessoa1.Apresentar();
