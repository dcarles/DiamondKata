using DiamondKata.Console;

var diamondService = new DiamondService();
Console.WriteLine(diamondService.RenderDiamond('A'));
Console.WriteLine();
Console.WriteLine(diamondService.RenderDiamond('C'));
Console.WriteLine();
Console.WriteLine(diamondService.RenderDiamond('H'));

Console.WriteLine("Press any Key to terminate");
Console.ReadLine();
