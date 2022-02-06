Console.WriteLine("Написать рекурсивную функцию показа чисел от 1 до N. N задано");

int number;

Console.WriteLine("Введите число: ");
number = int.Parse(Console.ReadLine());

void countBackward(int N)
{
    if (N >= 1)
    {
        Console.WriteLine(N);
        countBackward(N - 1);
    }
}

void countForward(int start, int end)
{
    if (end >= start)
    {
        Console.WriteLine(start);
        countForward(start + 1, end);
    }
}

Console.WriteLine($"Посчитаем от {number} до единицы");
countBackward(number);
Console.WriteLine($"Посчитаем от единицы до {number}");
countForward(1, number);

