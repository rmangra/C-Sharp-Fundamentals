using System;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long piece of text.";
            var summary = StringUtility.SummarizeText(sentence, 30);
            Console.WriteLine(summary);
        }
    }
}
