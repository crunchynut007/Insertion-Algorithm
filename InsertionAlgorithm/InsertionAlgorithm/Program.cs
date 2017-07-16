using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = { 5, 2, 13, 4, 6, 1, 3, 7, 12, 9, 8 };
			StringBuilder sb = new StringBuilder();
			Aconsolewriter(A, sb);

			for (int i = 0, j = 1; j < A.Length; j++)
			{
				int key = A[j];
				i = j - 1;
				while (i >= 0 && A[i] > key)
				{
					A[i + 1] = A[i];
					i -= 1;
				}
				A[i + 1] = key;

				Aconsolewriter(A, sb);
			}
			Console.ReadLine();
		}

		public static void Aconsolewriter(int[] B, StringBuilder SB)
		{
			for (int x = 0; x < (B.Length); x++)
			{
				SB.Append(B[x].ToString() + " ");
			}
			SB.AppendLine();
			Console.WriteLine(SB.ToString());
			SB.Clear();
		}
	}
}
