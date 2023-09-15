Console.WriteLine("=== TABUADA ===");

Console.WriteLine("Digite um número: ");

string input = Console.ReadLine();
int.TryParse(input, out int numero);

int contador = 0;

while(contador <= 10){
    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
    contador++;

    // if(contador == 5){
    //     break;
    // }
}

