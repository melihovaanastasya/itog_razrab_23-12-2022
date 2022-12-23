// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.


void Print(string[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],7}");
}

void Cut(string[] a, string[] b)
{
    int j = 0;
    for (int i = 0; i < a.Length; i++)
        if ((a[i]).Length <= 3)
        {
            b[j] = a[i];
            j++;
        }
}

string[] a = { "Hello", "2", "world", ":-)" };
string[] b = new string[10];
Cut(a, b);
Print(b);