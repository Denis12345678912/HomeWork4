// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]; (Двухзначные числа)
//Сделать два варианта: 
//1)Генерация массива из 8 элементов 
//2) либо пользователь сам задаёт случайный размер массива, и дальше генерация



//Первый вариант
void ShowArray(int [] array)
{
    Console.Write("[ ");
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if(i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
      Console.Write("];");
}
int [] GetArray()
{
    Random rand = new Random();
    int [] array1 = new int [8];
    for(int i =0; i < array1.Length; i++)
    {
        array1[i] = rand.Next(0,100);
    }
    return array1;
}

int [] array =  GetArray();
  ShowArray(array);



