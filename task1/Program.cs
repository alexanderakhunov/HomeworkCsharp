//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите 1 число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2 число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if(FirstNumber > SecondNumber)
{
 Console.Write("Это число больше | " + FirstNumber);   
}
else
{
    Console.Write("Это число больше | " + SecondNumber);
}