using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOdemo
{
    class CustomerRecord
    {
        private string _lastName;

        private string _firstName;

        private string _customerNumber;

        public string LastName { get => _lastName; }

        public string FirstName { get => _firstName; }

        public string CustomerNumber { get => _customerNumber; }

        public CustomerRecord(string lastName, string firstName, string customerNumber)
        {
            _lastName = lastName;
            _firstName = firstName;
            _customerNumber = customerNumber;
        }

        public override string ToString() => $"{_lastName}, {_firstName}:{_customerNumber}";


    }
}
