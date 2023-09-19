using System.Globalization;
using ExplorandoExemplos.Model;

CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

// Pessoa p1 = new Pessoa();
// p1.Nome = "Roronoa";
// p1.Sobrenome = "Zoro";
// // p1.NomeCompleto = ""; Somente leitura


// Pessoa p2 = new Pessoa();
// p2.Nome = "Monkey D.";
// p1.Sobrenome = "Luffy";

// Pessoa p1 = new Pessoa("Roronoa", "Zoro");
// Pessoa p2 = new Pessoa(nome:"Monkey D.", sobrenome: "Luffy"); // forma mais implicita


// Curso cursoDeJava = new Curso();
// cursoDeJava.Nome = "Curso de Java";
// cursoDeJava.Alunos = new List<Pessoa>();

// cursoDeJava.AdicionarAluno(p1);
// cursoDeJava.AdicionarAluno(p2);
// cursoDeJava.ListarAlunos();

decimal valorMonetario = 82.20m;
Console.WriteLine($"O valor monetário é {valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");



