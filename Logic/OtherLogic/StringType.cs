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

    }
}
