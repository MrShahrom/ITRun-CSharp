
while (true)
{
    double num1;
    double num2;
    char operationChar = ' ';
    
    while (true)
    {
        Console.Write("Input first number: ");
        try
        {
            num1 = double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter a number!");
            continue;
        }
        break;
    }
    
    while (true)
    {
        Console.Write("Input second number: ");
        try
        {
            num2 = double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter a number!");
            continue;
        }
        break;
    }
    
    while (true)
    {
        Console.Write("Input operation (+, -, *, /): ");
        try
        {
            operationChar = char.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Please input only one symbol!");
            continue;
        }
        
        if (!Enum.IsDefined(typeof(Operation), (int)operationChar))
        {
            Console.WriteLine("Please input operation (+, -, *, /)!");
            continue;
        }
        break;
    }
    
    Operation operation = (Operation)operationChar;
    double result = 0.0;

    try
    {
        switch (operation)
        {
            case Operation.Add:
                result = Calculator.Sum(num1, num2);
                break;
            case Operation.Subtract:
                result = Calculator.Subtract(num1, num2);
                break;
            case Operation.Multiply:
                result = Calculator.Multiply(num1, num2);
                break;
            case Operation.Divide:
                result = Calculator.Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }

        Console.WriteLine($"{num1} {operationChar} {num2} = {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}