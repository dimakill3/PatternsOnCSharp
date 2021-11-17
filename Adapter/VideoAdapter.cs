namespace PatternsOnCSharp
{
    class VideoAdapter : Tell
    {
        Video mp4;

        public VideoAdapter(Video video)
        {
            mp4 = video;
        }

        public VideoAdapter()
        {

        }

        public void SetVideo(Video video)
        {
            mp4 = video;
        }

        public void Accept(Visitor v)
        {
            v.VisitVideoTell(mp4);
        }
    }
}
