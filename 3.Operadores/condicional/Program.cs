Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "e" :
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
    Console.WriteLine("Consoante");
    break;
}




// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u"
// ){
//      Console.WriteLine("Vogal");
// } else{
//     Console.WriteLine ("Consoante");
// }



// if(letra == "a"){
//    
// } else if(letra == "e"){
//     Console.WriteLine("Vogal");
// } else if(letra == "i"){
//     Console.WriteLine("Vogal");
// } else if(letra == "o"){
//     Console.WriteLine("Vogal");
// } else if(letra == "u"){
//     Console.WriteLine("Vogal");
// } else {
//     Console.WriteLine("Consoante"); 
// }



// int produtoEmEstoque = 10;
// int quantidadeVenda = 4;
// bool possivelVenda = quantidadeVenda > 0 && produtoEmEstoque >= quantidadeVenda;

// Console.WriteLine($"Quantidade em estoque: " + produtoEmEstoque);
// Console.WriteLine($"Quantidade de compra: " + quantidadeVenda);
// Console.WriteLine($"É possivel realizar a venda: " + possivelVenda);

// if(quantidadeVenda == 0){
//     Console.WriteLine("Venda inválida");
// } 
// else if(possivelVenda){
//     Console.WriteLine("Venda realizada");
// }
// else{
//     Console.WriteLine("Produto esgotado!");
// }
