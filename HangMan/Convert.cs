using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Convert
    {
        public static char[] ToCharArray(SecretWord word)
        {
            char[] secretWordArray = new char[word.name.Length];
            for (int i = 0; i < word.name.Length; i++)
            {
                secretWordArray[i] = '*';
            }
            return secretWordArray;
        }
    }
}
