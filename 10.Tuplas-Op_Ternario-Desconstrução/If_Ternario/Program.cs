int numero = 20;
bool ehPar = false;

// if(numero % 2 == 0){
//     Console.WriteLine($"O número {numero} é PAR");
// } else {
//     Console.WriteLine($"O número {numero} é IMPAR");
// }

// COM IF TERNARIO
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "PAR" : "IMPAR"));