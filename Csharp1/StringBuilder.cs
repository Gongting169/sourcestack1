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

        //public static string  MimicJoin( params String[] value)
        //{          
     
        //}

    }
}
