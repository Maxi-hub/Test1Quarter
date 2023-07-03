// Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


   
string[] GetArray(int length) 
{     
    string[] array = new string[length];     
    for (int i = 0; i < length; i++)     
    {         
        Console.WriteLine("Введите значения массива");
        array[i] = Console.ReadLine();     
    }     
    return array; 
}  
   
int GetLength() 
{     
    Console.WriteLine("Введите длину массива");     
    int length = Convert.ToInt32(Console.ReadLine());     
    return length; 
}  

int length = GetLength(); 
string[] array = GetArray(length); 
Console.WriteLine("[" + (String.Join(", ", array) + "]"));
