
try
{
    string[] linhas = File.ReadAllLines("Files/ArquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine($"Linha: {linha}");
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado!");
}

catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho das pasta não encontrado!");
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

finally{
    Console.WriteLine("Chegou até aqui");
}
