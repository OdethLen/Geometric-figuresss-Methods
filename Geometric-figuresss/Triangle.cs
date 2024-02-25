using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figuresss
{
    internal class Triangle: Fig2D
    {
		//Properties
		protected double base_;

		public double Base_
		{
			get { return base_; }
			set { base_ = value; }
		}

		private double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		//Constructor
		public Triangle() 
		{
			base_ = 0;
			height = 0;
		}

        //Method 
        public double GetTriangleArea() //Con retorno de datos y sin parametros 
        {
            return (base_*height)/2;
        }
    }
}
