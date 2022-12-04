using System.Runtime.CompilerServices;

namespace RemoveRepetidos
{
    public static class RemoveRepeatedClass
    {
        public static List<T> ConvertingToHashSet<T>(this List<T> list)
        {
            return list.ToHashSet().ToList();
        }
        public static List<ClientSimplified> RemoveRepeatedClient(this List<ClientSimplified> clientList)
        {
            foreach (ClientSimplified clientA in clientList.ToList())
            {
                foreach (ClientSimplified clientB in clientList.ToList())
                {
                    if(!(clientA == clientB))
                    {
                        if (clientA.CPF.Equals(clientB.CPF))
                        {
                            clientList.Remove(clientB);
                        }
                    }
                }                
            }
            return clientList;
        }
    }
}
