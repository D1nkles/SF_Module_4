var (name, age) = ("Евгения", 27);
Console.WriteLine("Ваше имя: {0}", name);
Console.WriteLine("Ваш возраст: {0}", age);

Console.WriteLine("==============================================");

Console.Write("Введите свое имя: ");
name = Console.ReadLine();
Console.Write("Введите ваш возраст: ");
age = int.Parse(Console.ReadLine());

Console.WriteLine("==============================================");

Console.WriteLine($"Ваше имя: {name}");
Console.WriteLine($"Ваш возраст: {age}");