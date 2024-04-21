string name = "Илья";
foreach (var character in name)
{
    Console.Write(character + " ");
    if (character == name.Last()) 
    {
        Console.WriteLine($"Последняя буква вашего имени: {character}");
    }
}