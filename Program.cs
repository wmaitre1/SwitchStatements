// See https://aka.ms/new-console-template for more information
Console.WriteLine($"What is your favorite school subject");
var response = Console.ReadLine();

switch (response)
{
    case "English":
        Console.WriteLine($"English is okay!");
        break;

    case "Math":
        Console.WriteLine($"Math is hard for me.  Glad you enjoy it.");
        break;

    case "Science":
        Console.WriteLine($" Science that is my favoirte one as well");
        break;

    case "Social Studies":
        Console.WriteLine($"Not my favorite, but I like that one too");
        break;

    default:
        Console.WriteLine($"Never heard of that subject before.");
        break;
       
}
