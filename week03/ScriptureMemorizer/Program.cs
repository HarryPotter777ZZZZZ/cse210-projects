using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        {
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            Console.WriteLine("Original Scripture:");
            Console.WriteLine(scripture.GetDisplayText());

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to hide a random word or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                scripture.HideRandomWords(1);
                Console.WriteLine(scripture.GetDisplayText());
            }

            Console.WriteLine("\nAll words are hidden. Program ended.");
        }
    }
}


//         public class Scripture
//         {
//             private Reference _reference;
//             private List<Word> _words;

//             public Scripture(Reference reference, string text)
//             {
//                 _reference = reference;
//                 _words = text.Split(' ').Select(word => new Word(word)).ToList();
//             }

//             public void HideRandomWords(int numberToHide)
//             {
//                 Random random = new Random();
//                 for (int i = 0; i < numberToHide; i++)
//                 {
//                     int index = random.Next(_words.Count);
//                     if (!_words[index].IsHidden())
//                     {
//                         _words[index].Hide();
//                     }
//                     else
//                     {
//                         i--; // Retry if the word is already hidden
//                     }
//                 }
//             }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Reference reference = new Reference("John", 3, 16);
//         Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

//         Console.WriteLine("Original Scripture:");
//         Console.WriteLine(scripture.GetDisplayText());

//         while (!scripture.IsCompletelyHidden())
//         {
//             Console.WriteLine("\nPress Enter to hide a random word or type 'quit' to exit.");
//             string input = Console.ReadLine();
//             if (input.ToLower() == "quit")
//             {
//                 break;
//             }
//             scripture.HideRandomWords(1);
//             Console.WriteLine(scripture.GetDisplayText());
//         }

//         Console.WriteLine("\nAll words are hidden. Program ended.");
//     }
// }
//             public string GetDisplayText()
//             {
//                 return string.Join(" ", _words.Select(word => word.GetDisplayText()));
//             }

//             public bool IsCompletelyHidden()
//             {
//                 return _words.All(word => word.IsHidden());
//             }
//         }

//         public class Word
//         {
//             private string _text;
//             private bool _isHidden;

//             public Word(string text)
//             {
//                 _text = text;
//                 _isHidden = false;
//             }

//             public void Hide()
//             {
//                 _isHidden = true;
//             }

//             public void Show()
//             {
//                 _isHidden = false;
//             }

//             public bool IsHidden()
//             {
//                 return _isHidden;
//             }

//             public string GetDisplayText()
//             {
//                 return _isHidden ? new string('_', _text.Length) : _text;
//             }
//         }

//         public class Reference
//         {
//             private string _book;
//             private int _chapter;
//             private int _verse;
//             private int _endVerse;

//             public Reference(string book, int chapter, int verse)
//             {
//                 _book = book;
//                 _chapter = chapter;
//                 _verse = verse;
//                 _endVerse = verse;
//             }

//             public Reference(string book, int chapter, int startVerse, int endVerse)
//             {
//                 _book = book;
//                 _chapter = chapter;
//                 _verse = startVerse;
//                 _endVerse = endVerse;
//             }

//             public string GetDisplayText()
//             {
//                 return _verse == _endVerse ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}:{_verse}-{_endVerse}";
//             }
//         }

// // usage
// public class Program
// {
//     public static void Main()
//     {
//         Reference reference = new Reference("John", 3, 16);
//         Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

//         Console.WriteLine(scripture.GetDisplayText());
//         scripture.HideRandomWords(5);
//         Console.WriteLine(scripture.GetDisplayText());
//     }
// }    
//     }

// }