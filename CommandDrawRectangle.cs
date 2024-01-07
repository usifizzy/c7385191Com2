using ASE_Programming_Language;
using System.Drawing;

/// <summary>
/// Represents a command to draw a rectangle.
/// </summary>
public class CommandDrawRectangle : ICommand
{
    private readonly int x, y, width, height;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandDrawRectangle"/> class.
    /// </summary>
    /// <param name="x">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="y">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public CommandDrawRectangle(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    /// <summary>
    /// Executes the command without graphical output.
    /// </summary>
    /// <param name="interpreter">The interpreter to execute the command.</param>
    public void Execute(Interpreter interpreter)
    {
        // Handle non-graphical execution or throw an exception
        // (Implementation details may be added here if necessary)
    }

    /// <summary>
    /// Executes the command with graphical output, drawing a rectangle.
    /// </summary>
    /// <param name="interpreter">The interpreter to execute the command.</param>
    /// <param name="graphics">The graphics object to draw on.</param>
    public void Execute(Interpreter interpreter, Graphics graphics)
    {
        // Draw a rectangle using the specified coordinates and dimensions
        graphics.DrawRectangle(Pens.Black, x, y, width, height);
    }

    /// <summary>
    /// Gets the name of the variable used by this command.
    /// </summary>
    /// <returns>
    /// Null or an empty string if this command does not use a variable.
    /// </returns>
    public string GetVariableName()
    {
        // Return null or an empty string if this command does not use a variable
        // (Implementation details may be added here if necessary)
        return null;
    }
}
