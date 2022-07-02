using System.Globalization;

namespace NetSamples.Strings;

public class StringWorker
{
    public void ConcatString()
    {
        var str1 = "hello";
        var str2 = "world";

        var hw = str1 + " " + str2; //hello world

        var helloWorld = string.Concat(str1, str2);


        var strings = new string[] {str1, str2};
        var joiningStringResult = string.Join(' ', strings);
    }

    public void ComparingStrings()
    {
        var str1 = "hello";
        var str2 = "world";

        int comparingResult = string.Compare(str1, str2, StringComparison.InvariantCultureIgnoreCase);
    }

    public void SearchSubstring()
    {
        var str = "hello world";

        var index = str.IndexOf("he");
        var index2 = str.LastIndexOf('l'); //l from world

        var isStartWith = str.StartsWith("hello");
        var isEndWith = str.EndsWith("ld");
    }

    public void SplitString()
    {
        var str = "The day was shiny.       It was hot";

        var words = str.Split(" ");

        var onlyWords = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    }

    public void TrimString()
    {
        var str = "   Hello world       ";
      
        var str2 = "_*_Hello world_*_";

        str = str.Trim();//Hello world
        str2 = str2.Trim('_', '*');//Hello world

        var strTrimmedFromStart = str.TrimStart();
        var strTrimmedFromEnd = str.TrimEnd();


        var world = str.Substring(6);//world
        var wo = str.Substring(6,2);//wo
    }

    public void ChangeSymbolsInString()
    {
        var str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ac dui ut risus venenatis cursus.";

        var replacedString = str.Replace('o', 'a');
        var replacedString2 = str.Replace("do", "po");
        var replacedString3 = str.Replace(" ", "");
    }

    public void RemoveSubstring()
    {
        var str = "hello world";


        var lastIndex = str.Length - 1;

        str = str.Remove(lastIndex);//hello worl
        str = str.Remove(0,3);//lo worl
    }


    public void FormatString()
    {
        string name = "Bob";
        int age = 28;
        string company= "Microsoft";

        var resultString = $"{name}-{age}-{company}";

        //old syntax version 
        //var resultStr = string.Format("{0}-{1}-{2}", name, age, company);

        var emailTemplate = "{0}-{1}-{2}";
        var resultStr = string.Format(emailTemplate, name, age, company);

        int x = 15;

        Console.WriteLine(x.ToString("##.000"));

        var now = DateTime.Now;
        Console.WriteLine(now);
        Console.WriteLine(now.ToString("Y"));
        Console.WriteLine(now.ToString("d"));
        Console.WriteLine(now.ToString("D"));
        Console.WriteLine(now.ToString("F"));
        Console.WriteLine(now.ToString("f"));
        Console.WriteLine(now.ToString("G"));
        Console.WriteLine(now.ToString("O"));
        Console.WriteLine(now.ToString("R"));
        Console.WriteLine(now.ToString("U"));

        var upper = resultString.ToUpper();
        var upper2 = resultString.ToUpperInvariant();

        var lower = resultString.ToLower();
        var lower2 = resultString.ToLowerInvariant();
    }
}