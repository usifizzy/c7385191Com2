using ASE_Programming_Language;
using System.Drawing;

/// <summary>
/// Represents a command to draw a line.
/// </summary>
public class CommandDrawLine : ICommand
{
    private readonly Point start, end;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandDrawLine"/> class.
    /// </summary>
    /// <param name="start">The starting point of the line.</param>
    /// <param name="end">The ending point of the line.</param>
    public CommandDrawLine(Point start, Point end)
    {
        this.start = start;
        this.end = end;
    }

    /// <summary>
    /// Executes the command. This method is required by the ICommand interface.
    /// </summary>
    /// <param name="interpreter">The interpreter associated with the command.</param>
    /// <remarks>
    /// Handle non-graphical execution or throw an exception if not applicable.
    /// </remarks>
    public void Execute(Interpreter interpreter)
    {
        // Handle non-graphical execution or throw an exception
    }

    /// <summary>
    /// Executes the drawing command with the specified interpreter and graphics context.
    /// </summary>
    /// <param name="interpreter">The interpreter associated with the command.</param>
    /// <param name="graphics">The graphics context for drawing.</param>
    public void Execute(Interpreter interpreter, Graphics graphics)
    {
        // Draw a line using the specified points and a blue pen
        graphics.DrawLine(Pens.Blue, start, end);
    }

    /// <summary>
    /// Gets the variable name associated with the command.
    /// </summary>
    /// <returns>Null or an empty string if this command does not use a variable.</returns>
    public string GetVariableName()
    {
        // Return null or an empty string if this command does not use a variable
        return null;
    }
}
