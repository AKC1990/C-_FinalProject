// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



// Cоздадим метод для подсчета элементов массива определенной длины
int CountOfElements(string[] array, int n)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= n) count += 1;
    }
    return count;
}

// Метод для создания нового массива
string[] CreateNewArray(int Length)
{
    return new string[Length];
}

// Метод, заполняющий массив элементами определенный длины
string[] FillArray(string[] array, string[] newArray)
{
    for (int i = 0; i < array.Length; i++)
     {
        for (int j = 0; j < newArray.Length;)
        {
            if (array[i] <= n) 
            {
                newArray[j] = array[i];
                j++;
            }

        }
    }
    return newArray;
}

// Метод, печатающий новый массив
string[] PrintArray(string[] array)
{
    string result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }
    return result + "]";
}

// Клиентский код
string[] myArray = {"Hello", "2", "world", ":-)"};
int n = 3;
string[] newArray = FillArray(myArray, CreateNewArray(CountOfElements(myArray, n)));
Console.WriteLine(PrintArray(newArray));



