// Напишите программу для работы с массивом вещественных чисел.

// Реализуйте класс ArrayOperations, который содержит следующие статические методы:

// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.

// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.

// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.

// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.

// Аргументы, передаваемые в метод/функцию:

// '3.17, 8.94, 2.36, 5.72, 0.85'
// На выходе:


// Массив:
// 3.17    8.94    2.36    5.72    0.85    
// Разность между максимальным и минимальным элементом = 8.09

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
            max = Math.Round(max, 1);
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
            min = Math.Round(min, 1);
        }
}

Console.WriteLine($"Итого {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round((max - min), 1)}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}