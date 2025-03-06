// See https://aka.ms/new-console-template for more information

// Console.Write("Enter your name: ");
// string urName = Console.ReadLine();
// Console.WriteLine($"Hello, {urName} ");

    Console.Write("Input firstNumber: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.Write("Input secondNumber: ");
    double num2 = double.Parse(Console.ReadLine());

    Console.Write("Input expression: ");
    double result = 0.0;
    char value = char.Parse(Console.ReadLine());

    double Sum(double num1, double num2)
    {
        return num1 + num2;
    }

    double Minus(double num1, double num2)
    {
        return num1 - num2;
    }

    double Devide(double num1, double num2)
    {
        return num1 / num2;
    }

    double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    
    switch (value)
    {
        case '+':
            result = Sum(num1, num2);
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
        case '-':
            result = Minus(num1, num2);
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
        case '*':
            result = Multiply(num1, num2);
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
        case '/':
            result = Devide(num1, num2);
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                break;
            }
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
    }

    
