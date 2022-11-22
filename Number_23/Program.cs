//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int num = int.Parse(Console.ReadLine());
if(num > 0){
    for (int i = 0; i <= num; i++)
    {
        int result = i*i*i;
        Console.WriteLine(result);
    }
} else if (num < 0)
{
    for (int i = 0; i >= num; i--)
    {
        int result = i*i*i;
        Console.WriteLine(result);
    }
} else {
    Console.WriteLine("0");
}
    

