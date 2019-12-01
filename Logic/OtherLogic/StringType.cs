using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.OtherLogic
{
    public class StringType
    {

        public static string CheckValid(string text)
        {
            Regex regex = new Regex("@^[А-Я][а-я]*$");

            if (regex.IsMatch(text))
                return text;
            else throw new Exception("Поле введено не верно!");
        }

        public static string Translyte(string text)
        {
            string strIn = text;
            string strOut = "";
            Dictionary<string, string> TranslyteDictionary = AddDictionaryTranslyte();
            foreach(char ch in strIn)
            {
               strOut += TranslyteDictionary.Where(tr => tr.Key == ch.ToString()).FirstOrDefault().Value;
                if (TranslyteDictionary.Where(tr => tr.Key == ch.ToString()).FirstOrDefault().Value == "")
                    strOut += ch;
            }
            return strOut;
        }

        static Dictionary<string,string> AddDictionaryTranslyte()
        {
            Dictionary<string, string> TranslyteDictionary = new Dictionary<string, string>();
            TranslyteDictionary.Add("а", "a");
            TranslyteDictionary.Add("б", "b");
            TranslyteDictionary.Add("в", "v");
            TranslyteDictionary.Add("г", "g");
            TranslyteDictionary.Add("д", "d");
            TranslyteDictionary.Add("е", "e");
            TranslyteDictionary.Add("ё", "yo");
            TranslyteDictionary.Add("ж", "zh");
            TranslyteDictionary.Add("з", "z");
            TranslyteDictionary.Add("и", "i");
            TranslyteDictionary.Add("й", "j");
            TranslyteDictionary.Add("к", "k");
            TranslyteDictionary.Add("л", "l");
            TranslyteDictionary.Add("м", "m");
            TranslyteDictionary.Add("н", "n");
            TranslyteDictionary.Add("о", "o");
            TranslyteDictionary.Add("п", "p");
            TranslyteDictionary.Add("р", "r");
            TranslyteDictionary.Add("с", "s");
            TranslyteDictionary.Add("т", "t");
            TranslyteDictionary.Add("у", "u");
            TranslyteDictionary.Add("ф", "f");
            TranslyteDictionary.Add("х", "h");
            TranslyteDictionary.Add("ц", "c");
            TranslyteDictionary.Add("ч", "ch");
            TranslyteDictionary.Add("ш", "sh");
            TranslyteDictionary.Add("щ", "sch");
            TranslyteDictionary.Add("ъ", "j");
            TranslyteDictionary.Add("ы", "i");
            TranslyteDictionary.Add("ь", "j");
            TranslyteDictionary.Add("э", "e");
            TranslyteDictionary.Add("ю", "yu");
            TranslyteDictionary.Add("я", "ya");
            TranslyteDictionary.Add("А", "A");
            TranslyteDictionary.Add("Б", "B");
            TranslyteDictionary.Add("В", "V");
            TranslyteDictionary.Add("Г", "G");
            TranslyteDictionary.Add("Д", "D");
            TranslyteDictionary.Add("Е", "E");
            TranslyteDictionary.Add("Ё", "Yo");
            TranslyteDictionary.Add("Ж", "Zh");
            TranslyteDictionary.Add("З", "Z");
            TranslyteDictionary.Add("И", "I");
            TranslyteDictionary.Add("Й", "J");
            TranslyteDictionary.Add("К", "K");
            TranslyteDictionary.Add("Л", "L");
            TranslyteDictionary.Add("М", "M");
            TranslyteDictionary.Add("Н", "N");
            TranslyteDictionary.Add("О", "O");
            TranslyteDictionary.Add("П", "P");
            TranslyteDictionary.Add("Р", "R");
            TranslyteDictionary.Add("С", "S");
            TranslyteDictionary.Add("Т", "T");
            TranslyteDictionary.Add("У", "U");
            TranslyteDictionary.Add("Ф", "F");
            TranslyteDictionary.Add("Х", "H");
            TranslyteDictionary.Add("Ц", "C");
            TranslyteDictionary.Add("Ч", "Ch");
            TranslyteDictionary.Add("Ш", "Sh");
            TranslyteDictionary.Add("Щ", "Sch");
            TranslyteDictionary.Add("Ъ", "J");
            TranslyteDictionary.Add("Ы", "I");
            TranslyteDictionary.Add("Ь", "J");
            TranslyteDictionary.Add("Э", "E");
            TranslyteDictionary.Add("Ю", "Yu");
            TranslyteDictionary.Add("Я", "Ya");
            return TranslyteDictionary;
        }
    }
}
