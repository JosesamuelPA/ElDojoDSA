//public class Solution
//{
//    public static string[] StringToArray(string str)
//    {
//        string[] spaceSeparetedWords = new string[1];
//        int numberWords = 1;
//        int wordsAdded = 0;
//        string word = "";
//        for (int i = 0; i <= 1; i++)
//        {
//            for (int e = 0; e < str.Length; e++)
//            {
//                if (i == 0)
//                {
//                    if (str[e] == ' ')
//                    {
//                        numberWords++;
//                    }
//                    if (e == str.Length - 1)
//                    {
//                        spaceSeparetedWords = new string[numberWords];
//                    }
//                }
//                else
//                {
//                    if (str[e] != ' ' && e != str.Length - 1)
//                    {
//                        word += str[e];
//                    }
//                    else if (str[e] == ' ' || e == str.Length - 1)
//                    {
//                        if (str[e] != ' ')
//                        {
//                            word += str[e];
//                        }
//                        spaceSeparetedWords[wordsAdded] = word;
//                        word = "";
//                        wordsAdded++;
//                    }
//                }
//            }
//        }
//        return spaceSeparetedWords;
//    }
//}

string str = "I love arrays they are my favorite";
string[] spaceSeparetedWords = str.Split(" ");
foreach(string word in spaceSeparetedWords) Console.WriteLine(word);