using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    abstract class Member 
    {
        private string _name;

        private string _address;

        private string _phone;

        public string Name
        {
            get => _name; 
            set => _name = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public abstract double Dues { get; set; }

        public Member(string name, string address, string phone)
        {
            _name = name;
            _address = address;
            _phone = phone;
        }

        public override string ToString()
        {
            return $"Name:{_name}, Address:{_address}, Phone:{_phone}";
        }
    }
}
