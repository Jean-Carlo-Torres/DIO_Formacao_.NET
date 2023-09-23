Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("RJ", "Rio de Janeiro");

     // var = KeyValuePair<string, string>
foreach(var item in estados){
    Console.WriteLine($"O estado {item.Key} tem o nome: {item.Value}");
}

Console.WriteLine("--------------------------");

// removendo elemento
estados.Remove("BA");

// alterando valor
estados["SP"] = "São Paulo - Alterado";

foreach(var item in estados){
    Console.WriteLine($"O estado {item.Key} tem o nome: {item.Value}");
}

Console.WriteLine("--------------------------");

string chave = "RJ";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave)){
    Console.WriteLine($"{chave}, existe no dicionario!");
} else {
    Console.WriteLine($"{chave}, não existe no dicionário.");
}

Console.WriteLine("--------------------------");

Console.WriteLine(estados["SP"]);