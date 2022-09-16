// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Array(int m, int n){
    if(m == 0){
        return n + 1;
    }
    if(n == 0 && m > 0){
        return Array(m - 1, 1);
    }
    if(m > 0 && n > 0){
        return Array(m - 1, Array(m, n - 1));
    }
    else{
        return 0;
    }
}

Console.WriteLine("Введите первое число (m): ");
int m = int.Parse(Console.ReadLine());
while(m < 0){
    Console.WriteLine("Введите неотрицательное число: ");
    m = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введите второе число (n): ");
int n = int.Parse(Console.ReadLine());
while(n < 0){
    Console.WriteLine("Введите неотрицательное число: ");
    n = int.Parse(Console.ReadLine());
}

Console.WriteLine("A(m,n) = " + Array(m, n));