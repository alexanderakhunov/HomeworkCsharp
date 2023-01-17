//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите ваше число ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<1)
{System.Console.WriteLine("число должно  быть >1");}
for (int m =1; m <=num; m++)
{
    if (m % 2 ==0)
{
    System.Console.WriteLine(m);
}
}