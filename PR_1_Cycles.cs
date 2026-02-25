internal class Program
{

    private static void Main(string[] args)
    {
        //1.Вывести в одну строку все нечётные числа от 11 до 20
        for (int i = 11; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        //2.Посчитать, сколько чисел от 1 до 100 включительно кратны 3'
        int count = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count + "\n");

        //3.Написать программу, которая показывает на экран квадрат числа, введённого пользователем
        Console.WriteLine("Введите число: ");
        int square = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(square, 2) + "\n");

        //4.Вывести на экран степени двойки до 1000
        int number = 1;
        while (number < 1000)
        {
            if (number < 1000)
            {
                Console.Write(number + " ");
            }
            number *= 2;
        }
        Console.WriteLine("\n");


        //5.Запросить пароль(целое число) до тех пор, пока не будет введён правильный пароль. 
        int truePassword = 123456;
        Console.WriteLine("Введите пароль: ");
        int password = Convert.ToInt32(Console.ReadLine());
        while (truePassword != password)
        {
            Console.WriteLine("Введите корректный пароль: ");
            password = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Введен верный пароль  {password}\n");

        //6.Вычислить сумму квадратов цифр в введённом числе
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num > 0)
        {
            sum += (int)Math.Pow(num % 10, 2);
            num /= 10;
        }
        Console.WriteLine("Сумма квадратов цифр в введённом числе = " + sum);

    }
}

