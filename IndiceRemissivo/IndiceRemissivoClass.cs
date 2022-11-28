using System.Reflection.PortableExecutable;
using System.Text;

namespace IndiceRemissivo
{
    public class IndiceRemissivoClass
    {
        public static void IndiceRemissivo(string pathTXT, string pathIgnore)
        {
            pathTXT = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\IndiceRemissivo\\texto.txt";
            var file = File.ReadAllText(pathTXT).Split(new[] { ' ' });
        }
        public static void Imprime()
        {
            Console.WriteLine();
        }
    }
}
