using Tuplas.Model;

LeituraArquivo arquivo = new LeituraArquivo();

var (Sucesso, Linhas, QuantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
if (Sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {QuantidadeLinhas}");
    foreach (var linha in Linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

Console.WriteLine("=========================================");

// (int, string, string, double) tupla = (1,"Jean Carlo", "Torres", 1.65);
(int Id, string Nome, string Sobrenome, double Altura) tupla = (1, "Jean Carlo", "Torres", 1.65);
ValueTuple<int, string, string, double> outroExemplo = (2, "Roronoa", "Zoro", 1.75);
var outroExemploTuplaCreate = Tuple.Create(3, "Monkey D.", "Luffy", 1.65);

Console.WriteLine($"id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");