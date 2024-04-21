static void Main(string[] args) 
{
    (string name, string lastName, string login, int loginLength, bool hasPet, int age, string[] favoriteColors)User;
    
    Console.Write("Введите имя пользователя: ");
    User.name = Console.ReadLine();

    Console.Write("Введите фамилию пользователя: ");
    User.lastName = Console.ReadLine();

    Console.Write("Введите логин пользователя: ");
    User.login = Console.ReadLine();
    User.loginLength = User.login.Length;

    Console.WriteLine("Есть ли у вас животные? Да или Нет");
    string result = Console.ReadLine();
    if (result.ToLower() == "да")
    {
        User.hasPet = true;
    }
    else 
    {
        User.hasPet = false;
    }
}