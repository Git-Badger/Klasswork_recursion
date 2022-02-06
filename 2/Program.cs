Console.WriteLine("Рекурсивная f для определения суммы цифр числа N, введеного с клавиатуры");

int number;

Console.WriteLine("Введите число ");
number = int.Parse(Console.ReadLine());

int count(int N, int summ)
{
    if (N < 10) return N;
    summ = summ + count(N / 10, summ);
    return summ + N % 10;
}

Console.WriteLine($"Сумма цифр: {count(number, 0)}");