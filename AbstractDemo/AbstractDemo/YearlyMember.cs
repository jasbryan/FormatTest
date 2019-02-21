using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class YearlyMember : Member
    {
        private double _dues;

        public override double Dues
        {
            get => _dues;
            set => _dues = value;
        }

        public double WeeklyDues { get => _dues / 52; }

        public double MonthlyDues { get => _dues / 12; }

        public YearlyMember(string name, string address, string phone, double dues) : base(name,address,phone)
        {
            _dues = dues;
        }

        public override string ToString()
        {
            return base.ToString() + $", Dues:{_dues}";
        }

    }
}
