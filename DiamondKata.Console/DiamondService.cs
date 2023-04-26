using System.Text;

namespace DiamondKata.Console;

public class DiamondService
{
    public string RenderDiamond(char c)
    {
        if (c == 'A')
            return RenderRow(1, 0);
        else
            return RenderRow(2, 0) + Environment.NewLine +
                   RenderRow(2, 1) + Environment.NewLine +
                   RenderRow(2, 0) + Environment.NewLine;
    }

    public string RenderRow(int numberOfRows, int rowIndex)
    {
        var row = new StringBuilder();

        //We can use the numeric value of char to calculate next char in alphabetical order
        //then convert back to char
        var currentChar = (char)('A' + rowIndex);

        //External padding is calculated as per Readme analysis
        var externalPadding = (numberOfRows - rowIndex - 1);

        //left padding
        row.Append(new string(' ', externalPadding));

        row.Append(currentChar);

        //A is the only single char so dont need
        if (currentChar != 'A')
        {
            //Internal padding is calculated as per Readme analysis
            var internalPadding = (rowIndex * 2) - 1;
            row.Append(new string(' ', internalPadding));

            row.Append(currentChar);
        }

        //right padding
        row.Append(new string(' ', externalPadding));
        return row.ToString();
    }
}

