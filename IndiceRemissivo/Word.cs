namespace IndiceRemissivo
{
    public class Word
    {
        public string? Text { get; set; }
        public int? Occurences { get; set; }
        public List<int>? LinesNumbers { get; set; }

        //public Word (int occurences, List<int> lineNumbers)
        //{
        //    Occurences= occurences;
        //    LinesNumbers= lineNumbers;
        //}
    }
}
