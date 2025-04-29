public class Program {
    public static void Main(string[] args) {
        int[] Array = { 4, 2, 1, 0 };

        Console.WriteLine("Finding the missing number in a sample array");
        Console.WriteLine("Array: " + string.Join(", ", Array));
        Console.WriteLine("Missing Number: " + Functions.FindMissingNumber(Array));
    }
}