using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharplearn
{
   public  class Stringbuilder  
    {
        public static  int GetCount(string Container, string Target)
        {
            if (Container.Contains(Target))
            {
                return Regex.Matches(Container ,Target).Count;
            }
            else
            {
                return -1;
            } 
        }


        public static  string mimicJoin(string separator ,string[] value)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < value.Length; i++)
            {
                sb = sb.Append(value[i]);
                if (i != value.Length-1)
                {
                    sb.Append(separator);
                }
            }
            return sb.ToString();
        }
    }
}
