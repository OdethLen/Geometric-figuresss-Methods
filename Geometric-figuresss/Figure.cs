using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figuresss
{
	internal class Figure
	{
		//Properties 
		//Kind of figure maybe...
		protected string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}


		//Constructor 
		public Figure ()
		{
			name = "";
			color = "";
		}


		//Method Con parametros de entrada y sin parametros de salida  
		public void Presentation(string name, string color)
		{
			Console.WriteLine("Name: " + name + "\nColor: " + color);
		}

       //Method Sin parametros de entrada ni de salida 
	   public void Geometricfigure()
		{
			Console.WriteLine("\nGeometric Figure");
		}

		//public double  
    }
}
