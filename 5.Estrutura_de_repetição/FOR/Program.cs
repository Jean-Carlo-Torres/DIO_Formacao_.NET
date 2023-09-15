
Console.WriteLine("=== TABUADA ===");

Console.WriteLine("Digite um número: ");
string input = Console.ReadLine();
int.TryParse(input, out int numero);

for (int contador = 0; contador <= 10; contador++){
    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
}
