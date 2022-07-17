Console.WriteLine("Введите трехзначное число от 1 до 999");
string number = Console.ReadLine();
int a = int.Parse(number);
int a1 = a%10;
int a2 = a/10%10;
Console.WriteLine(a2);

