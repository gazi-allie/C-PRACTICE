// using System;

// public class YoutubeChannel
// {
//     public string Name  { get; set; }

//     public event Action OnVideoUploaded;

//   public void UploadVideo()
//     {
//         Console.WriteLine($"New video uploaded to {Name} channel!");

//         if (OnVideoUploaded != null)
//         {
//             OnVideoUploaded();
//         }
//     }

// }
// class Program
// {
//     static void Main()
//     {
//         YoutubeChannel channel = new YoutubeChannel { Name = "Tech Insights" };

//         // Subscribe to the event with a lambda expression
//         channel.OnVideoUploaded += () => Console.WriteLine("Subscriber 1: A new video has been uploaded!");

//         // Subscribe to the event with a method group
//         channel.OnVideoUploaded += NotifySubscribers;

//         // Upload a video, which will trigger the event
//         channel.UploadVideo();
//     }

//     static void NotifySubscribers()
//     {
//         Console.WriteLine("Subscriber 2: Don't forget to like and subscribe!");
//     }
// }