using System;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Common_Library
{
    public static class ValidationHelper
    {

        //
        public static bool ValidateEmail(string emailAddress)
        {

            if (IsTxtEmpty(emailAddress))
                return false;

            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);

        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (IsTxtEmpty(phoneNumber))
                return false;

            var pattern = @"^\+?[0-9\s\-\(\)]{7,20}$";
            var regex = new Regex(pattern);

            return regex.IsMatch(phoneNumber);
        }
        public static bool ValidatePasswordStrength(string password)
        {
            if (IsTxtEmpty(password))
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSymbol = false;

            foreach (var c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSymbol = true;
            }

            return password.Length >= 8 && hasUpper && hasLower && hasDigit && hasSymbol;
        }
        public static bool ValidateInteger(string Number)
        {

            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);

        }
        public static bool Validatedecimal(string Number)
        {

            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);

        }
        public static bool IsNumber(string Number)
        {

            return (ValidateInteger(Number) || Validatedecimal(Number));
        }
        public static bool IsNumberBetween(int number, int from, int to) => number >= from && number <= to;
        public static bool IsNumberBetween(double number, double from, double to) => number >= from && number <= to;
        public static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        public static bool IsLetter(char c) => c >= 97 && (int)c <= 122 || (int)c >= 65 && (int)c <= 90;
        public static bool IsUpper(char c) => IsLetter(c) && c == ToUpper(c);
        public static bool IsLower(char c) => IsLetter(c) && c == ToLower(c);
        public static bool IsVowel(char character)
        {
            character = ToLower(character);

            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;

                default:
                    return false;
            }
        }
        public static bool IsPunctuation(char character)
        {
            switch (character)
            {
                case '.':
                case '?':
                case '\'':
                case ',':
                case '_':
                case '-':
                case '!':
                case ':':
                case '(':
                case ')':
                case '[':
                case ']':
                    return true;
                default:
                    return false;
            }
        }

        //

        public static string DecryptText(string text, short encryptionKey = (short)(3 * 12 - 17))
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] - encryptionKey);
            }
            return new string(chars);
        }
        public static string EncryptText(string text, short encryptionKey = (short)(3 * 12 - 17))
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] + encryptionKey);
            }
            return new string(chars);
        }

        public static string ComputeHashWithSHA256(string input)
        {

            // one way

            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static string EncryptWithAES(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        public static string DecryptWithAES(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }

        //
        static char ToUpper(char c) => (int)c >= 97 && (int)c <= 122 ? (char)((int)c - 32) : c;
        static char ToLower(char c) => (int)c >= 65 && (int)c <= 90 ? (char)((int)c + 32) : c;

        //
        public static int CountWords(string s)
        {

            bool isStartedWord = true;
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && isStartedWord)
                    counter++;

                isStartedWord = s[i] == ' ' ? true : false;

            }

            return counter;

        }
        public static int CountVowels(string s)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
                if (IsVowel(s[i]))
                    counter++;

            return counter;
        }
        public static string RemoveWhiteSpaces(string s)
        {
            return string.Join("", s.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries));
        }
        public static string RemovePunctuations(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
                if (!IsPunctuation(s[i]))
                    result += s[i];

            return result;
        }
        public static string LowerFirstLetterOfEachWord(string word)
        {

            string result = "";
            bool isFirstLetter = true;


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ' && isFirstLetter)
                    result += ToLower(word[i]);
                else
                    result += word[i];


                isFirstLetter = word[i] == ' ' ? true : false;
            }

            return result;
        }
        public static string CapitalizeFirstLetterOfEachWord(string input)
        {
            if (IsTxtEmpty(input)) return input;

            var words = input.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                else
                    words[i] = words[i].ToUpper();
            }
            return string.Join(" ", words);
        }
        public static int GenerateRandomNumber(int from, int to)
        {
            Random rnd = new Random();
            return rnd.Next(from, to);
        }
        public static void SwapTwoParams(ref object param1, ref object param2)
        {
            object temp = param1;

            param1 = param2;
            param2 = temp;
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;
                left++;
                right--;
            }
            return true;
        }

        //
        public static bool WriteOnlyNumber(char IsDigitOrControl)
        {

            return (!char.IsControl(IsDigitOrControl) && !char.IsDigit(IsDigitOrControl));

            // true e.Handled true;
        }
        public static bool WriteOnlyLetters(char IsLettersOrControlOrSpace)
        {

            return (!char.IsControl(IsLettersOrControlOrSpace) &&
                !char.IsLetter(IsLettersOrControlOrSpace) && IsLettersOrControlOrSpace != ' ');

            // true e.Handled true;
        }
        public static bool IsTxtEmpty(string Text)
        {
            return Text.Length == 0;

            //true 
            //e.Cancel = true;
            //errorProvider1.SetError(Text, "This field is required!");

            //false
            //errorProvider1.SetError(Text, null);
        }
        public static bool ObjectIsNull(object obj)
        {
            return obj == null;
        }

    }
}
