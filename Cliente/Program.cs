using Cliente.controller;
using Cliente.model;
using System.Text.Json;

namespace Cliente
{
    public class Program
    {
        public 
        static void Main()
        {
            SystemController s = new SystemController();
            s.OpenInterface();         
        }
    }
}
