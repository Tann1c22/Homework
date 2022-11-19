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
