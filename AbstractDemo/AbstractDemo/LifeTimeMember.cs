using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class LifeTimeMember : Member
    {
        private double _dues;

        private double _discount;

        public double Discount
        {
            get => _discount;
            set => _discount = value;
        }

        public override double Dues
        {
            get => _dues;
            set
            {
                if(value > 0)
                {
                    _dues = value * (0.85);
                }
            }
        }

        public LifeTimeMember(string name, string address, string phone, double dues) : base(name,address,phone)
        {
            _dues = dues;
        }

        public override string ToString()
        {
            return base.ToString() + $", Dues:{_dues}";
        }



    }

}
