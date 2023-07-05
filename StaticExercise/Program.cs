namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double celsius = TempConverter.FarenheitToCelsius(32);
            double farenheit = TempConverter.CelsiusToFarenheit(0);

            Console.WriteLine($"{farenheit} degrees Farenheit is equal to {celsius} degrees celsius.");
            Console.WriteLine($"{celsius} degrees Celsius is equal to {farenheit} degrees Farenheit.");
 
        }
    }
}
