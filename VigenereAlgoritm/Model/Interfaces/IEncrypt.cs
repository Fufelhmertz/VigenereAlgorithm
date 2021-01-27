using System.Collections.Generic;

namespace Vigenere_Cipher.Model.Interfaces
{
    public interface IEncrypt
    {
        List<string> Encrypt(List<string> source, string key);
    }
}
