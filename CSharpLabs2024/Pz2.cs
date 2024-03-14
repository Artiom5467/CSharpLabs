
using System;

class Task1
{
    static void Main(string[] args)
    {
        
        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Введіть {i + 1}-е число:");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 1 && numbers[i] <= 16)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
        
        
    }
}

class Task2
{
    public static void task2()
    {
        double c = 5;
        double b = 8;
        double a = 12;
        
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Трикутник не трикутник");
            return;
        }
        
        double perimeter = a + b + c;
        double semiperimeter = perimeter / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        
        
        string triangleType;
        if (a == b && b == c)
        {
            triangleType = "Рівносторонній";
        }
        else if (a == b || a == c || b == c)
        {
            triangleType = "Рівнобедрений";
        }
        else
        {
            triangleType = "Різносторонній";
        }
        
        Console.WriteLine($"Периметр трикутника: {perimeter}");
        Console.WriteLine($"Площа трикутника: {area}");
        Console.WriteLine($"Вид трикутника: {triangleType}");
    }
}

class Task34
{
    public static void task3()
    {
        int n = 16;
        int m = 8;
        int[] numbers = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть {i + 1}-е число:");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        //3
        
        //
        // int min = numbers[0];
        // int max = numbers[0];
        // for (int i = 0; i < n; i++)
        // {
        //     if (numbers[i] < min)
        //     {
        //         min = numbers[i];
        //     }
        //     if (numbers[i] > max)
        //     {
        //         max = numbers[i];
        //     }
        // }
        // Console.WriteLine();
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write(numbers[i] + " ");
        // }
        // Console.WriteLine();
        // Console.WriteLine($"min: {min}");
        // Console.WriteLine($"max: {max}");

        int[] result = new int[n];
        int count = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (Math.Abs(numbers[i]) > m)
            {
                result[count] = numbers[i];
                count++;
            }
            
        }
        for (int i = 0; i < count; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
