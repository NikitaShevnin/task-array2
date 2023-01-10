//  Написать программу, которая из имеющегося массива строк формирует массив 
// из строк длина которых меньше либо равна 3 символа

string[] array1 = new string[5] {"rus", "2345", "hello", "fox", "res"};
string[] array2 = new string[array1.Length];

void array_enumeration(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void Print(string[] array) // обьявляем метод для вывода массива в строку
{
    System.Console.Write("Результаты перебора массива: "); // Вывод первичной информации для пользователя
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
array_enumeration(array1, array2);
Print(array2);