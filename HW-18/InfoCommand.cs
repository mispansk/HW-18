using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace HW_18
{   /// <summary>
    /// конкретная команда
    /// </summary>
    class InfoCommand: ICommand
    {
        string url;
        VideoReceiver receiver;
        string outputFilePath;

        public InfoCommand(string url, VideoReceiver receiver, string outputFilePath)
        {
            this.url = url;
            this.receiver = receiver;
            this.outputFilePath = outputFilePath;
        }
        public void RunAsync()
        {
            Console.WriteLine("Команда получить информацию о видео отправлена");
            receiver.Operation(url);
            Console.WriteLine("Команда скачать видео отправлена");
            receiver.Operation1(url, outputFilePath);
            Console.ReadLine();  
        }
    }
}
