// Exemplo 1 ---------------------

Console.WriteLine("\nExemplo 1:\n");

List<string> listaStrings = new List<string>();
listaStrings.Add("Um");
listaStrings.Add("Hello");
listaStrings.Add("World");
Console.WriteLine(listaStrings[0]);
Console.WriteLine(listaStrings[1]);
Console.WriteLine(listaStrings[2]);

// Exemplo 2 ---------------------

Console.WriteLine("\nExemplo 2:\n");

Queue<Object> q = new Queue<Object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());

// Exemplo 3 ---------------------

Console.WriteLine("\nExemplo 3:\n");

Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());

// Exemplo 4: -------------------

Console.WriteLine("\nExemplo 4:\n");

Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);
foreach (KeyValuePair<int, string> item in paises)
{
    int codigo = item.Key;
    string pais = item.Value;
    Console.WriteLine("Código {0} = {1}", codigo, pais);
}

// Exercicio 1: -------------------

Console.WriteLine("\nExercicio 1:\n");

string nomePais = "Brasil";
foreach (KeyValuePair<int, string> item in paises)
{
    if(item.Value.Equals(nomePais)){
        Console.WriteLine("O código do país é: {0}", item.Key);
    }
}

// Exercicio 2: -----------------

Console.WriteLine("\nExercicio 2:\n");

List<int> numerosLista = new List<int>();
numerosLista.Add(5);
numerosLista.Add(15);
numerosLista.Add(30);
numerosLista.Add(50);
numerosLista.Add(100);

double mediaLista = numerosLista.Average();
Console.Write("O numero medio é: {0}\n", mediaLista);
int TotalAcimaMedia = 0;

foreach (int numero in numerosLista)
{
    if (numero > mediaLista){
        TotalAcimaMedia++;
    }
}

Console.Write("A quantidade de valores acima da media sao: {0}", TotalAcimaMedia);

// Exercicio 3: ------------------------

Console.WriteLine("\nExercicio 3:\n");

List<int> numerosListaNova = new List<int>();

foreach (int numero in numerosLista)
{
    if (numero > mediaLista){
        numerosListaNova.Add(numero);
    }
}

foreach (int item in numerosListaNova)
{
    Console.Write("{0}, ", item);
}



