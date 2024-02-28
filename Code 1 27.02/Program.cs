class Program
{
    static void Main()
    {
        // Create an instance of SimpleRandomProblemSolver
        SimpleRandomProblemSolver problemSolver = new SimpleRandomProblemSolver();

        // Solve problems and display results
        int mathematicalResult = problemSolver.SolveMathematicalProblem();
        string manipulatedString = problemSolver.ManipulateString();
        int[] manipulatedList = problemSolver.ManipulateList();

        // Display results
        Console.WriteLine($"Mathematical Result: {mathematicalResult}");
        Console.WriteLine($"Manipulated String: {manipulatedString}");
        Console.WriteLine($"Manipulated List: {string.Join(", ", manipulatedList)}");
    }
}
