//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Sum1(int a, int b){
    int result = 0;
    for(int i = a; i <= b; ++i){
        result += i;
    }
    return result;
}
int Sum2(int a, int b){
    if (a <= b){
        return b + Sum2(b - 1, a);
    }    
    else{
        return 0;
    }
}
Console.WriteLine("Введите начальное число: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное число: ");
int n = int.Parse(Console.ReadLine());
while (n < m){
    Console.WriteLine("Введите число, которое больше начального: ");
    n = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.Write("Сумма чисел от " + m + " до " + n + " => ");
Console.Write(Sum1(m, n));