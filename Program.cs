//. Задача 47

/*

 int[,] a = new int[5, 10];
 
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }

*/




/*

// Задача. 50

int chislo, n, c = 0;
            string s;
            Console.WriteLine("Ввод массива целых чисел и проверка числа(входит ли это число в массив).");
            Console.Write("Введите число, которое соответствует колличеству чисел в массиве: ");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            Console.WriteLine("Вводите массив: ");
 
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("-> ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                c = x[i];
            }
            Console.Write("Введите число какое вы хотите проверть, находится ли он в массиве или нет: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы вели число: " + chislo + " ,теперь ищем есть ли это число в массиве!");
            if (chislo != c)
            {
                Console.WriteLine("Такого числа нет!!!");
                Console.ReadKey();
                return;
            }
            foreach (int a in x)
                if (a == c)
                {
                    Console.WriteLine("Да ваше число совпадает с числом из массива!");
                    Console.WriteLine(c + " = " + chislo);
                }
*/




/*
// Задача 52.

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();

*/