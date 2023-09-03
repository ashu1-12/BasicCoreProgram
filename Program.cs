namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number of times to flip coin");
            //int time = Convert.ToInt32(Console.ReadLine());
            //flipCoin(time);

            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYear leapYear = new LeapYear();
            Console.WriteLine(year + " Is Leap Year " + leapYear.IsLeapYear(year));
        }

        private static void flipCoin(int time)
        {
            int countTails=0, countHeads=0;
            if (time <= 0)
            {
                Console.WriteLine("Invalid entry !! Enter positive value");
                return;
            }
            else
            {

                for (int i = 0; i < time; i++)
                {
                    Random rnd = new Random();
                    double val = Math.Round(rnd.NextDouble(), 1);
                    //val = Math.Round(val, 1);
                    if (val < 0.5)
                        countTails++;
                    else
                        countHeads++;
                    Console.WriteLine(val);
                }

            }
            int tailPercentage = (100 / time) * countTails;
            int headPercentage = 100 - tailPercentage;
            Console.WriteLine("Percentage of Head vs Tail : " + headPercentage + " vs " + tailPercentage);
        }
    }
}