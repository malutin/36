// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray() // функция создания массива и заполнение его случайными цифрами 
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]}"); // исключение запятой в конце
        }
    }
    return array;
}


int Sumnum(int[] array) // функция сложения элементов, стоящих на нечётных позициях.
{
    int Sum = 0;
    for (int i = 1; i < array.GetLength(0); i = i + 2)
    {
        Sum = Sum + array[i];
    }
    return Sum;
}

int[] mas = FillArray();
int x = Sumnum(mas);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях {x}");