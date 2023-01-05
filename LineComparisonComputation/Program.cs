internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Line Comparison Computation Program");
        int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
        double length = 0;
        Console.WriteLine("Enter the value of x1 and x2 ");
        x1 = Convert.ToInt32(Console.ReadLine());
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of y1 and y2 ");
        y1 = Convert.ToInt32(Console.ReadLine());
        y2 = Convert.ToInt32(Console.ReadLine());
        //calculating the length of line
        length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        Console.WriteLine("Length of a Line "+length);
    }
}