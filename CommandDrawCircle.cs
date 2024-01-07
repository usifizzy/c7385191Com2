using ASE_Programming_Language;
using System;
using System.Drawing;

/// <summary>
/// Represents a command to draw a circle.
/// </summary>
public class CommandDrawCircle : ICommand
{
    private string sizeArgument;
    private int x, y;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandDrawCircle"/> class.
    /// </summary>
    /// <param name="sizeArgument">The size argument for the circle.</param>
    /// <param name="x">The x-coordinate of the circle's center.</param>
    /// <param name="y">The y-coordinate of the circle's center.</param>
    public CommandDrawCircle(string sizeArgument, int x, int y)
    {
        this.sizeArgument = sizeArgument;
        this.x = x;
        this.y = y;
    }

    /// <summary>
    /// Executes the command. This method is required by the ICommand interface.
    /// </summary>
    /// <param name="interpreter">The interpreter associated with the command.</param>
    /// <remarks>
    /// This method might not be relevant for a drawing command,
    /// but it's required by the interface. You can decide how to handle it.
    /// One option is to throw an exception.
    /// </remarks>
    public void Execute(Interpreter interpreter)
    {
        // This method is not relevant for a drawing command,
        // but it's required by the interface. You can decide how to handle it.
        // One option is to throw an exception.
        throw new NotImplementedException("Non-graphical execution not supported for this command.");
    }

    /// <summary>
    /// Gets the variable name associated with the circle size. This method is required by the ICommand interface.
    /// </summary>
    /// <returns>The variable name associated with the circle size.</returns>
    public string GetVariableName()
    {
        return sizeArgument;
    }

    /// <summary>
    /// Executes the drawing command with the specified interpreter and graphics context.
    /// </summary>
    /// <param name="interpreter">The interpreter associated with the command.</param>
    /// <param name="graphics">The graphics context for drawing.</param>
    public void Execute(Interpreter interpreter, Graphics graphics)
    {
        int size;
        if (int.TryParse(sizeArgument, out size))
        {
            // sizeArgument is a literal number, so 'size' is already assigned here
        }
        else
        {
            // sizeArgument is a variable name
            size = interpreter.GetVariableValue(sizeArgument);
        }

        // Drawing logic using 'size'
        graphics.DrawEllipse(Pens.Black, 0, 0, size, size);
        // Drawing logic using 'size', 'x', and 'y'
        graphics.DrawEllipse(Pens.Black, x, y, size, size);
    }
}
