namespace deliverable_3;
class Program
{
    static void Main(string[] args)
    {
        
        
            Console.Write("Enter an integer between 1 and 100: ");
        try
        {
            int input = int.Parse(Console.ReadLine());
        

            Console.Write("Specify the series type: even or odd ");
            string series = Console.ReadLine();

            if (series == "odd")
            {

                Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");

                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "even")
            {
                Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");

                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        catch
        {
            Console.Write("Enter a numeric value!");
        }
    }
}

