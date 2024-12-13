namespace tiktak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Else if-i sisse panna if ja else võrdlus");
            Console.WriteLine("Sisesta number:");

            string input = Console.ReadLine(); 

            if (int.TryParse(input, out int number)) 
            {
                if (number > 0) 
                {
                    Console.WriteLine("Number on positiivne.");
                }
                else 
                {
                    Console.WriteLine("Number ei ole positiivne.");
                }

               
                if (number % 2 == 0) 
                {
                    Console.WriteLine("Number on paaris.");
                }
                else 
                {
                    Console.WriteLine("Number on paaritu.");
                }
            }
            else
            {
                Console.WriteLine("Palun sisesta korrektne täisarv!"); 
            }
        }
    }
}
