// Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.

// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.
int[] FillArrayRnd()
{
    Random rndGenVal = new Random();
    int[] retVal = new int[rndGenVal.Next(2, 11)];

    for (int i = 0; i < retVal.Length; i++)
        retVal[i] = (int)rndGenVal.Next(100, 1000);

    return retVal;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountElements(int[] array)
{
    int count = 0;
    for(int i =0; i < array.Length; i++)
        if(array[i] %2 == 0) 
            count++;

    return count;
}
// -----------------

int [] myArray = FillArrayRnd();
PrintArray(myArray);
Console.WriteLine($"/n Количество чётных чисел в массиве: {CountElements(myArray)}");