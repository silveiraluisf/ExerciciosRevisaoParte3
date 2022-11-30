namespace RemoveRepetidos
{
    internal class ClientSimplified
    {
        public string Name { get; set; } 
        public long CPF { get; set; }

        public ClientSimplified(string clientName, long clientCPF)
        {
            clientName = Name;
            clientCPF = CPF;
        }

    }
}
