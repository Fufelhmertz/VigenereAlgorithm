﻿using System;
using System.Collections.Generic;
using System.Linq;
using Vigenere_Cipher.Helpers;
using Vigenere_Cipher.Model.Interfaces;

namespace Vigenere_Cipher
{
    internal class VigenereDencrypt : IDencrypt
    {
        public List<string> Dencrypt(List<string> source, string key)
        {
            if (!key.Any())
            {
                throw new ArgumentNullException($"Ключ {key} пуст");
            }

            if (!AlgoritmHelper.IsKeyCorrect(key.ToLower()))
            {
                throw new Exception($"Ключ {key} не соответствует алфавиту");
            }

            if (!source.Any())
            {
                throw new ArgumentNullException($"Массив с исходными данными пуст");
            }

            return AlgoritmHelper.GetEncodeOrDencodeArray(source, key.ToLower(), Model.ActionMode.dencrypt);
        }
    }
}