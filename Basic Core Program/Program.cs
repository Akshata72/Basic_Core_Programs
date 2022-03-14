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
            Console.WriteLine("Choose 6 for  QuotientAndRemainder ");
            Console.WriteLine("Choose 7 for Swap two numbers");
            Console.WriteLine("Choose 8 for check Even or Odd number");
            Console.WriteLine("Choose 9 for Check Letter is vowel");


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
                case 6:
                    QuotientAndRemainder quotientremainder = new QuotientAndRemainder();
                    quotientremainder.QuotientRemainder();
                    break;
                case 7:
                    SwapTwoNumber swaptwonumber = new SwapTwoNumber();
                    swaptwonumber.SwapTwoNumbers();
                    break;
                case 8:
                    EvenOrOdd evenorodd = new EvenOrOdd();
                    evenorodd.EvenorOdd();
                    break;
                case 9:
                    Alphabets alphabets = new Alphabets();
                    alphabets.Alphabet();
                    break;


            }



        }

    }
}