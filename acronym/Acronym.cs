using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        //var rgx = new Regex("[^a-zA-Z0-9 -]");
        //phrase = rgx.Replace(phrase, "");



        phrase = Regex.Replace(phrase, @"([^a-zA-Z0-9 -]|^\s)", "");

        var acronym = "";
        phrase.Split(' ').ToList().ForEach(i => acronym += i != null ? i[0].ToString() : "");

        return acronym.ToUpper();
    }
}