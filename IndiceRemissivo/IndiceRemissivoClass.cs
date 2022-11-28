using System.IO;

namespace IndiceRemissivo
{
    public class IndiceRemissivoClass
    {
        public static void IndiceRemissivo(string pathTXT)
        {
            //Publicação utilizada como base para desenvolver a atividade: https://blog.groupdocs.com/parser/count-words-and-occurrences-using-csharp/

            Dictionary<string, int> stats = new Dictionary<string, int>();
            var text= File.ReadAllText(pathTXT);
            char[] chars = { ' ', '.', ',', ';', ':', '?', '\n', '\r' };

            //separa palavras
            string[] words = text.Split(chars);
            int minWordLength = 2;

            //interacao sobre as palavras para contar o numero de ocorrencias
            foreach(string word in words)
            {
                string w = word.Trim().ToLower();
                if(w.Length > minWordLength )
                {
                    if (!stats.ContainsKey(w))
                    {
                        stats.Add(w, 1); //add nova palavra a colecao
                    }
                    else
                    {
                        stats[w] += 1; //atualiza o contador de ocorrencias de palavras
                    }
                }
            }

            var ordenerStats = stats.OrderBy(x => x.Key);

            foreach(var pair in ordenerStats)
            {
                Console.WriteLine("Total de ocorrências de {0}: {1}" , pair.Key, pair.Value);
            }

        }
        public static void Imprime()
        {
            Console.WriteLine();
        }
    }
}
