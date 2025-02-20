using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    public static async Task FetchAndWriteContentAsync(string url)
    {
        try
        {

            using (HttpClient client = new HttpClient())
            {

                string content = await client.GetStringAsync(url);


                await File.WriteAllTextAsync("A.txt", content);

                Console.WriteLine("Content has been written to A.txt successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static async Task Main(string[] args)
    {

        Console.WriteLine("Enter the URL to fetch content from:");
        string url = Console.ReadLine();


        await FetchAndWriteContentAsync(url);
    }
}
