# **VigenereAlgorithm**
Библиотека для шифрования и дешифрования с помощью шифра Виженера

Как запустить?
-------------------------------------------------------------
* Подключуить библиотеку через Reference
* Язык, на котором происходит шифрование - Англ.
* Использование 

```C#
var vinegere = new Vigenere();

//шифрование 
var encryptResult = vinegere.Encrypt(IEnumerable<string> source, string key);

//дешифрование
var dencryptResult = vinegere.Dencrypt(IEnumerable<string> source,string key);
```
