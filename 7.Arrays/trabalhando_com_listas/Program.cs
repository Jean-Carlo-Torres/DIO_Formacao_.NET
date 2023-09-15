List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("ES");
listaString.Add("MS");


Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("ES");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");









// Console.WriteLine("FOR");
// for(int contador =0; contador < listaString.Count; contador++){
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("");

// Console.WriteLine("FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString){
//    Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//    contadorForeach++;
// }