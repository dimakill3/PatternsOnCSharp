namespace PatternsOnCSharp
{
    interface Visitor
    {
        public void VisitAudioTell(AudioTell a);
        public void VisitTextTell(TextTell t);
        public void VisitWithoutTell(WithoutTell w);
        public void VisitVideoTell(Video v);
    }
}
