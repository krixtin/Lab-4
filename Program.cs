namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int radius = 1;
            bool isRunning = true;

            while (isRunning) 
            {
                Console.Write("Hej! Skriv in radien av din cirkel: ");

                radius = int.Parse(Console.ReadLine());
                if (radius > 0)
                {
                    Console.WriteLine($"Arean av en cirkel med radie {radius} är {Circle.GetArea(radius)}.");

                    Console.WriteLine($"Omkretsen av en cirkel med radie {radius} är {Circle.GetCircumference(radius)}.");

                    Console.WriteLine($"Volymen av en sfär med radien {radius} är {Circle.GetVolume(radius)}.");
                }
                else { isRunning = false; }
            }
        }
    }
}
