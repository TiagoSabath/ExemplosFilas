
// -------- Fila ----------

Queue<int> fila = new Queue<int>();


fila.Enqueue(2);   //Adicionando um elemento na fila
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");  //Removendo sempre o primeiro elemento da fila

foreach (int item in fila)
{
    Console.WriteLine(item);
}


// -------- Pilha ----------

Stack<int> pilha = new Stack<int>();

pilha.Push(2);   //Adicionando um elemento
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}


// -------- Dictionary ----------

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("GO", "Goias");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("DF", "Distrito Federal");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

Console.WriteLine("----------------");

estados.Remove("GO");
estados["SP"] = "São Paulo - valor alterado"; // Alterando o valor 

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

    // Verificando se tem uma chave

string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existe: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe: {chave}");
}