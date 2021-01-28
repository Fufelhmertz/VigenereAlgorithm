using System;
using System.Collections.Generic;
using System.Linq;
using Vigenere_Cipher.Helpers;
using Vigenere_Cipher.Model.Interfaces;

namespace Vigenere_Cipher
{
    internal class VigenereEncrypt : IEncrypt
    {
        public List<string> Encrypt(List<string> source, string key)
        {
            if (key == null || !key.Any())
            {
                throw new ArgumentNullException($"Ключ {key} пуст");
            }

            if (!AlgorithmHelper.IsKeyCorrect(key.ToLower()))
            {
                throw new Exception($"Ключ {key} не соответствует алфавиту");
            }

            if (!source.Any())
            {
                throw new ArgumentNullException($"Массив с исходными данными пуст");
            }

            return AlgorithmHelper.GetEncodeOrDencodeArray(source, key.ToLower(), Model.ActionMode.encrypt);
        }
    }
}
