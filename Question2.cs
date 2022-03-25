using System;

namespace codeSurvival
{
    class Num2
    {
        public static void Answer()
        {
            string s = "abccc";
            // string s = "aaaa";
            int length = s.Length;
           // int count = 0;
          // bool ck = true;
         // (s[i] == s[i + 1] && s[i] != s[i+1])

          //  string filter = 
            for(int i = 0; i<length; )
            {
                    //(s[i] != s[i+1] && s[i] == s[i+1] )
                if (s[i] == s[i+1]  ) 
                {
                    System.Console.WriteLine("false");
                    break;
                }
                else if(s[i] != s[i+1])
                {
                    System.Console.WriteLine("true");
                    break;
                }
                else
                {
                     System.Console.WriteLine("false");
                    break;
                }
                
             }

            // for (int i = 0; i<length; i++)
            // {
            //     for (int j = 1; j <length; j++)
            //     {
            //         if (s[i] != s[0] && s[i] == s[j] )
            //         {
            //              System.Console.WriteLine("false");
            //            break;
            //         }
            //         else
            //         {
            //              System.Console.WriteLine("true");
            //              break;
            //         }
            //     }
          //  }
      //  }
            // public static string FiterDuplicate(string s)
            // {
            //     bool ck = true;
            //      for (int i = 0; i<s.Length; i++)
            //     {
            //         for (int j = 1+1; j <s.Length; j++)
            //         {
            //             if ( s[i] == s[j] )
            //             {
            //                 return "false";
            //                 ck 
            //               // break;
            //             }
            //             else
            //             {
            //                  return "true";
            //                 // break;
            //             }
            //         }
            //    }
        }
    }
}