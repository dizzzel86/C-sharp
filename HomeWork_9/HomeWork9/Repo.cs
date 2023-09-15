using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class Repo
    {
        

        public static string InvertString(string inputText)
        {
                        
            string[] invertString = inputText.Split(' ');
            string word = string.Empty;
            for (int i = invertString.Length - 1; i >= 0; i--)

            { 
                Debugger.Log(0, null, invertString[i]);
                word += invertString[i] + " ";
            }
            return word;
           
        }
    }
}
