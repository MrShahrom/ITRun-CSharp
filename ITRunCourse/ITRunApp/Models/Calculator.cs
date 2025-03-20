namespace ITRunApp.Models;

public static partial class Calculator
{
    public delegate double CalculatorOperation(double num1, double num2);
    public static double Sum(double num1, double num2) => num1 + num2;
    public static double Subtract(double num1, double num2) => num1 - num2;
}
public static partial class Calculator
{
    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return num1 / num2;
    }

    public static double Multiply(double num1, double num2) => num1 * num2;
    
    public static CalculatorOperation GetOperation(Operation operation)
    {
        return operation switch
        {
            Operation.Add => Sum,
            Operation.Subtract => Subtract,
            Operation.Multiply => Multiply,
            Operation.Divide => Divide,
            _ => throw new ArgumentException("Invalid operation")
        };
    }
}