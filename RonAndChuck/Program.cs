namespace RonAndChuck
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("RON SWANSON looks intently at CHUCK NORRIS and says...");
                Thread.Sleep(1900);
                Console.WriteLine($"{quote.RonSwanson()}");
                Thread.Sleep(1900);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("CHUCK NORRIS speaks in third person....");
                Thread.Sleep(1900);
                Console.WriteLine($"{quote.ChuckNorris()}"); ;
                Console.WriteLine("");
                Thread.Sleep(2500);

            }
        }
    }
}
