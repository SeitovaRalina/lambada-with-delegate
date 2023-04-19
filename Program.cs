//С использованием делегата реализовать лямбда выражения для нахождения минимального, максимального, суммы, произведения и среднего арифметического трех чисел.

namespace lambada_with_delegate
{
    delegate double Operation(double a, double b, double c);
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation Max = (a, b, c) =>
            {
                double m = a;
                if (m < b) m = b;
                if (m < c) m = c;
                return m;
            };
            Operation Min = (a, b, c) =>
            {
                double m = a;
                if (m > b) m = b;
                if (m > c) m = c;
                return m;
            };
            Operation Sum = (a, b, c) => a + b + c;
            Operation Mult = (a, b, c) => a * b * c;
            Operation Average = (a, b, c) => (a + b + c)/3;

            Console.Write("Введите первое число: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Operation op = Max;
            Console.WriteLine($"Максимум 3-х чисел: {op(x,y,z)}");
            op = Min;
            Console.WriteLine($"Минимум 3-х чисел: {op(x, y, z)}");
            op = Sum;
            Console.WriteLine($"Сумма 3-х чисел: {op(x, y, z)}");
            op = Mult;
            Console.WriteLine($"Произведение 3-х чисел: {op(x, y, z)}");
            op = Average;
            Console.WriteLine($"Среднее арифметическое 3-х чисел: {op(x, y, z)}");
        }
    }
}