using ScrapeLibrary;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebPage("https://learnxinyminutes.com/csharp/");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}