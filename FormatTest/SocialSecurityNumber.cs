using System;
using System.Collections.Generic;
using System.Text;

namespace FormatTest
{
    class SocialSecurityNumber : IFormatter
    {
        private int groupOne;

        private int groupTwo;

        private int groupThree;

        private string formattedSsn;

        public SocialSecurityNumber(string number)
        {
            groupOne = int.Parse(number.Substring(0, 3));
            groupTwo = int.Parse(number.Substring(3, 2));
            groupThree = int.Parse(number.Substring(5, 4));
        }

        public void Format()
        {
            formattedSsn = groupOne + "-" + groupTwo + "-" + groupThree;
        }

        public override string ToString()
        {
           if(String.IsNullOrEmpty(formattedSsn)) { Format(); }
           return formattedSsn;
        }
    }
}
