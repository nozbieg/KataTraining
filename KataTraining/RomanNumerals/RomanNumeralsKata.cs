using System;
using System.Linq;

namespace KataTraining.RomanNumerals
{
    public static class RomanNumeralsKata
    {
        public static string ToRoman(int n)
        {
            string retVal = string.Empty;
            var stringNumber = n.ToString();
            var intList = stringNumber.Select(digit => int.Parse(digit.ToString())).Reverse().ToArray();
            var position = 0;
            foreach (var number in intList)
            {
                retVal += GetRomanian(number, position);
                position++;
            }
            return new string(retVal.ToArray().Reverse().ToArray());
        }
        static string ToRomanThousand(int number)
        {
            string retVal = string.Empty;
            for (int i = 0; i < number; i++)
            {
                retVal += "M";
            }
            return retVal;
        }
        static string GetRomanian(int number, int position)
        {
            switch (position)
            {
                case 0:
                    return ToRomanUnion(number);
                case 1:
                    return ToRomanTenth(number);
                case 2:
                    return ToRomanHundreth(number);
                default:
                    return ToRomanThousand(number);
            }
        }
        static string ToRomanHundreth(int number)
        {
            switch (number)
            {
                case 0:
                    return string.Empty;
                case 1:
                    return "C";
                case 2:
                    return "CC";
                case 3:
                    return "CCC";
                case 4:
                    return new string("CD".ToArray().Reverse().ToArray());
                case 5:
                    return "D";
                case 6:
                    return new string("DC".ToArray().Reverse().ToArray());
                case 7:
                    return new string("DCC".ToArray().Reverse().ToArray());
                case 8:
                    return new string("DCCC".ToArray().Reverse().ToArray());
                case 9:
                    return new string("CM".ToArray().Reverse().ToArray());
                default:
                    return string.Empty;
            }
        }
        static string ToRomanTenth(int number)
        {

            switch (number)
            {
                case 0:
                    return string.Empty;
                case 1:
                    return "X";
                case 2:
                    return "XX";
                case 3:
                    return "XXX";
                case 4:
                    return new string("XL".ToArray().Reverse().ToArray());
                case 5:
                    return "L";
                case 6:
                    return new string("LX".ToArray().Reverse().ToArray());
                case 7:
                    return new string("LXX".ToArray().Reverse().ToArray());
                case 8:
                    return new string("LXXX".ToArray().Reverse().ToArray());
                case 9:
                    return new string("XC".ToArray().Reverse().ToArray());
                default:
                    return string.Empty;
            }
        }
        static string ToRomanUnion(int number)
        {
            switch (number)
            {
                case 0:
                    return string.Empty;
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return new string("IV".ToArray().Reverse().ToArray());
                case 5:
                    return "V";
                case 6:
                    return new string("VI".ToArray().Reverse().ToArray());
                case 7:
                    return new string("VII".ToArray().Reverse().ToArray());
                case 8:
                    return new string("VIII".ToArray().Reverse().ToArray());
                case 9:
                    return new string("IX".ToArray().Reverse().ToArray());
                default:
                    return string.Empty;
            }
        }

        public static int FromRoman(string romanNumeral)
        {
            int result = 0;
            for (int i = 0; i < romanNumeral.ToArray().Count(); i++)
            {
                var isFour = WatchmakerFour(romanNumeral.ToArray(), i);
                if (isFour != 0)
                {
                    result += isFour;
                    i++;
                    continue;
                }
                var isSix = WatchmakerSix(romanNumeral.ToArray(), i);
                if (isSix != 0)
                {
                    result += isSix;
                    i++;
                    continue;
                }
                var number = GetActualNumber(romanNumeral[i]);
                result += number;
            }
            return result;
        }
        static int GetActualNumber(char value)
        {
            switch (value)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
        static int WatchmakerSix(char[] value, int i)
        {
            var number = CheckBefore(value, i);
            return number;
        }
        static int CheckBefore(char[] value1, int i)
        {
            if (i > 1)
            {

                var val = $"{value1[i]}{value1[i - 1]}";
                switch (val)
                {
                    case "VI":
                        return 6;
                    case "LX":
                        return 60;
                    case "DC":
                        return 600;
                    default: return 0;
                }
            }
            return 0;
        }
        static int WatchmakerFour(char[] value, int i)
        {
            var number = CheckNext(value, i);
            return number;
        }
        static int CheckNext(char[] value1, int i)
        {
            if (i < value1.Count() - 1)
            {

                var val = $"{value1[i]}{value1[i + 1]}";
                switch (val)
                {
                    case "IV":
                        return 4;
                    case "IX":
                        return 9;
                    case "XL":
                        return 40;
                    case "XC":
                        return 90;
                    case "CD":
                        return 400;
                    case "CM":
                        return 900;
                    default: return 0;
                }
            }
            return 0;
        }

    }
}
