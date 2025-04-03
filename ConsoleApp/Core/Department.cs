namespace Core
{
	public class Department
	{
		//field members
		private int id;

		private string name; // field

		public string Name   // property
		{
			get { return name; }   // get method
			set { name = value; }  // set method
		}

		//properties
		public int ID { get; set; }

		//default constructors
		public Department()
		{

		}

		// parametere constructors
		public Department(int id)
		{
			this.ID = id;
		}

		//Methods
		public void Method1()
		{ 
		
		}
	}
}