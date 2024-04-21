internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Илья";
        string reversedName = "";
        int k = 0;
        for (int i = name.Length - 1; i >= 0; i--) 
        {
            reversedName += name[i];
        }
        Console.WriteLine(reversedName);
    }
}