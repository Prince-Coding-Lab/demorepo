using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public class Message
	{
		public void SendMessage() { }

		public virtual string SendMessage1() {
			string message = "test";
			return message;
		}

		
	}
	public class Whatsaap  : Message {
		public override string SendMessage1()
		{
			string message = "message from whatsaap";
			return message;
		}
	}
	public class Facebook : Message
	{
		public override string SendMessage1()
		{
			string message = "message from facebook";
			return message;
		}
	}
}
