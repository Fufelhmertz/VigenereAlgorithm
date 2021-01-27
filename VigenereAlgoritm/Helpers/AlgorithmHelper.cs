using System.Collections.Generic;
using System.Text;
using Vigenere_Cipher.Infrastructures;
using Vigenere_Cipher.Model;

namespace Vigenere_Cipher.Helpers
{
    internal static class AlgorithmHelper
    {
        /// <summary>
        /// Метод для кодирования\декодирования текста
        /// </summary>        
        internal static List<string> GetEncodeOrDencodeArray(List<string> source, string key, ActionMode actionMode)
        {
            //мощность алгоритма
            int alphabetPower = Alphabet.EngAlphabet.Length;

            var result = new List<string>();
            var resultString = new StringBuilder();

            int index = 0;

            foreach (var word in source)
            {
                resultString.Clear();

                foreach (var element in word.ToLower())
                {

                    if (!Alphabet.EngAlphabet.Contains(element))
                    {
                        resultString.Append(element);
                        continue;
                    }

                    if (actionMode == ActionMode.encrypt)
                    {
                        resultString.Append(Alphabet.EngAlphabet[(Alphabet.EngAlphabet.IndexOf(element) + Alphabet.EngAlphabet.IndexOf(key[index])) % alphabetPower]);
                    }
                    else
                    {
                        resultString.Append(Alphabet.EngAlphabet[(alphabetPower + Alphabet.EngAlphabet.IndexOf(element) - Alphabet.EngAlphabet.IndexOf(key[index])) % alphabetPower]);
                    }

                    index = (index + 1) % key.Length;
                }

                result.Add(resultString.ToString());
            }

            return result;
        }

        internal static bool IsKeyCorrect(string key)
        {
            foreach (var element in key)
            {
                if (!Alphabet.EngAlphabet.Contains(element))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
