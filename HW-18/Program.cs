using System;
using System.IO;
using YoutubeExplode;

namespace HW_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.youtube.com/watch?v=wvc1SJrX7rI";
            string outputFilePath = Directory.GetCurrentDirectory();

            var sender = new Sender();
            var receiver = new VideoReceiver();
            InfoCommand infoCommand = new InfoCommand(url, receiver, outputFilePath);
            sender.SetCommand(infoCommand);
            sender.Run();

            Console.ReadKey();
        }
    }
}
