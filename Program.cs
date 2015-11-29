using System;
using System.Numerics;
using System.Collections.Generic;

namespace Console_13
{	class MainClass
	{	public static void Main (string[] args)
		{	BigInteger total = 0;

			for(int i = 0; i < 100; i++){
				total += BigInteger.Add (DataClass.data [i, 2], 
						 BigInteger.Add( BigInteger.Multiply(BigInteger.Pow(10, 19), (DataClass.data [i, 1])), 
				               			 BigInteger.Multiply(BigInteger.Pow(10, 38), (DataClass.data [i, 0]))
				                       ));
			}
			Console.WriteLine (total);
		}
	}
}
