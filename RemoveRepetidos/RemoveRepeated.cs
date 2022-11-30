using System.Runtime.CompilerServices;

namespace RemoveRepetidos
{
    public static class RemoveRepeatedClass
    {
        public static List<T> ConvertingToHashSet<T>(this List<T> list)
        {
            return list.ToHashSet().ToList();
        }
    }
}
