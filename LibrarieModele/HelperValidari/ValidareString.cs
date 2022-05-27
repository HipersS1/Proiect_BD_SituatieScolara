using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibrarieModele
{
    /// <summary>
    /// Valideaza un string si il returneaza sub forma de raspuns {string, mesajEroare}
    /// </summary>
    public static class ValidareString
    {
        /// <summary>
        /// Valideaza string + formarea aspectului ex: 'facultatea inginerie' -> 'Facultatea Inginerie'
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static RezultatString ValideazaDenumire(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new RezultatString(null, "Campul nu trebuie sa fie gol");

            str = str.Trim();

            if(ContineCifre(str) == true)
                return new RezultatString(null, "Campul introdus nu trebuie sa contina cifre");

            string caractereSpeciale;
            if(ContineCaractereSpeciale(str, out caractereSpeciale))
                return new RezultatString(null, $"Campul introdus nu trebuie sa contina caractere speciale: {caractereSpeciale}");

            return new RezultatString(FormateazaString(str), "Succes");
        }

        public static RezultatString ValideazaDenumireMaterie(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new RezultatString(null, "Campul nu trebuie sa fie gol");

            str = str.Trim();

            for (int i = 0; i < str.Length; i++)
            {
                if(Char.IsDigit(str[i]) && i != str.Length-1)
                    return new RezultatString(null, "Campul introdus are cifre introduse gresit");
            }

            string caractereSpeciale;
            if (ContineCaractereSpeciale(str, out caractereSpeciale))
                return new RezultatString(null, $"Campul introdus nu trebuie sa contina caractere speciale: {caractereSpeciale}");

            return new RezultatString(FormateazaString(str), "Succes");
        }

        public static RezultatString ValideazaEmail(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new RezultatString(null, "Campul nu trebuie sa fie gol");

            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                 RegexOptions.CultureInvariant | RegexOptions.Singleline);

            bool isValidEmail = regex.IsMatch(str);

            if(!isValidEmail)
                return new RezultatString(null, $"Campul nu respecta exemplul: example@example.com");

            return new RezultatString(str, "Succes");
        }


        public static RezultatString ValideazaNumarTelefon(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new RezultatString(null, "Campul nu trebuie sa fie gol");

            Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

            bool isValidNumber = regex.IsMatch(str);

            if(!isValidNumber)
                return new RezultatString(null, $"Valori introduse incorect: Ex. 07xxxxxxxxxx");

            return new RezultatString(str, "Succes");
        }



        /// <summary>
        /// Verifica daca stringul primit contine cifre
        /// </summary>
        /// <param name="str">stringul de verificat</param>
        /// <returns></returns>
        public static bool ContineCifre(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica daca stringul primit contine caractere speciale
        /// </summary>
        /// <param name="str">stringul de verificat</param>
        /// <param name="caractere">caracterele ce au fost gasite</param>
        /// <returns></returns>
        public static bool ContineCaractereSpeciale(string str, out string caractere)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string caractereSpeciale = "!@#$%^&*()_=+/\\<>?;:'";

            foreach (char caracterSpecial in caractereSpeciale)
            {
                if (str.IndexOf(caracterSpecial) != -1)
                    stringBuilder.Append(caracterSpecial);
            }
            caractere = stringBuilder.ToString();
            return stringBuilder.Length > 0 ? true : false;
        }

        /// <summary>
        /// Formateaza stringu sub format: aaa bbb ccc -> Aaa Bbb Ccc
        /// </summary>
        /// <param name="stringToFormat"></param>
        /// <returns></returns>
        public static string FormateazaString(string stringToFormat)
        {
            string[] rebuildStr = stringToFormat.Split(' ');
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string s in rebuildStr)
            {
                stringBuilder.Append(char.ToUpper(s[0]) + s.Substring(1).ToLower() + " ");
            }

            return stringBuilder.ToString().Trim();
        }
    }


    

    /// <summary>
    /// Forma de raspuns dupa validare -> {Text, MesajEroare}
    /// </summary>
    public struct RezultatString
    {
        public string Text { get; }
        public string Mesaj { get; }

        public RezultatString(string str, string msj)
        {
            Text = str;
            Mesaj = msj;
        }

        public override string ToString()
        {
            return $"{Mesaj} : {Text}";
        }
    }
}
