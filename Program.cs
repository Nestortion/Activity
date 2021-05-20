using System;
using System.Collections.Generic;

public class Program
{
	private static List<Product> productList = new List<Product>();
	private static int goodProductCounter = 0;
	private static int badProductCounter = 0;


	public static void Main()
	{
		InstantiateProductList();
		Process();
		Summarizer();
	}
	static void Process()
	{
		for (int i = 0; i < productList.Count; i++)
		{
			if (QualityChecker.CheckQuality(productList[i]))
			{
				goodProductCounter++;
			}
			else
			{
				badProductCounter++;
			}
		}
	}
	static void Summarizer()
	{
		Console.WriteLine($"# of products with good quality: {goodProductCounter}");
		Console.WriteLine($"# of products with bad quality: {badProductCounter}");
		Console.WriteLine($"Here are the list of products and there conditions");
		for (int i = 0; i < productList.Count; i++)
		{
			Console.WriteLine(productList[i].ID+1 + "   " + productList[i].Condition);
		}
	}
	static void InstantiateProductList()
	{
        
        for (int i = 0; i < 10; i++)
        {
			productList.Add(new Product($"Product {i+1}"));
        }

	}

}

class QualityChecker
{
	public static bool CheckQuality(Product p)
	{
		if (p.Condition == "Good")
		{
			return true;
		}
		else
		{
			return false;
		}

	}
}

class Product
{
	private Random rand = new Random();
	private string _name;
	private string _condition;
	private int _id;
	private static int idCounter = 0;

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

	public Product(string name)
	{
		int x = rand.Next(2);
		ID = idCounter;
		Name = name;
		Condition = (x == 0) ? "Good" : "Not good";
		idCounter++;
	}

}