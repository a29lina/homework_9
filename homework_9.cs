


void Recursion3(int number, int counter)
{
    if (counter > number) return;
    if (counter%3==0)
    {
    Console.Write($"{counter} ");
    }
    counter++;
    Recursion3(number, counter);
}

void RecursionSum(int number, int counter)
{
    if (counter > number) return;
    int sum = 0;
    while (counter <= number)
    {
    sum = sum + counter;
    counter++;
    }
    Console.WriteLine(sum);
    RecursionSum(number, counter);
}


int Ackermann (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else if (m > 0 && n>0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m,n);
}



//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.


void Zadacha64()
{
    Console.Write("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    
    Recursion3(N, M);
}


//Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.


void Zadacha66()
{
    Console.Write("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    RecursionSum(N, M);
}


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

void Zadacha68()
{
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Ackermann(m,n));

}

Zadacha68();


