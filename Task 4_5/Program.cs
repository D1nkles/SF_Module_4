class Program
{
    static void Main(string[] args)
    {
        (string name, string lastName, string login, int loginLength, bool hasPet, int age, string[] favoriteColors) User;

        for (int count = 0; count < 3; count++)
        {
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

            Console.Write("Введите возраст пользователя: ");
            User.age = int.Parse(Console.ReadLine());

            User.favoriteColors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя:");
            for (int i = 1; i <= User.favoriteColors.Length; i++)
            {
                Console.Write($"{i}. ");
                User.favoriteColors[i - 1] = Console.ReadLine();
            }
            Console.WriteLine("====================================================");
        }
    }
}