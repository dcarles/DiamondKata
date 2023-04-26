using DiamondKata.Console;

Console.WriteLine("Enter your Character for the Diamond:");

var diamondSeed = Console.ReadLine();

var diamondService = new DiamondService();

Console.WriteLine(diamondService.RenderDiamond(char.Parse(diamondSeed)));

Console.WriteLine("Press any Key to terminate");
Console.ReadLine();
