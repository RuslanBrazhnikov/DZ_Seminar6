// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите элементы(через пробел): ");

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// Array.ConvertAll - Преобразует массив одного типа в массив другого типа.
// .Split() - используется для разбиения на подстроки.

int n = 0;

int CountGreaterThanZero(int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            n++;
        }
    }
    return n;
}

int res = CountGreaterThanZero(n);
Console.WriteLine($"Кол-во элементов > 0 = {res}");

