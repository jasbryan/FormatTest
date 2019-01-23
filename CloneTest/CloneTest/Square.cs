using System;
using System.Collections.Generic;
using System.Text;

namespace CloneTest
{
    class Square : ICloneable
    {
        #region properties

        private double _side;

        public double Side
        {
            get => _side;
            set => _side = value;
        }

        public double Permimeter => Side * 4;

        public double Area => Side * Side; 

        #endregion




        public object Clone()
        {
            var tmpy = new Square(this.Side);
            return tmpy;
        }
        

        public Square(double side)
        {
            Side = side;
        }



    }
}
