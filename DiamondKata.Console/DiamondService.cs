using System.Text;

namespace DiamondKata.Console;

public class DiamondService
{
    public string RenderDiamond(char c)
    {
        //If is not a letter return empty string
        if (!char.IsLetter(c))
        {
            return string.Empty;
        }

        //If is not uppercase, make it uppercase
        if (!char.IsUpper(c))
        {
            c = char.ToUpper(c);
        }

        //The total number of rows/letters is calculated by substracting the int value of 'A'
        //from the int value of max one passed argument plus 1
        int numberOfRows = c - 'A' + 1;

        //Get all diamond rows
        var lines = GetRows(numberOfRows);


        return string.Join(Environment.NewLine, lines) + Environment.NewLine;

    }

    private IEnumerable<string> GetRows(int numberOfRows)
    {
        if (numberOfRows == 1)
        {
            yield return RenderRow(1, 0);
            yield break;
        }

        //top half diamond (include middle row)
        for (var i = 0; i < numberOfRows; i++) yield return RenderRow(numberOfRows, i);
        //bottom half diamond
        for (var i = numberOfRows - 2; i >= 0; i--) yield return RenderRow(numberOfRows, i);
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

