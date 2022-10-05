using System;
using System.Diagnostics;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace HW_18
{/// <summary>
/// класс получатель команды, который реализовывает две команды
/// </summary>
    public class VideoReceiver
    {   /// <summary>
        /// реализация вывода инфы о ролике в консоль
        /// </summary>
        /// <param name="url"> ссылка на ролик </param>
          public async void Operation(string url)
          {
              YoutubeClient client = new YoutubeClient();
              var video = await client.Videos.GetAsync(url);

              Console.WriteLine("Название: {0}", video.Title);
              Console.WriteLine("Описание: {0}", video.Description);
              
          }
        /// <summary>
        /// реализация загрузки видео
        /// </summary>
        /// <param name="url"> ссылка на ролик </param>
        /// <param name="filePath"> путь, куда сохранять ролик </param>
          public async void Operation1(string url , string filePath)
          {
              YoutubeClient client = new YoutubeClient();
              var video = await client.Videos.GetAsync(url);

              var streamManifest = await client.Videos.Streams.GetManifestAsync(video.Id);
              var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            
              var progress = new Progress<double>();
              progress.ProgressChanged += (s, e) => Debug.WriteLine($"Загружено: {e:P2}");

              await client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}", progress);
              Console.ReadKey();      
        } 
    }
}