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

// Метод преобразования одномерного массива
string[] TransArr(string[] arr)
{
    int len = arr.Length;
    string[] resultArr = new string[len];
    for (int i = 0; i < arr.Length; i++)
    {
        int res = 0;
        res = arr[i].Length;
        if (res <= 3)
        {
            resultArr[i] = arr[i];
        }
    }
    return resultArr;
}

string[] initialArr = { "1234", "1567", "-2", "computer science"};
Print1DArr(initialArr);
string[] resultArr = TransArr(initialArr);
PrintData("Преобразованный массив:");
Print1DArr(resultArr);
