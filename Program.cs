namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialising variables for radius, for the calculations, and isRunning, to be able to loop the program
            int radius = 1;
            bool isRunning = true;

            //looping the program until the user puts in 0 or a negative number
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
