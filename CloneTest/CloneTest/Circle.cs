using System;
using System.Collections.Generic;
using System.Text;

namespace CloneTest
{
    class Circle : ICloneable
    {
        #region properties

        private double _radius;

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public double Circumference => (Radius * 2) * Math.PI;

        public double Area => (Radius * Radius) * Math.PI;
       
        #endregion


        #region methods

        public Circle(double rad)
        {
            Radius = rad;
        }

        public object Clone()
        {
            var tmpy = new Circle(this.Radius);
            return tmpy;

        }


        #endregion




    }
}
