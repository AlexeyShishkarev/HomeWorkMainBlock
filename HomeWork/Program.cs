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
    for (var i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

