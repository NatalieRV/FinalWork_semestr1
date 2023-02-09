// Из имеющегося массива строк сформировать новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

int GetNumberByUser()
{
    Console.Write("Введите количество слов (N): ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите слово {i + 1}: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int number = GetNumberByUser();
string[] array = new string[number];
Console.WriteLine();
FillArray(array);
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count = count + 1;
    }
}
string[] arrayNew = new string[count];
int positionArrayNew = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        arrayNew[positionArrayNew] = array[i];
        positionArrayNew = positionArrayNew + 1;
    }

if (count == 0) Console.WriteLine("Нет данных, удовлетворяющих условию задачи");
else
{
    Console.WriteLine("Новый массив");
    PrintArray(arrayNew);
}
