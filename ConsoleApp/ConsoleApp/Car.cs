using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public abstract class Car
	{
		public abstract string ModelOfCar();

		public virtual string CarColor() {

			return "white";
		}
	}

	public class BMW :Car {

		public override string ModelOfCar()
		{
			return "2010"; 
		}

		public override string CarColor()
		{

			return "red";
		}
	}
}
