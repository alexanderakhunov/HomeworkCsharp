// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 1 число");
int FirstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int SecondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int TheirdNum = Convert.ToInt32(Console.ReadLine());
int max = FirstNum;
if (SecondNum > max)
{
    max = SecondNum;
}
if (TheirdNum > max)
{
    max = TheirdNum;
}
Console.Write(max);
