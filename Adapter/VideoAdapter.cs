namespace PatternsOnCSharp
{
    class VideoAdapter : Tell
    {
        Video mp3;

        public VideoAdapter(Video video)
        {
            mp3 = video;
        }

        public VideoAdapter()
        {

        }

        public void BeginTell()
        {
            mp3.PlayVideo();
        }

        public void SetVideo(Video video)
        {
            mp3 = video;
        }
    }
}
