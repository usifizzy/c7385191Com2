using System;
using System.Collections.Generic;
using System.Drawing;

namespace ASE_Programming_Language
{
    /// <summary>
    /// Defines the ICommand interface for command execution.
    /// </summary>
    public interface ICommand
    {
        void Execute(Interpreter interpreter);
        string GetVariableName();
        void Execute(Interpreter interpreter, Graphics graphics);
    }

    /// <summary>
    /// Represents an interpreter that manages variables and executes drawing commands.
    /// </summary>
    public class Interpreter
    {
        private Dictionary<string, int> variables = new Dictionary<string, int>();

        /// <summary>
        /// Gets the value of a variable from the interpreter.
        /// </summary>
        /// <param name="variableName">The name of the variable.</param>
        /// <returns>The value of the variable.</returns>
        public int GetVariableValue(string variableName)
        {
            if (variables.ContainsKey(variableName))
            {
                return variables[variableName];
            }
            throw new Exception($"Variable '{variableName}' not defined.");
        }

        /// <summary>
        /// Sets the value of a variable in the interpreter.
        /// </summary>
        /// <param name="variableName">The name of the variable.</param>
        /// <param name="value">The value to assign to the variable.</param>
        public void SetVariable(string variableName, int value)
        {
            variables[variableName] = value;
        }

        /// <summary>
        /// Draws a circle using the provided Graphics object.
        /// </summary>
        /// <param name="size">The size of the circle.</param>
        /// <param name="graphics">The Graphics object to use for drawing.</param>
        public void DrawCircle(int size, Graphics graphics)
        {
            // Draw a circle using the Graphics object
            graphics.DrawEllipse(Pens.Black, new Rectangle(0, 0, size, size));
        }
    }

    /// <summary>
    /// Represents a command to initialize a variable with a specific value.
    /// </summary>
    public class CommandInitialization : ICommand
    {
        private string variableName;
        private int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandInitialization"/> class.
        /// </summary>
        /// <param name="variableName">The name of the variable to initialize.</param>
        /// <param name="value">The value to assign to the variable.</param>
        public CommandInitialization(string variableName, int value)
        {
            this.variableName = variableName;
            this.value = value;
        }

        /// <summary>
        /// Executes the initialization command without graphical output.
        /// </summary>
        /// <param name="interpreter">The interpreter to execute the command.</param>
        public void Execute(Interpreter interpreter)
        {
            // Set the value of the specified variable
            interpreter.SetVariable(variableName, value);
        }

        /// <summary>
        /// Executes the initialization command with graphical output.
        /// </summary>
        /// <param name="interpreter">The interpreter to execute the command.</param>
        /// <param name="graphics">Unused parameter in this implementation.</param>
        public void Execute(Interpreter interpreter, Graphics graphics)
        {
            // If not relevant for this command, you can leave it empty or throw an exception
            throw new NotImplementedException("This command does not support graphical execution.");
        }

        /// <summary>
        /// Gets the name of the variable affected by this command.
        /// </summary>
        /// <returns>
        /// The name of the variable affected by this command.
        /// </returns>
        public string GetVariableName()
        {
            return variableName;
        }
    }
}
