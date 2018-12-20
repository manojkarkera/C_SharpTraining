using System;

namespace Event
{
    public class MailService
    {
            public void OnVideoEncoded(object source, VideoEventArgs e)
            {
                Console.WriteLine("Mail services" + e.Video.Title);
            }
    }
}
