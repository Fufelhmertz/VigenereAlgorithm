using System.Collections.Generic;

namespace Vigenere_Cipher.Model.Interfaces
{
    public interface IDencrypt
    {
        List<string> Dencrypt(List<string> source, string key);
    }
}
