// Задание 25
/*
Console.Write("Введите два числа A и B: ");
int A =int.Parse(Console.ReadLine()!);
int B =int.Parse(Console.ReadLine()!);

int PowMethod(int x, int y){
    int res = 1;
    for (int i = 1; i <= y; i++){
        res *= A;
    }
    return res;
}
Console.WriteLine($"Число {A} в степени {B} = {PowMethod(A, B)}");
*/

//Задание 27
/*
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int Sum(int number){
    int count = 0;
    int temp;
    int res = 0;
    int number2 = number;
    for (int i = 0; number > 0; i++){
        number /= 10;
        count += 1;
    }
    for (int j = count; j >= 1; j--){
        temp = number2 / Convert.ToInt32(Math.Pow(10,j-1));
        number2 -= temp*Convert.ToInt32(Math.Pow(10,j-1));
        res += temp;
    }
    return res;
}
Console.Write("Сумма цифр в заданном числе = " + Sum(num));
*/

//Задание 29
/*
int[] mas = new int[8];

void Massive(int[] m){
    for (int i = 0; i < m.Length; i++){
        m[i]= new Random().Next(10);
    }
    for (int i = 0; i < m.Length; i++){
        Console.Write($"{m[i]} ");
    }
}
Massive(mas);
*/