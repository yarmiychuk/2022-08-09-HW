/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int numbersCount = 0;
int positivesCount = 0;
string input = string.Empty;

Console.Write("Введите число, или \"q\" для окончания ввода: ");
while ((input = Console.ReadLine()) != "q")
{
    if (!input.Equals("q"))
    {
        if (Convert.ToInt32(input) > 0)
            positivesCount++;
        numbersCount++;
        Console.Write("Введите следующее число, или \"q\" для выхода: ");
    }
}

Console.WriteLine($"Вы ввели чисел: {numbersCount}, из них {positivesCount} - больше нуля");