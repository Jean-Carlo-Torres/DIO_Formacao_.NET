
// OR
// bool idadeMinima = true;
// bool autorizacaoDoResponsavel = false;

// if(idadeMinima  || autorizacaoDoResponsavel){
//     Console.WriteLine("Entrada autorizada");
// } else {
//     Console.WriteLine("Entrada não permitida");
// }
// ====================================================
// AND
// bool possuiPresencaMinima = true;
// int nota = 7;
// int media = 7;
// int recuperacao = 6;

// if(possuiPresencaMinima && nota >= media){
//     Console.WriteLine($"Aprovado com média de: {nota}");  
// } else if(recuperacao <= nota){
//     Console.WriteLine($"Média {nota}, você precisa fazer a recuperação!");
// } else {
//     Console.WriteLine($"Reprovado, com média {nota}");
// }
// ====================================================
// NOT
bool choveu = false;
bool estaTarde = false;

if(!choveu && !estaTarde){
    Console.WriteLine("Vou pedalar");
} else {
    Console.WriteLine("Não vou pedalar hoje!");
}