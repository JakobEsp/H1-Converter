// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace h1Converter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string key;
            Console.WriteLine("What Would you like to convert?");
            Console.WriteLine("cm -> inches[D]");
            do
            {
                key = Console.ReadKey().ToString();
            } while (key == null);
            float result = GetConvertion();
        }

        public float GetConvertion(string key)
        {
            float result;
            float number;
            
            switch(key.ToString()){
                case "D":
                    Console.WriteLine("How many cm?");
                    number = Convert.ToInt32(Console.ReadLine());
                    result = number * 0.393700787f;
                    break;
                default:
                    Console.WriteLine("fok of");
                        result = 0f;
                    break;
            }
            return result;
        }
    }
}