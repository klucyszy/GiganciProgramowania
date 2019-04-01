using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.CezarCipher
{
    public static class CezarCipher
    {
        /// <summary>
        /// Szyfr Cezara. Wersja rozszerzona. Umożliwia przesunięcie o 51 znaków.
        /// </summary>
        /// <param name="text">Tekst do zaszyfrowania</param>
        /// <param name="delay">Przesunięcie</param>
        public static string Extended(string text, int delay)
        {
            var result = string.Empty;
            var char_array = text.ToCharArray();
            var modulo_delay = delay % 52;

            foreach (char _char in char_array)
            {
                //Pomijamy, jeżeli znak to spacja, kropka, lub przecinek
                if (_char == ' ' || _char == '.' || _char == ',')
                {
                    result += _char;
                    continue;
                }

                //Deklarujemy nowy znak
                char _newChar = (char)(_char + modulo_delay);

                // Jeżeli nowy znak jest większy od 'z' (122)
                if (_newChar > 'z')
                {
                    //Jeżeli znak wpadł w zakres pomiędzy 'Z' (65) a 'a' (90) czyli w zakres (91-96)
                    if (_char >= 'A' && _char <= 'Z')
                    {
                        //Do wartości nowego znaku dodajemy 6;
                        _newChar = (char)(_newChar + 6);
                    }
                    else
                    {
                        //Poprawiamy przesunięcie modulo tj. nowyZnak - 122;
                        //do 'A' (65) dodajemy wartość przesunięcia
                        modulo_delay = _newChar - 'z';
                        _newChar = (char)('A' + modulo_delay);
                    }
                }

                //Jeżeli nowyZnak wpadł w zakres pomiędzy 'Z' (90) a 'a' (97) czyli w zakres (91-96)
                if (_newChar > 'Z' && _newChar < 'a')
                {
                    //Do wartości nowego znaku dodajemy 6;
                    _newChar = (char)(_newChar + 6);
                }

                //Po każdej iteracji nadpisujemy wartość wyniku o nowy znak
                result += _newChar;
            }

            return result;
        }

        /// <summary>
        /// Szyfr Cezara. Wersja podstawowa. Umożliwia przesunięcie o 25 znaków.
        /// </summary>
        /// <param name="text">Tekst do zaszyfrowania</param>
        /// <param name="delay">Przesunięcie</param>
        public static string Basic(string text, int delay)
        {
            var result = string.Empty;
            var char_array = text.ToCharArray();
            var modulo_delay = delay % 26;

            foreach (char _char in char_array)
            {
                //Pomijamy, jeżeli znak to spacja, kropka, lub przecinek
                if (_char == ' ' || _char == '.' || _char == ',')
                {
                    result += _char;
                    continue;
                }

                //Deklarujemy nowy znak
                char _newChar = (char)(_char + modulo_delay);

                //Jeżeli znak przed zaszyfrowaniem znajduje się w zakresie od 'A' (65) do 'Z' (90)
                if (_char >= 'A' && _char <= 'Z')
                {
                    if (_newChar > 'Z')
                    {
                        modulo_delay = modulo_delay - 'Z';
                        _newChar = (char)('a' + modulo_delay);
                    }
                }
                else
                {
                    if (_newChar > 'z')
                    {
                        modulo_delay = modulo_delay - 'z';
                        _newChar = (char)('A' + modulo_delay);
                    }
                }

                //Po każdej iteracji nadpisujemy wartość wyniku o nowy znak
                result += _newChar;

            }

            return result;
        }
    }
}
