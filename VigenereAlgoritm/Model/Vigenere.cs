using System.Collections.Generic;
using Vigenere_Cipher.Model.Interfaces;

namespace Vigenere_Cipher
{
   
    public class Vigenere
    {
        private IEncrypt encryptObj;
        private IDencrypt dencryptObj;

        public Vigenere()
        {
            encryptObj = new VigenereEncrypt();
            dencryptObj = new VigenereDencrypt();
        }

        /// <summary>
        /// Шифрование. Алфавит Англ.
        /// </summary>
        /// <param name="source">Входные данные</param>
        /// <param name="key">Ключ</param>        
        public IEnumerable<string> Encrypt(IEnumerable<string> source, string key)
        {
            var newSource = new List<string>(source);

            return encryptObj.Encrypt(newSource, key);
        }

        /// <summary>
        /// Дешифрование. Алфавит Англ.
        /// </summary>
        /// <param name="source">Входные данные</param>
        /// <param name="key">Ключ</param>      
        public IEnumerable<string> Dencrypt(IEnumerable<string> source, string key)
        {
            var newSource = new List<string>(source);

            return dencryptObj.Dencrypt(newSource, key);
        }
    }
}
