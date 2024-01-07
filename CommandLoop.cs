using ASE_Programming_Language;
using System.Collections.Generic;
using System.Drawing;

/// <summary>
/// Represents a command to execute a loop with a specified count.
/// </summary>
public class CommandLoop : ICommand
{
    private string loopCountVariableName;
    private List<ICommand> commands;
    private int loopCount;
    private string loopVariable;
    private List<ICommand> commandList;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandLoop"/> class with a loop count variable.
    /// </summary>
    /// <param name="loopCountVariableName">The name of the variable containing the loop count.</param>
    /// <param name="commands">The list of commands to execute within the loop.</param>
    public CommandLoop(string loopCountVariableName, List<ICommand> commands)
    {
        this.loopCountVariableName = loopCountVariableName;
        this.commands = commands;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandLoop"/> class with a specified loop count.
    /// </summary>
    /// <param name="loopCount">The number of times to execute the loop.</param>
    /// <param name="commands">The list of commands to execute within the loop.</param>
    public CommandLoop(int loopCount, List<ICommand> commands)
    {
        this.loopCount = loopCount;
        this.commands = commands;
    }

    /// <summary>
    /// Executes the loop without graphical output.
    /// </summary>
    /// <param name="interpreter">The interpreter to execute the loop.</param>
    public void Execute(Interpreter interpreter)
    {
        // If loopCountVariableName is not null, get the count from the interpreter
        if (!string.IsNullOrEmpty(loopCountVariableName))
        {
            loopCount = interpreter.GetVariableValue(loopCountVariableName);
        }

        // Execute the loop
        for (int i = 0; i < loopCount; i++)
        {
            foreach (var command in commands)
            {
                command.Execute(interpreter);
            }
        }
    }

    /// <summary>
    /// Executes the loop with graphical output.
    /// </summary>
    /// <param name="interpreter">The interpreter to execute the loop.</param>
    /// <param name="graphics">The graphics object to use for graphical commands.</param>
    public void Execute(Interpreter interpreter, Graphics graphics)
    {
        // Execute the loop
        for (int i = 0; i < loopCount; i++)
        {
            foreach (var command in commands)
            {
                // Check if the command is a graphical command before using graphics
                if (command is CommandDrawCircle)
                {
                    command.Execute(interpreter, graphics);
                }
                else
                {
                    command.Execute(interpreter);
                }
            }
        }
    }

    /// <summary>
    /// Gets the name of the variable used by this command.
    /// </summary>
    /// <returns>
    /// Null or an empty string since loop commands don't necessarily have a single variable name.
    /// </returns>
    public string GetVariableName()
    {
        // Return null or an empty string if this command does not use a variable
        // (Implementation details may be added here if necessary)
        return null;
    }
}
