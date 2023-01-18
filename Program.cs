// See https://aka.ms/new-console-template for more information
namespace h1Converter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Console.WriteLine("What Would you like to convert?");
            Console.WriteLine("cm -> inches[D]");
            Console.WriteLine("Celsius -> Farenheit[F]");
            do
            {
                key = Console.ReadKey();
            } while (key == null);
            string result = GetConvertion(key.Key.ToString());
            Console.Clear();
            Console.WriteLine($"you result was {result}");
            Console.ReadLine();
        }

        private static string GetConvertion(string key)
        {
            float result;
            string resolution;
            float number;
            
            switch(key.ToUpper()){
                case "D":
                    Console.Clear();
                    Console.WriteLine("How many cm?");
                    number = Convert.ToInt32(Console.ReadLine());
                    
                    result = number * 0.393700787f;
                    resolution = "Inches";
                    break;
                case "F":
                    Console.Clear();
                    Console.WriteLine("How much Celsuis?");
                    number = Convert.ToInt32(Console.ReadLine());
                    
                    result = (number * 1.8f) + 32;
                    resolution = "Farhenheit";
                    break;
                default:
                        result = 0f;
                        resolution = "fok of";
                    break;
            }
            Console.WriteLine(key);
            return $"{result} {resolution}";
        }
    }
}