int[] arrayInteiro = new int[4];

arrayInteiro[0] = 10;
arrayInteiro[1] = 20;
arrayInteiro[2] = 30;
arrayInteiro[3] = 40;

// Copiando um array para outro
int[] arrayInteiroDobrado = new int[arrayInteiro.Length * 2];
Array.Copy(arrayInteiro, arrayInteiroDobrado, arrayInteiro.Length);
Console.WriteLine(arrayInteiroDobrado);

// REDIMENSIONAMENTO
// Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);

Console.WriteLine("Percorrendo o array com o FOR");
for(int contador = 0; contador < arrayInteiro.Length; contador++ ){
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiro[contador]}");
}

// Console.WriteLine();
// Console.WriteLine("Percorrendo o array com o FOREACH");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiro){
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }