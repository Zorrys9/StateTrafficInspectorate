using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.OtherLogic
{
    public class LogicVIN
    {
        public static bool CheckVIN(string vin)
        {
            bool result = false;
            if (vin.Length == 17)
            {
                var regex = new Regex(@"(.*[I,O,Q])");
                var regex2 = new Regex(@"(.*[0-9,A-Z])");
                if (regex.IsMatch(vin))
                {
                    result = false;
                }
                else if (GetResultWeight(vin) && regex2.IsMatch(vin))
                {

                    result = true;
                }
            }
            else result = false;
            return result;
        }

        static bool GetResultWeight(string vin)
        {
            List<int> list = new List<int>(17);
            list = GetListCode(vin);
            int Weight = 0;
            int i = 0;
            foreach (var item in list)
            {
                i++;
                if (i >= 1 && i < 8)
                {
                    Weight += item * (9 - i);
                }
                else if (i >= 10 && i <= 17)
                {
                    Weight += item * (19 - i);
                }
                else if (i == 8) Weight += item * 10;
            }
            int a = Weight / 11;
            int Weight2 = a * 11;
            int CHK = Weight - Weight2;
            if (list.ElementAt(8) == CHK && CHK != 10)
            {
                return true;
            }
            else return false;

        }
        static List<int> GetListCode(string vin)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < vin.Length; i++)
            {
                switch (vin.Substring(i, 1))
                {
                    case "0":
                        list.Add(0);
                        break;
                    case "1":
                        list.Add(1);
                        break;
                    case "2":
                        list.Add(2);
                        break;
                    case "3":
                        list.Add(3);
                        break;
                    case "4":
                        list.Add(4);
                        break;
                    case "5":
                        list.Add(5);
                        break;
                    case "6":
                        list.Add(6);
                        break;
                    case "7":
                        list.Add(7);
                        break;
                    case "8":
                        list.Add(8);
                        break;
                    case "9":
                        list.Add(9);
                        break;
                    case "A":
                        list.Add(1);
                        break;
                    case "B":
                        list.Add(2);
                        break;
                    case "C":
                        list.Add(3);
                        break;
                    case "D":
                        list.Add(4);
                        break;
                    case "E":
                        list.Add(5);
                        break;
                    case "F":
                        list.Add(6);
                        break;
                    case "G":
                        list.Add(7);
                        break;
                    case "H":
                        list.Add(8);
                        break;
                    case "J":
                        list.Add(1);
                        break;
                    case "K":
                        list.Add(2);
                        break;
                    case "L":
                        list.Add(3);
                        break;
                    case "M":
                        list.Add(4);
                        break;
                    case "N":
                        list.Add(5);
                        break;
                    case "P":
                        list.Add(7);
                        break;
                    case "R":
                        list.Add(9);
                        break;
                    case "S":
                        list.Add(2);
                        break;
                    case "T":
                        list.Add(3);
                        break;
                    case "U":
                        list.Add(4);
                        break;
                    case "V":
                        list.Add(5);
                        break;
                    case "W":
                        list.Add(6);
                        break;
                    case "X":
                        list.Add(7);
                        break;
                    case "Y":
                        list.Add(8);
                        break;
                    case "Z":
                        list.Add(9);
                        break;
                };
            }
            return list;
        }
    }
}
