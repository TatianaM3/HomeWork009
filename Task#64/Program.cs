// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
string Numbers1(int a, int b){
    string result = String.Empty;
    for(int i = a; i <= b; ++i){
        result += $"{i} ";
    }
    return result;
}
string Numbers2(int a, int b){
    if (a <= b){
        return $"{a} " + Numbers2(a + 1, b);
    }    
    else{
        Console.WriteLine("Конечное число меньше начального :(");
        return String.Empty;
    
    }
}
Console.WriteLine("Введите начальное число: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Numbers1(m, n));
Console.WriteLine(Numbers2(m, n));