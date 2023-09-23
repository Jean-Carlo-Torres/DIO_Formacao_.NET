Queue<int> fila = new Queue<int>();
fila.Enqueue(2); // Adicionando um elemento na Fila (Frente)
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine("Elemento: {0}", item);
}

Console.WriteLine($"Removendo o elemento {fila.Dequeue()}"); // Remove o primeiro item da fila
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine("Elemento: {0}", item);
}
