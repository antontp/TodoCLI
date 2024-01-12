using System.ComponentModel.DataAnnotations;

class ColorPrinter
{
    private Type type = typeof(ConsoleColor);
    public void WriteColorLine(string color, string value)
    {
        string middleValue = value.Substring(1, value.Length-1);

        // Start
        Console.Write("│");
        // Middle
        Console.BackgroundColor = (ConsoleColor) Enum.Parse(type, color);
        if (!String.Equals(color, "Black")) Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(value);

        // End
        Console.ResetColor();
        Console.WriteLine("│");
    }
}