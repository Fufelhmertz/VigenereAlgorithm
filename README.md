# **VigenereAlgorithm**
Библиотека для шифрования и дешифрования с помощью шифра Виженера

Как запустить?
-------------------------------------------------------------
* Подключить библиотеку через Reference
* Язык, на котором происходит шифрование - Англ.
* Пример использования 

```C#
//Список значений для шифрования\дешифрования
var text = new string[] { "sample" };

//Ключ для шифрования\дешифрования
var key = "test";

var vinegere = new Vigenere();

//шифрование 
var encryptResult = vinegere.Encrypt(text, key);
Console.WriteLine(string.Join(Environment.NewLine, encryptResult)); //leeiei

//дешифрование
var dencryptResult = vinegere.Dencrypt(encryptResult, key);
Console.WriteLine(string.Join(Environment.NewLine, dencryptResult)); //sample

```
