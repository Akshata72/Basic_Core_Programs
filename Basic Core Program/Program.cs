namespace BasicCoreProgram
{

    class BasicCoreProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose 1 for FlipCoin");
            Console.WriteLine("Choose 2 for LeapYear");
            Console.WriteLine("Choose 3 for Power of 2");
            Console.WriteLine("Choose 4 for Harmonics");
            Console.WriteLine("Choose 5 for Factors");


            int Option = int.Parse(Console.ReadLine());

            switch(Option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoins();
                    break;


                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.LeapYears();
                    break;
                case 3:
                    Power power = new Power();
                    power.Power_Of2();
                    break;
                case 4:
                    Harmonics harmonic = new Harmonics();
                    harmonic.Harmonic();
                    break;
                case 5:
                    Factors factor = new Factors();
                    factor.Factor();
                    break;



            }



        }

    }
}