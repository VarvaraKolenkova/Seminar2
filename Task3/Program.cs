Console.WriteLine("Введите текущий день недели в формате от 1 до 7, где понедельник=1, воскресенье=7");
string number = Console.ReadLine();
int a = int.Parse(number);

if (a==6 || a==7) Console.WriteLine("Сегодня выходной день");
else Console.WriteLine("Сегодня будний день");