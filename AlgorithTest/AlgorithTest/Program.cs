using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> datasource = new List<string> { "LIVERPOOL", "LIVERPOOL LIME STREET", "PADDINGTON" };
            //List<string> datasource = new List<string> { "DARTFORD", "DARTMOUTH", "TOWER HILL", "DERBY" };
            List<string> datasource = new List<string> { "EUSTON", "LONDON BRIDGE", "VICTORIA" };
            List<string> newWords = new List<string>();

            string text = "KING CROSS";
            char[] sText = text.ToCharArray();

            foreach (var item in datasource)
            {
                if (item.Contains(text))
                    newWords.Add(item);
            }

            if (newWords.Count == 0)
            {
                Console.WriteLine("No Stations");
                if (sText.Length == 0) ;
                Console.WriteLine("No characters found");
            }


            foreach (var word in newWords)
            {
                Console.WriteLine("Words found: {0}", word);
                char[] sWord = word.ToCharArray();
                for (int i = 1; i < sText.Length; i++)
                {
                    if (i.Equals(sText.Length - 1))
                        if (sText.Length < sWord.Length)
                            if (string.IsNullOrWhiteSpace(sWord[i + 1].ToString()))
                                Console.WriteLine("Character not found but i put:{0}", "OF");
                            else
                                Console.WriteLine("Character found:{0}", sWord[i + 1]);
                }
            }
        }
    }
}
