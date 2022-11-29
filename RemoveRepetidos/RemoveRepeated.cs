namespace RemoveRepetidos
{
    public static class RemoveRepeatedClass
    {        
        public static void RemoveRepeated<T>(this List<T> entity)
        {
            Console.WriteLine($"{entity}");
            List<T> noDupes = entity.Distinct().ToList();
            Console.WriteLine($"{noDupes}");
        }
    }
}
