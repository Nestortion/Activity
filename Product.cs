using System;
using System.Collections.Generic;
using System.Text;

namespace Activity
{
	public class Product
	{
		public Random rand = new Random();
		private string _name;
		private string _condition;
		private int _id;
		private static int _idCounter = 0;
		private string _type;


		public string Type
		{
			get => _type;
			set => _type = value;
		}
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		public string Condition
		{
			get => _condition;
			set => _condition = value;
		}
		public int ID
		{
			get => _id;
			set => _id = value;
		}

		public int IDCounter
        {
			get => _idCounter;
			set => _idCounter = value;
		}

		public Product(string name)
		{
			int x = rand.Next(2);
			ID = IDCounter;
			Name = name;
			Condition = (x == 0) ? "Good" : "Bad";
			IDCounter++;
			Type = "non";
		}

		

	}
}
