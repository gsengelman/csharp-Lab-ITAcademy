int[] array = new int[5] { 10, 20, 30, 40, 50 };
int i = 0; 
foreach(int arr in array)
    {
        Console.WriteLine("Indice = " + i + " & Valor = " + arr);
        i++;
    }

// ----------------------------

string[] str = new string[3];
int iStr = 0;
str[0] = "Um";
str[1] = "Dois";
str[2] = "Tres";
foreach(string palavra in str)
{
    Console.WriteLine("Indice = " + iStr + " & Valor = " + palavra);
    iStr++;
}

//-----------------------------

DateTime[] dt = new DateTime[2];
int iDate = 0;
dt[0] = new DateTime(2002, 5, 1);
dt[1] = new DateTime(2002, 6, 1);
foreach(DateTime data in dt)
{
    Console.WriteLine("Indice = " + iDate + " & Data = " + data.ToShortDateString());
    iDate++;
}

//------------------------------

// Exercicio 1:

int[] array1 = new int[10] {10,20,30,40,50,60,70,80,90,100};
int[] array2 = new int[100];

Array.Copy(array1, array2, 10);
Console.WriteLine("Array 1: ");
foreach (int arr in array1)
{
    Console.WriteLine(arr);
}

Console.WriteLine("Array 2: ");
foreach (int arr in array2)
{
    Console.WriteLine(arr);
}

// -------------------------

