using System.Collections.Generic;
using System;

namespace codeSurvival
{
    class Num1
    {
        public static void Answer()
        { 
            // string s = "wordgoodgoodgoodbestword";
            // string[] myarr = {"word", "good", "best", "word"};
            // string s = "barfoofoobarthefoobarman";
            // string [] myarr = {"bar", "foo", "the"};
            string s = "barfoothefoobarman";
            string[] myarr = {"foo", "bar"};
            string a = "";
            string b= "";
           a = string.Concat(myarr);
           System.Console.WriteLine(a);

            System.Console.WriteLine();

            Array.Reverse(myarr);
            b = string.Concat(myarr);

            System.Console.WriteLine(b);
            for (int i = 0; i< s.Length; i++)
            {
                if(s.Contains(a))
                {
                    System.Console.WriteLine();
                   System.Console.Write($"{s.IndexOf(a)},");
                   break;
                }
            }

            for(int j= 0; j< s.Length; j++)
            {
                if (s.Contains(b))
                {
                    System.Console.Write($"{s.IndexOf(b)},");
                    break;
                }
            }
          
            

            

          //  List<string> mylist = new List<string>();
                
            //    for(int i = 0; i<myarr.Length; i++)
            //    {
            //       // Console.Write(myarr[i]);
            //    }

            //    Console.WriteLine();
                
            //     for(int i = myarr.Length-1; i>=0; i--)
            //     {
            //        string d  = $"{myarr.L}{myarr[0]}";
            //        // a = d
            //         System.Console.Write(d);
            //     }

           // System.Console.WriteLine(a);


            
        }
    }
}