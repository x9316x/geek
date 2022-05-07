// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символам.



// ввод массива с клавиатуры
string[] ArrayInput(int originalArrayLength)
{
    string[] originalArray = new string[originalArrayLength];

    for(int index = 0; index < originalArrayLength; index++)
    {
        Console.WriteLine("Введите " + (index + 1) + " элемент массива");
        string? arrayElementTempVaraible = Console.ReadLine();
        
        while(arrayElementTempVaraible == null)
        {
            arrayElementTempVaraible = Console.ReadLine();
        }
        
        originalArray[index] = arrayElementTempVaraible;
    }

    return originalArray;
}

// определяем количество элементов в изначальном массивеЫ
Console.WriteLine("Укажите количество элементов в предполагаемом массиве:");
int originalArrayLength = Convert.ToInt32(Console.ReadLine());

// вывод изначального массива
string[] originalArray = ArrayInput(originalArrayLength); 

for(int i = 0; i < originalArrayLength; i++)
{
    Console.Write(originalArray[i] + " "); 
} 
