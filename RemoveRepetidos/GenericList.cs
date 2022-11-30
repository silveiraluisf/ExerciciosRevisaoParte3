namespace RemoveRepetidos
{
    public class MyList<T>
    {
        public MyList() => ListWithDuplicates = new List<T>();
        public List<T> ListWithDuplicates { get; set; }
    }
}
