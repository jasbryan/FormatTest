using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FormatTest
{
    class PhoneNumber : IFormatter
    {
        private int areaCode;

        private int exchangePrefix;

        private int phoneNumber;

        private string formattedPhoneNumber;


        public PhoneNumber(string number)
        {
            areaCode = int.Parse(number.Substring(0, 3));
            exchangePrefix = int.Parse(number.Substring(3, 3));
            phoneNumber = int.Parse(number.Substring(6, 4));
            formattedPhoneNumber = null;
        }


        public void Format()
        {
            formattedPhoneNumber = $"({areaCode}) {exchangePrefix}-{phoneNumber}";
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(formattedPhoneNumber))
            {
                Format();
            }
            return formattedPhoneNumber;
        }
    }
}
