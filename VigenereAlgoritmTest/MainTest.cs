using FluentAssertions;
using System;
using System.Diagnostics.CodeAnalysis;
using Vigenere_Cipher;
using Xunit;

namespace VigenereCipherTest
{
    [ExcludeFromCodeCoverage]
    public class MainTest
    {
        private Main main;

        public MainTest()
        {
            main = new Main();
        }

        [Fact]
        public void MainEncrypt_CorrectData_ReturnList()
        {
            var text = new string[] { "QWERTY", "qwerty" };
            var key = "test";

            var result = main.Encrypt(text, key);

            result.Should().Contain("jawkmc");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void MainEncrypt_EmptyKey_ReturnThrow(string key)
        {
            var text = new string[] { "QWERTY", "qwerty" };

            Action action = () => main.Encrypt(text, key);

            action.Should()
                .Throw<ArgumentNullException>();
        }

        [Theory]
        [InlineData("ФысК")]
        [InlineData(" ")]
        public void MainEncrypt_IncorrectKey_ReturnThrow(string key)
        {
            var text = new string[] { "QWERTY", "qwerty" };

            Action action = () => main.Encrypt(text, key);

            action.Should()
                .Throw<Exception>()
                .WithMessage($"Ключ {key} не соответствует алфавиту");
        }

        [Fact]
        public void MainEncrypt_EmptyArray_ReturnThrow()
        {
            var text = new string[0];
            var key = "test";

            Action action = () => main.Encrypt(text, key);

            action.Should()
                .Throw<ArgumentNullException>();
        }

        [Fact]
        public void MainEncrypt_IncorrectArray_ReturnList()
        {
            var text = new string[] { "ФыВаП" };
            var key = "test";

            var result = main.Encrypt(text, key);

            result.Should().Contain("фывап");
        }

        [Fact]
        public void MainDencrypt_CorrectData_ReturnList()
        {
            var text = new string[] { "aiDEHa ohkpv!", "aideha ohkpv!" };
            var key = "test";

            var result = main.Dencrypt(text, key);

            result.Should().Contain("hellow world!");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void MainDencrypt_EmptyKey_ReturnThrow(string key)
        {
            var text = new string[] { "QWERTY", "qwerty" };

            Action action = () => main.Dencrypt(text, key);

            action.Should()
                .Throw<ArgumentNullException>();
        }

        [Theory]
        [InlineData("ФысК")]
        [InlineData(" ")]
        public void MainDencrypt_IncorrectKey_ReturnThrow(string key)
        {
            var text = new string[] { "QWERTY", "qwerty" };

            Action action = () => main.Dencrypt(text, key);

            action.Should()
                .Throw<Exception>()
                .WithMessage($"Ключ {key} не соответствует алфавиту");
        }

        [Fact]
        public void MainDencrypt_EmptyArray_ReturnThrow()
        {
            var text = new string[0];
            var key = "test";

            Action action = () => main.Dencrypt(text, key);

            action.Should()
                .Throw<ArgumentNullException>();
        }

        [Fact]
        public void MainDencrypt_IncorrectArray_ReturnList()
        {
            var text = new string[] { "ФыВаП" };
            var key = "test";

            var result = main.Dencrypt(text, key);

            result.Should().Contain("фывап");
        }
    }
}
