// Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B
//3, 5 -> 243(3*3*3*3*3)
//2,4 -> 16(2*2*2*2)



int GetNaturalDegree(int number, int multiplier)
{
    int answer = 1;
    for(int i = 1; i <=multiplier; i++ )
    {
        answer *=number;
    }
    return answer;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите сколько раз, нужно перемножить это число: ");
int multiplier = int.Parse(Console.ReadLine());
int answer = GetNaturalDegree(number, multiplier);
Console.WriteLine(answer);