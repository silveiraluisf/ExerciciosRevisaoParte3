using IndiceRemissivo;

namespace IndiceRemissivo
{
    public class Program
    {
        public static void Main()
        {
            string pathTXT;
            //string pathIgnore;
            Console.WriteLine("---- PROGRAMA INDICE REMISSIVO ----");
            pathTXT = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\IndiceRemissivo\\texto.txt";
            //pathIgnore = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\IndiceRemissivo\\ignore.txt";
            if (!File.Exists(pathTXT))
            {
                throw new Exception("Insira um diretório válido!");
            }
            //IndiceRemissivoClass.IndiceRemissivo(pathTXT);
            IndiceRemissivoClass.IndiceRemissivoComContagemLinha(pathTXT);
        }
    }
}




