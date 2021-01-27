using System.Collections.Generic;
using Vigenere_Cipher.Model.Interfaces;

namespace Vigenere_Cipher
{
    public class Main
    {
        private IEncrypt encryptObj;
        private IDencrypt dencryptObj;

        public Main()
        {
            encryptObj = new VigenereEncrypt();
            dencryptObj = new VigenereDencrypt();
        }

        public IEnumerable<string> Encrypt(IEnumerable<string> source, string key)
        {
            var newSource = new List<string>(source);

            return encryptObj.Encrypt(newSource, key);
        }

        public IEnumerable<string> Dencrypt(IEnumerable<string> source, string key)
        {
            var newSource = new List<string>(source);

            return dencryptObj.Dencrypt(newSource, key);
        }
    }
}
