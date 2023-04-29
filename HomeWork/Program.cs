// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.


int GetLenghtArray(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int lenght = GetLenghtArray("Введите количество элементов массива: ");

string[] FillArray(int length)
{
    string[] array = new string[length];
    Console.WriteLine("Введите элементы массива: ");
    for (var i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array, string message)
{
    Console.WriteLine(message);
    Console.WriteLine(string.Join(" ", array));
}

string[] FindElement(string[] array)
{
    int i = 0;
    string[] newArray = new string[lenght];
    foreach (string element in array)
    {
        if (element.Length <= 3)
        {
            newArray[i] = element;
            i++;
        }
    }
    return newArray;
}


string[] array = FillArray(lenght);

string[] newArray = new string[lenght];

PrintArray(array, "Наш массив: ");




