
using Newtonsoft.Json;
using projeto.model;

#region Tipos nulos
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVendas)
// {
//     Console.WriteLine($" Id: {venda.Id}\n Produto: {venda.Produto}\n Preço: {venda.Preco}\n Data: {venda.DataVenda.ToString("dd/MM/yyyy MM:mm")}\n {(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}" : "")}");
//     Console.WriteLine("=====================================");
// }
#endregion

#region Tipo anônimo
// var listaAnonima = listaVendas.Select(venda => new
// {
//     venda.Produto,
//     venda.Preco
// });
// foreach (var venda in listaAnonima)
// {
//     System.Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }
#endregion

#region Tipos dinâmicos
// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
#endregion

#region Classes genéricas
// MyArray<int> arrayInteiro = new MyArray<int>();
// arrayInteiro.AdicionarElementoArray(50);
// Console.WriteLine(arrayInteiro[0]);

// MyArray<string> arrayString = new MyArray<string>();
// arrayString.AdicionarElementoArray("Texto");
// Console.WriteLine(arrayString[0]);
#endregion

#region Métodos de extensão
int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = $"O número {numero} é {(par ? "Par" : "Impar")}";
Console.WriteLine(mensagem);
#endregion