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

// создание нового массива из строк,
// длинна которых меньше либо равна 3 символам.
string[] LessThanThreeArray(string[] originalArray)
{
    int LessThanThreeArrayLength = 0;

    // подсчёт количества элементов нового массива
    for(int index = 0; index < originalArray.Length; index++)
    {
       if(originalArray[index].Length <= 3)
       {
           LessThanThreeArrayLength++;
       }
    }
    
    // создание нового массива
    string[] LessThanThreeArray = new string[LessThanThreeArrayLength];

    int LessThanThreeArrayIndex = 0;

    for(int index = 0; index < originalArray.Length; index++)
    {
        if(originalArray[index].Length <= 3)
        {
            LessThanThreeArray[LessThanThreeArrayIndex] = originalArray[index];
            LessThanThreeArrayIndex++;
        }
    }
    
    return LessThanThreeArray;
}

// определяем количество элементов в исходном массивеЫ
Console.WriteLine("Укажите количество элементов в предполагаемом массиве:");
int originalArrayLength = Convert.ToInt32(Console.ReadLine());

// вывод исходного массива
string[] originalArray = ArrayInput(originalArrayLength); 

Console.WriteLine("Исходный массив:");
for(int i = 0; i < originalArrayLength; i++)
{
    Console.Write(originalArray[i] + " "); 
} 

Console.WriteLine("");

// вывод получившегося массива
string[] LessThreeArray = LessThanThreeArray(originalArray); 

Console.WriteLine("Массив из строк, длинна которых меньше либо равна 3 символам:");
for(int j = 0; j < LessThreeArray.Length; j++)
{
    Console.Write(LessThreeArray[j] + " "); 
} 
