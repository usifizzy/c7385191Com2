using System.Collections.Generic;
using System.Drawing;

namespace ASE_Programming_Language // Replace with your actual namespace
{
    /// <summary>
    /// Represents a command that executes a series of commands in sequence.
    /// </summary>
    public class CommandMultiLine : ICommand
    {
        private readonly List<ICommand> _commands;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandMultiLine"/> class.
        /// </summary>
        /// <param name="commands">The list of commands to execute in sequence.</param>
        public CommandMultiLine(List<ICommand> commands)
        {
            _commands = commands;
        }

        /// <summary>
        /// Executes the sequence of commands without graphical output.
        /// </summary>
        /// <param name="interpreter">The interpreter to execute the commands.</param>
        public void Execute(Interpreter interpreter)
        {
            foreach (var command in _commands)
            {
                command.Execute(interpreter);
            }
        }

        /// <summary>
        /// Executes the sequence of commands with graphical output.
        /// </summary>
        /// <param name="interpreter">The interpreter to execute the commands.</param>
        /// <param name="graphics">The graphics object to use for graphical commands.</param>
        public void Execute(Interpreter interpreter, Graphics graphics)
        {
            foreach (var command in _commands)
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

        /// <summary>
        /// Gets the name of the variable used by this command.
        /// </summary>
        /// <returns>
        /// Null or an empty string since this command does not associate with a single variable.
        /// </returns>
        public string GetVariableName()
        {
            // Return null or an empty string if this command does not use a variable
            // (Implementation details may be added here if necessary)
            return null;
        }
    }
}
