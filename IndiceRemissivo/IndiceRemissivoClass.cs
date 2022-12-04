using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;

namespace IndiceRemissivo
{
    public class IndiceRemissivoClass
    {
        public static void IndiceRemissivo(string pathTXT)
        {
            //Fonte utilizada como base para desenvolver a atividade: https://blog.groupdocs.com/parser/count-words-and-occurrences-using-csharp/

            Dictionary<string, int> stats = new Dictionary<string, int>();
            var text = File.ReadAllText(pathTXT);
            char[] chars = { ' ', '.', ',', ';', ':', '?', '<', '>', '\\', '/', '|', '~', '^', '´', '`', '[', ']', '{', '}', '‘', '“', '!', '@', '#', '$', '%', '&', '&', '(', ')', '_', '+', '=', '\n', '\r' };
            //separa palavras
            string[] words = text.Split(chars);
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

        //Tentativa de fazer a função mostrar as linhas em que as palavras aparecem usando o RealAllLines e Dictionary com Value contendo mais de um argumento (nº de ocorrencias da palavra e linha)

        public static void IndiceRemissivoComContagemLinha(string pathTXT)
        {
            List<Word> statsList = new();
            
            string[] lines = File.ReadAllLines(pathTXT);
            char[] chars = { ' ', '.', ',', ';', ':', '?', '<', '>', '\\', '/', '|', '~', '^', '´', '`', '[', ']', '{', '}', '‘', '“', '!', '@', '#', '$', '%', '&', '&', '(', ')', '_', '+', '=', '\n', '\r' };
            int counter = 1;
            foreach (string line in lines)
            {             
                string[] words = line.Split(chars);
                int minWordLength = 2;
                counter +=1;
                foreach (string word in words)
                {
                    Word w = new();
                    w.Text = word;
                    
                    if (w.Text.Length > minWordLength)
                    {
                        foreach (Word t in statsList)
                        {
                            if (w.Text.Equals(t.Text))
                            {
                                w.Occurences += 1;
                                w.LinesNumbers?.Add(counter);
                                //Console.WriteLine(w.LinesNumbers);
                                //statsList.Add(w);
                            }

                            else
                            {
                                w.LinesNumbers?.Add(counter);
                                w.Occurences += 1;
                                statsList.Add(w);                               
                            }
                        }
                    }
                }
            }
            //List<Word> ordenerStats = (List<Word>)statsList.OrderBy(x => x.Text);
            ImprimeComLinha(statsList);          
        }
        public static void ImprimeComLinha(List<Word> ordenerStats)
        {            
            foreach (Word w in ordenerStats)
            {
                Console.WriteLine($"{w.Text} ({w.Occurences}) {w.LinesNumbers} ");
            }
        }
    }
 }
