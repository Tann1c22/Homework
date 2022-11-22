//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num < 0) //Если число отрицательное, то убрать знак минус перед числом
{
    num = -num;
}
string number = Convert.ToString(num);

if (number.Length == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Да");
    } else {
        Console.WriteLine("Нет");
    }
} else {
    Console.WriteLine("Число не пятизначное");
}

//-------------------------------------------------------------------------//

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

/*Console.WriteLine("Введите координаты первой точки по x, y, z");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по x, y, z");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"{result:f2}");*/

//--------------------------------------------------------------------------------//

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 0)
{   
    for (int i = 0; i <= num; i++)
    {
        int result = i*i*i;
        Console.WriteLine(result);
    }
} else {
    for (int i = 0; i >= num; i--)
    {
        int result = i*i*i;
        Console.WriteLine(result);
    }
}*/