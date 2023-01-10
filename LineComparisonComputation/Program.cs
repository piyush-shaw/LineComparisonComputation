internal class Program
{
    public static int x1 = 0, x2 = 0, y1 = 0, y2 = 0, a1 = 0, a2 = 0, b1 = 0, b2 = 0;
    public static double length = 0, length2 = 0;
    public static void input()
    {
        Console.WriteLine("Enter the value of x1 and x2 ");
        x1 = Convert.ToInt32(Console.ReadLine());
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of y1 and y2 ");
        y1 = Convert.ToInt32(Console.ReadLine());
        y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of a1 and a2 ");
        a1 = Convert.ToInt32(Console.ReadLine());
        a2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b1 and b2 ");
        b1 = Convert.ToInt32(Console.ReadLine());
        b2 = Convert.ToInt32(Console.ReadLine());
        //calculating the length of lines
        length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        length2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
        Console.WriteLine("Length of First Line " + length);
        Console.WriteLine("Lenth of Second Line " + length2);
        
    }
    public static void checkEquality()
    {
        //checking equality of two lines 
        bool line = length.Equals(length2);
        if (line == true)
        {
            Console.WriteLine("Two lines are equal");
        }
        else
        {
            Console.WriteLine("Two lines are not equal");
        }
        
    }
    public static void compare()
    {
        //comparing length of two lines
        double difference = length.CompareTo(length2);
        if (difference < 0)
        {
            Console.WriteLine("Length of first line is less than second line");
        }
        else if (difference > 0)
        {
            Console.WriteLine("Length of first line is greater than second line");
        }
        else
        {
            Console.WriteLine("Length of two lines are equal");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Line Comparison Computation Program");
        input();
        checkEquality();
        compare();
    }
}