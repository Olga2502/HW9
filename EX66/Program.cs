//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.Clear();

int NaturNumb(int M, int N)
{
    if (M == N) return M;
    else
    {
        return NaturNumb(N + 1, M) + N;
    }
}

Console.WriteLine("Введите число от :  ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число до:  ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(NaturNumb(M, N));

