using projeto.model;
using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Notebook", 2500.00M, dataAtual);
// Venda v2 = new Venda(2, "Mouse", 100.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


// DESERIALIZAÇÃO
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
 List<Deserializacao> listaVenda = JsonConvert.DeserializeObject<List<Deserializacao>>(conteudoArquivo);
 foreach (Deserializacao item in listaVenda){
    Console.WriteLine($"ID: {item.Id}, Produto: {item.Produto} , Valor R${item.Preco}");
 }

