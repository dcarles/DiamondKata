using System.Text;

namespace DiamondKata.Console;

public class DiamondService
{
    public string RenderDiamond(char c)
    {

        if (c == 'A')
            return RenderRow(1, 0);

        var diamond = new StringBuilder();

        //The total number of rows/letters is calculated by substracting the int value of 'A'
        //from the int value of max one passed argument plus 1
        int numberOfRows = c - 'A' + 1;

        //top half diamond (include middle row)
        for (var i = 0; i < numberOfRows; i++)
        {
            diamond.AppendLine(RenderRow(numberOfRows, i));
        }

        //bottom half diamond
        for (var i = numberOfRows - 2; i >= 0; i--)
        {
            diamond.AppendLine(RenderRow(numberOfRows, i));
        }

        return diamond.ToString();
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

