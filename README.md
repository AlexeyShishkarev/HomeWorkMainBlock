# Задача:

##  p<>.Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:  <br>
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] <br>
[“1234”, “1567”, “-2”, “computer science”] → [“-2”] <br>
[“Russia”, “Denmark”, “Kazan”] → []

## Решение:

![блок схема](/BLOCK%20DIAGRAM.png)

----

Основной частью решения будет метод по нахождению нужного нам элемента и записью его в новый массив:
```
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
```
