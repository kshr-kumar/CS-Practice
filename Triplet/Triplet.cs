using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		
		int Triples = int.Parse(Console.ReadLine());
		for (int i=0; i<Triples; i++)
		{
		    
		    string[] inputs = Console.ReadLine().Split(' ');
		    
		    // Convert the array of strings to an array of integers
            int[] triplet = Array.ConvertAll(inputs, int.Parse);
		    
		    Array.Sort(triplet);
		    
		    int SecondTriplet = triplet[1];
		    Console.WriteLine(SecondTriplet);
		    
		}
	}
}
