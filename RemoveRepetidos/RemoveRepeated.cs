using System.Runtime.CompilerServices;

namespace RemoveRepetidos
{
    public static class RemoveRepeatedClass
    {
        public static List<T> ConvertingToHashSet<T>(this List<T> list)
        {
            return list.ToHashSet().ToList();
        }
        public static List<ClientSimplified> RemoveRepeatedClient(this List<ClientSimplified> listWithDuplicates)
        {
            var newClientList = new List<ClientSimplified>();
            listWithDuplicates = listWithDuplicates.OrderBy(x => x.CPF).ToList();
            
            ClientSimplified? element = default;
            
            foreach (ClientSimplified result in listWithDuplicates)
            {
                if(!result.CPF.Equals(element?.CPF))
                {
                    newClientList.Add(result);
                    element = result;
                }        
            }
            return newClientList;
        }
    }
}
