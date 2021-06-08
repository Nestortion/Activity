using Activity;
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
			Console.WriteLine(productList[i].ID+1 + "   " + productList[i].Condition + "   " + productList[i].Type);
		}
	}
	static void InstantiateProductList()
	{
        
        for (int i = 0; i < 3; i++)
        {
			productList.Add(new Product($"Product {i+1}"));
        }
		for (int i = 0; i < 3; i++)
		{
			productList.Add(new ClothingProduct($"Product {i + 1}"));
		}
		for (int i = 0; i < 3; i++)
		{
			productList.Add(new PowderedProduct($"Product {i + 1}"));
		}


	}

}


