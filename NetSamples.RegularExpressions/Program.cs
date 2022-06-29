using System.Text.RegularExpressions;

namespace NetSamples.RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text =
                "When you picture mountain climbers scaling Mount Everest, what probably comes to mind are teams of climbers with Sherpa guides leading them to the summit, equipped with oxygen masks, supplies and tents. And in most cases you'd be right, as 97 per cent of climbers use oxygen to ascend to Everest's summit at 8,850 metres above sea level. The thin air at high altitudes makes most people breathless at 3,500 metres, and the vast majority of climbers use oxygen past 7,000 metres. A typical climbing group will have 8–15 people in it, with an almost equal number of guides, and they'll spend weeks to get to the top after reaching Base Camp.";

            var regex = new Regex(@"[Mm](\w*)");
            //var matches = regex.Matches(text);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}

            
            text= text.Replace(",", "");
            text= text.Replace(".", "");
            var words = text.Split(' ');
            var matches = new List<string>();
            foreach (var word in words)
            {
                if (word.StartsWith("m") || word.StartsWith("M"))
                {
                    matches.Add(word);
                }
            }
            foreach (string match in matches)
            {
                Console.WriteLine(match);
            }


            //verbatim string c#
            // Do you want to continue? Y\N
            var someText = @"Do you want to continue?""Y\N""";
            Console.WriteLine(someText);

        }
    }
}