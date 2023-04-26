namespace DiamondKata.Console;

public class DiamondService
{
    public string RenderDiamond(char c)
    {
        if (c == 'A')
            return "A";
        else
            return " A " + Environment.NewLine +
                   "B B" + Environment.NewLine +
                   " A " + Environment.NewLine;
    }
}

