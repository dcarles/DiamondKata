using DiamondKata.Console;

var diamondService = new DiamondService();

Console.WriteLine("Enter your Character for the Diamond:");

var input = Console.ReadLine();
var validInput = char.TryParse(input, out var diamondSeed);

if(validInput)
Console.WriteLine(diamondService.RenderDiamond(diamondSeed));
else
    Console.WriteLine("You provided more than one character, please provide just one letter");

Console.WriteLine("Press any Key to terminate");
Console.ReadLine();
