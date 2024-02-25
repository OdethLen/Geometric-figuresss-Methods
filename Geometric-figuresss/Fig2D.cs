using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figuresss
{
    internal class Fig2D: Figure 
    {
		//Properties
		protected double length_side;

		public double  Length_side
		{
			get { return length_side; }
			set { length_side = value; }
		}

		protected int number_sides;

		public int Number_sides
		{
			get { return number_sides; }
			set { number_sides = value; }
		}

		//Constructor 
		public Fig2D() 
		{
			length_side = 0;
			number_sides = 0;	
		}

	 
		//Method Con parametros de entrada y de salida 
		public double  Getperimeter (double length_side, int number_sides)
		{
			 return  length_side*number_sides;
		}
	}
}
