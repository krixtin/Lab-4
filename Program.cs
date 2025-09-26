namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //initialising variable for radius for the calculations
            int radius = 1;

            //creating instance of Circle class
            Circle myCircle = new Circle(radius);


            //initiating bool isRunning to be able to loop the program
            bool isRunning = true;

            //looping the program until the user puts in 0 or a negative number
            while (isRunning) 
            {
                Console.Write("Hej! Skriv in radien av din cirkel: ");

                radius = int.Parse(Console.ReadLine());

                if (radius > 0)
                {
                    Console.WriteLine($"Arean av en cirkel med radie {radius} är {myCircle.GetArea()}.");

                    Console.WriteLine($"Omkretsen av en cirkel med radie {radius} är {myCircle.GetCircumference()}.");

                    Console.WriteLine($"Volymen av en sfär med radien {radius} är {myCircle.GetVolume()}.");
                }
                else { isRunning = false; }
            }
        }
    }
}
