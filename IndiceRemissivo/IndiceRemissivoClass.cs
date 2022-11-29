namespace IndiceRemissivo
{
    public class IndiceRemissivoClass
    {
        public static void IndiceRemissivo(string pathTXT)
        {
            //Fonte utilizada como base para desenvolver a atividade: https://blog.groupdocs.com/parser/count-words-and-occurrences-using-csharp/
            Dictionary<string, int> stats = new();
            string[] lines = File.ReadAllLines(pathTXT);
            char[] chars = { ' ', '.', ',', ';', ':', '?', '<', '>', '\\', '/', '|', '~', '^', '´', '`', '[', ']', '{', '}', '‘', '“', '!', '@', '#', '$', '%', '&', '&', '(', ')', '_', '+', '=', '\n', '\r' };
            int counter = 0;
            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                string[] words = line.Split(chars);
                counter++;
                int minWordLength = 2;
                //interacao sobre as palavras para contar o numero de ocorrencias
                foreach (string word in words)
                {
                    string w = word.Trim().ToUpper();
                    if (w.Length > minWordLength)
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
            }
            var ordenerStats = stats.OrderBy(x => x.Key);
            Imprime(ordenerStats);          
        }
        public static void Imprime(IOrderedEnumerable<KeyValuePair<string, int>> a)
        {            
            foreach (var pair in a)
            {
                Console.WriteLine("{0} ({1})", pair.Key, pair.Value);
            }
        }
    }
    
}
