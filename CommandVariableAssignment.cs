using ASE_Programming_Language;
using System.Drawing;

/// <summary>
/// Represents a command to assign a value to a variable.
/// </summary>
public class CommandVariableAssignment : ICommand
{
    private string variableName;
    private int value;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandVariableAssignment"/> class.
    /// </summary>
    /// <param name="variableName">The name of the variable to assign the value to.</param>
    /// <param name="value">The value to assign to the variable.</param>
    public CommandVariableAssignment(string variableName, int value)
    {
        this.variableName = variableName;
        this.value = value;
    }

    /// <summary>
    /// Executes the variable assignment command without graphical output.
    /// </summary>
    /// <param name="interpreter">The interpreter to execute the command.</param>
    public void Execute(Interpreter interpreter)
    {
        // Set the value of the specified variable
        interpreter.SetVariable(variableName, value);
    }

    /// <summary>
    /// Executes the variable assignment command with graphical output (not applicable in this case).
    /// </summary>
    /// <param name="interpreter">The interpreter to execute the command.</param>
    /// <param name="graphics">Unused parameter in this implementation.</param>
    public void Execute(Interpreter interpreter, Graphics graphics)
    {
        // This command does not have graphical output, so this method is not implemented
        // (Graphics parameter remains for consistency with ICommand interface)
    }

    /// <summary>
    /// Gets the name of the variable affected by this command.
    /// </summary>
    /// <returns>
    /// The name of the variable affected by this command.
    /// </returns>
    public string GetVariableName()
    {
        // Return the name of the variable affected by this command
        return variableName;
    }
}
