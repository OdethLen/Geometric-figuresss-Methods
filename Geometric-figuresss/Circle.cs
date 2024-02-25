using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figuresss
{
    internal class Circle: Figure
    {
		//Properties
		protected double PI = 3.1416; //Methodo que regresa un valor pero no recibe 

		protected double radius;
		
		public double Radius
		{
			get { return radius; }
			set { radius = value; }
		}
		
		//Constructor
		public Circle ()
		{
			radius= 0;
		}

		//Method Con Parametros de salida y sin parametros de entrada 

		public double GetCircleArea ()
		{ 
			return PI*(Math.Pow(radius,2)); 
		}

        //Method Con Parametros de salida y sin parametros de entrada 

        public double GetCirclePerimeter () 
		{
			return 2 * PI * radius;
		}
	}
}
