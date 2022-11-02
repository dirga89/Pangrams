using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] temp = s.ToUpper().Trim().Replace(" ","").ToCharArray();
        List<int> index = new List<int>();
        int count = temp.Length;
        string result = "";
        int x = 0;

        for(int i=0; i<26; i++)
        {
            index.Add(0);
        }
        
        for(int i=0; i<26; i++)
        {
            for(int j=0; j<count; j++)
            {
                if(alpha[i] == temp[j] && index[i] == 0)
                {
                    index[i]++;
                }
            }
        }

        for(int i=0; i<26; i++)
        {
            x += index[i];
        }

        if(x == 26)
        {
            result = "pangram";
        }
        else
        {
            result = "not pangram";
        }

        Console.WriteLine(x.ToString());

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
