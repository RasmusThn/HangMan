using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class SecretWord
    {
        public string name { get; set; }
        public int GuessCount { get; set; } = 0;

        public SecretWord(string word)
        {
            name = word;
        }
        
       
    }
}
