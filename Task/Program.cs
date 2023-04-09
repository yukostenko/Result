// Задача: написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.


// Метод печати одномерного массива
void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод печати 
int PrintData(string msg)
{
    Console.Write(msg);
    int line = int.Parse(Console.ReadLine() ?? "0");
    return line;
}