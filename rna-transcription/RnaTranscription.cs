using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dict = new Dictionary<char,char>() { {'G','C'},{'C','G'},{'T','A'},{'A','U'} };
        string rna = "";
        foreach (var c in nucleotide)
            rna += dict[c].ToString();
        return rna;
    }
}