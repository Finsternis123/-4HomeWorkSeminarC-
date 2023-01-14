//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine ("Enter number: "); 
int number = int.Parse (Console.ReadLine ()!);
Console.Write($"{GetSum(number)}");

int GetSum (int number)
{
    int sum = 0; 
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    
return sum;
}