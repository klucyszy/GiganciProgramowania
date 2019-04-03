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
                //Deklarujemy nowy znak
                char _newChar = (char)(_char + modulo_delay);

                if (_char >= 'A' && _char <= 'Z')
                {
                    if (_newChar > 'Z')
                    {
                        _newChar = (char)(_newChar + 6);
                        if (_newChar > 'z')
                        {
                            modulo_delay = _newChar - 'z';
                            _newChar = (char)('A' + modulo_delay - 1);
                        }
                    }
                }
                else if (_char >= 'a' && _char <= 'z')
                {
                    if (_char + modulo_delay > 'z')
                    {
                        modulo_delay = _newChar - 'z';
                        _newChar = (char)('A' + modulo_delay - 1);
                    }
                }
                else
                {
                    result += _char;
                    continue;
                }

                result += _newChar.ToString();
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
                        modulo_delay -= 'Z';
                        _newChar = (char)('a' + modulo_delay);
                    }
                }
                else
                {
                    if (_newChar > 'z')
                    {
                        modulo_delay -= 'z';
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
