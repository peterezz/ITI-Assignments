using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public enum Type
    {
        Ethernet,
        TokenRing
    }
    internal class NICSingltonClass
    {
        string manufactureDate;
        string macAddress;
         Type type;


        private static NICSingltonClass instance;

        public NICSingltonClass(string manufactureDate, string macAddress, Type type)
        {
            this.manufactureDate = manufactureDate;
            this.macAddress = macAddress;
            this.type = type;
        }

        public static NICSingltonClass CreateNicCard()
        {
            if(instance == null)
                instance = new NICSingltonClass( "assasa",  "dsdsds",  Type.Ethernet);

            return instance;
        }
        


        
        

        
    }
}
