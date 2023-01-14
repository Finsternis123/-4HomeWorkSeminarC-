//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
Console.Write("Enter first number: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Enter second number: ");
int B = int.Parse(Console.ReadLine()!);

int C = 1;
for (int i = 0; i < B; i++)
{
    C *= A;
}

Console.Write($"Число {A} в степени {B} является {C}");
