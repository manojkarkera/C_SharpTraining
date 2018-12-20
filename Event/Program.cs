using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("message services" + e.Video.Title);
        }
    }
}
