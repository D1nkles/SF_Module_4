(string name, int age) anketa;
Console.Write("Введите свое имя: ");
anketa.name = Console.ReadLine();
Console.Write("Введите ваш возраст: ");
anketa.age = int.Parse(Console.ReadLine());

Console.WriteLine("==============================================");

Console.WriteLine($"Ваше имя: {anketa.name}");
Console.WriteLine($"Ваш возраст: {anketa.age}");