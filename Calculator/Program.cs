bool keepPlaying = true;

while (keepPlaying == true)
{
    Console.WriteLine("Please select an operation:");
    Console.WriteLine("1 for addition");
    Console.WriteLine("2 for subtraction");
    Console.WriteLine("3 for multiplication");
    Console.WriteLine("4 for division");
    Console.WriteLine("'Q' to quit");
    Console.Write("Enter your selection then press the return key: ");
    string selected = Console.ReadLine().ToLower();

    switch (selected)
    {
        case "1":
            Console.WriteLine();
            Console.WriteLine(Addition());
            break;
        case "2":
            Console.WriteLine();
            Console.WriteLine(Subtraction());
            break;
        case "3":
            Console.WriteLine();
            Console.WriteLine(Multiplication());
            break;
        case "4":
            Console.WriteLine();
            Console.WriteLine(Division());
            break;
        case "q":
            Console.WriteLine("Thank you for using the calculator");
            keepPlaying = false;
            break;
        default:
            Console.WriteLine("You pressed an invalid number");
            break;
    }
}


string Multiplication()
{
    Console.WriteLine("----- Multiplication -----");
    int result = 0;
    int[] numbers = GetNumbers("multiply");
    result = numbers[0] * numbers[1];
    return $"{numbers[0]} * {numbers[1]} = {result}\n";
}
string Division()
{
    Console.WriteLine("----- Division -----");
    int result = 0;
    int[] numbers = GetNumbers("divide");
    result = numbers[0] / numbers[1];
    return $"{numbers[0]} / {numbers[1]} = {result}\n";
}

string Subtraction()
{
    Console.WriteLine("----- Subtraction -----");
    int result = 0;
    int[] numbers = GetNumbers("subtract");
    result = numbers[0] - numbers[1];
    return $"{numbers[0]} - {numbers[1]} = {result}\n";
}
string Addition()
{
    Console.WriteLine("----- Addition -----");
    int result = 0;
    int[] numbers = GetNumbers("add");
    result = numbers[0] + numbers[1];
    return $"{numbers[0]} + {numbers[1]} = {result}\n";
}


int[] GetNumbers(string operation)
{
    int[] numbers = { 0, 0 };
    Console.Write($"Please enter the first number to {operation}: ");
    int numberOne = ConvertNumber(Console.ReadLine(), operation);
    numbers[0] = numberOne;
    Console.Write($"Please enter the second number to {operation}: ");
    int numberTwo = ConvertNumber(Console.ReadLine(), operation);
    numbers[1] = numberTwo;

    return numbers;
}

int ConvertNumber(string enteredNumber, string operation)
{
    int number = 0;
    bool isConverted = int.TryParse(enteredNumber, out number);
    if (number == 0 && operation == "divide")
    {
        isConverted = false;
    }
    while (isConverted == false)
    {
        Console.Write($"{enteredNumber} is not a valid number. Please try again: ");
        enteredNumber = Console.ReadLine();
        isConverted = int.TryParse(enteredNumber, out number);
    }
    return number;
}