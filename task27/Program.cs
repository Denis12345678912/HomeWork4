// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 ->11
// 82 -> 10
// 9012 ->12

int GetSumFigures(int number)
{
   
    while(number > 0)
    {
        
     
    }
    return sum;
}

int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetNumber("Введите число: ");
Console.WriteLine($"Сумма цифр, числа {number} = {GetSumFigures(number)}");