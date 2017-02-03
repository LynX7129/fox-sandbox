using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {

        class Dictionary
        {

            public void Translator(string cyrillic)

            {
                string translatedText = "";

                Dictionary<char, string> translator = new Dictionary<char, string>();
                translator.Add('а', "a");
                translator.Add('б', "b");
                translator.Add('в', "v");
                translator.Add('г', "g");
                translator.Add('д', "d");
                translator.Add('е', "ye");
                translator.Add('ё', "yo");
                translator.Add('ж', "zh");
                translator.Add('з', "z");
                translator.Add('и', "i");
                translator.Add('й', "y");
                translator.Add('к', "k");
                translator.Add('л', "l");
                translator.Add('м', "m");
                translator.Add('н', "n");
                translator.Add('о', "o");
                translator.Add('п', "p");
                translator.Add('р', "r");
                translator.Add('с', "s");
                translator.Add('т', "t");
                translator.Add('у', "u");
                translator.Add('ф', "f");
                translator.Add('х', "h");
                translator.Add('ч', "ch");
                translator.Add('ш', "sh");
                translator.Add('щ', "sh");
                translator.Add('ъ', "'");
                translator.Add('ы', "y");
                translator.Add('ь', "'");
                translator.Add('э', "e");
                translator.Add('ю', "yu");
                translator.Add('я', "ya");
                translator.Add(' ', " ");

                foreach (char letter in cyrillic)
                {

                    if (translator.ContainsKey(Char.ToUpper(letter)))
                        translatedText += translator[char.ToUpper(letter)];
                    else
                        translatedText += translator[char.ToLower(letter)];
                }

                Console.WriteLine("Translated text: {0}", translatedText);
            }


            static void Main(string[] args)
            {
                Console.WriteLine("Write a text: ");
                Dictionary work = new Dictionary();
                string text = Console.ReadLine();
                work.Translator(text);

                Console.ReadKey();

            }
        }
    }
}
