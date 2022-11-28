namespace IndiceRemissivo
{
    public class IndiceRemissivoClass
    {
        public static void IndiceRemissivo(string pathTXT)
        {
            //Fonte utilizada como base para desenvolver a atividade: https://blog.groupdocs.com/parser/count-words-and-occurrences-using-csharp/

            Dictionary<string, int> stats = new Dictionary<string, int>();
            var text= File.ReadAllText(pathTXT);
            char[] chars = { ' ', '.', ',', ';', ':', '?', '<', '>', '\\', '/', '|', '~', '^', '´', '`', '[', ']', '{', '}', '‘', '“', '!', '@', '#', '$', '%', '&', '&', '(', ')', '_', '+', '=', '\n', '\r' };

            //separa palavras
            string[] words = text.Split(chars);
            int minWordLength = 2;

            //interacao sobre as palavras para contar o numero de ocorrencias
            foreach(string word in words)
            {
                string w = word.Trim().ToUpper();
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
            Imprime(ordenerStats);
          
        }
        public static void Imprime(IOrderedEnumerable<KeyValuePair<string, int>> a)
        {
            foreach (var pair in a)
            {
                Console.WriteLine("{0} ({1})", pair.Key, pair.Value);
            }
        }

        public static void LinesCount(string pathTXT)
        {

            string line = File.ReadLines(pathTXT);
            
                int counter = 0;

                // Read the file and display it line by line.  
                foreach (string line in System.IO.File.ReadLines(@"c:\test.txt"))
                {
                    System.Console.WriteLine(line);
                    counter++;
                }

                System.Console.WriteLine("There were {0} lines.", counter);
                // Suspend the screen.  
                System.Console.ReadLine();
        }
    }
}
