using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public interface IUser
	{
		public string UserName();

	}
	public interface IUser1
	{
		public string UserName();

	}
	public class User:IUser, IUser1
	{
		public string UserName() {
			return "Prince";
		}
	}
}
