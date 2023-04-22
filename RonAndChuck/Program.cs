namespace RonAndChuck
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);
        }
    }
}
