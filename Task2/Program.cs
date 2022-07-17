Console.WriteLine("Введите любое число от 1 до 99999");
string number = Console.ReadLine();
int a = int.Parse(number);

if (a>0 && a<100) Console.WriteLine("Третьего числа нет");
if (a>99 && a<1000)
{
    int a1 = a%10;
    Console.WriteLine(a1);
}
if (a>999 && a<10000) 
{
    int a1 = a/10%10;
    Console.WriteLine(a1);
}
if (a>9999 && a<100000)
{
    int a1 = a/100%10;
    Console.WriteLine(a1);
}