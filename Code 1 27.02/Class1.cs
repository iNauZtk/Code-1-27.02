class SimpleRandomProblemSolver
{
    private int number1;
    private int number2;
    private string randomString;

    // Constructor to initialize with random data
    public SimpleRandomProblemSolver()
    {
        Random random = new Random();
        number1 = random.Next(1, 10);
        number2 = random.Next(1, 10);
        randomString = Guid.NewGuid().ToString().Substring(0, 8);
        Console.WriteLine("Random data generated: Number1=" + number1 + ", Number2=" + number2 + ", String=" + randomString);
    }

    // Solve a mathematical problem
    public int SolveMathematicalProblem()
    {
        // For demonstration, let's find the product of two numbers
        return number1 * number2;
    }

    // Manipulate a string
    public string ManipulateString()
    {
        // For demonstration, let's append the numbers to the random string
        return randomString + number1 + number2;
    }

    // Manipulate a list (here, we use a simple array)
    public int[] ManipulateList()
    {
        // For demonstration, let's create an array with the two numbers
        return new int[] { number1, number2 };
    }
}

