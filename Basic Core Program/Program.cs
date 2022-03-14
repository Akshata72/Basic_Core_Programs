namespace BasicCoreProgram
{

    class BasicCoreProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose 1 for FlipCoin");
           
            int Option = int.Parse(Console.ReadLine());

            switch(Option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoins();
                    break;
                





            }



        }

    }
}