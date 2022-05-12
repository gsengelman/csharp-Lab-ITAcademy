// Exercicio 1

float f = 3F;
double d = 2.22;
decimal e = 44;
Console.WriteLine("float: " + f + " double: " + d + " decimal :" + e);

// Exercicio 2 e 3

DateTime novaData = new DateTime(2022, 5, 13);
string novaDataFormatada = novaData.ToString("MMMM dd, yyyy"); // formata para mes dia, ano
Console.WriteLine("Tomorrow is " + novaDataFormatada + ".");

DateTimeOffset novaDataHora = new DateTimeOffset(2022, 5, 13, 14, 00, 00, 00, TimeSpan.Zero);
string novaDataHoraFormatada = novaDataHora.ToString("MM/dd/yy H:mm:ss"); // formata para mes/dia/ano hora/min/seg
Console.WriteLine("The next class begins at: " + novaDataHoraFormatada);

// Exercicio 4

int i = 10;
float fi = 0;
f = i; // conversão implícita, sem perda de dados;
System.Console.WriteLine(fi);
f = 0.5F;
i = (int) f; // conversão explícita, com perda de dados.
System.Console.WriteLine(i);

// Exercicio 5

string stringInteiro = "123456789";
int valorStringInteiro = Convert.ToInt32(stringInteiro);
Console.WriteLine(valorStringInteiro);
Int64 valorInt64 = 123456789;
int valorInt = Convert.ToInt32(valorInt64);
Console.WriteLine(valorInt);

string stringInteiroGrande = "999999999999999999999999999999999999999999999";
// causa erro
int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);

// Exercicio 6

string stringInteiro2 = "123456789";
int valorStringInteiro2;
bool conversao1 = Int32.TryParse(stringInteiro2, out valorStringInteiro2);
Console.WriteLine("Conversão efetuada:" + conversao1 + " valor: " + valorStringInteiro);

string stringInteiroGrande2 = "9999999999999999999999999999999999999999999999";
int valorStringInteiroGrande2;
bool conversao2 = Int32.TryParse(stringInteiroGrande2, out valorStringInteiroGrande2);
Console.WriteLine("Conversão efetuada:" + conversao2 + " valor: " + valorStringInteiroGrande2);

string stringLetras = "abc";
double valorStringLetras;
bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);

// Exercicio 7

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);
Console.WriteLine("Conversao explicita = " + valorInteiro1);
Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);

// Exercicio 8

int x = 10;
double y = 3.4;
Console.WriteLine("{0}  {1}", x, y);
// o trecho imprime na tela os numeros em sequencia de acordo com sua ordem