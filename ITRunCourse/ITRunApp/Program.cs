
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
    // double result = 0.0;

    try
    {
        Calculator.CalculatorOperation selectedOperation = Calculator.GetOperation(operation);
                    
        double result = selectedOperation(num1, num2);

        Console.WriteLine($"{num1} {operationChar} {num2} = {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}