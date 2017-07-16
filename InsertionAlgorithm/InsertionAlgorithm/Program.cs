using System;
using System.Text;


namespace TestApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = { 5, 2, 13, 4, 6, 1, 10, 21, 3, 7, 12, 9, 8, 1, 4, 7};
			StringBuilder sb = new StringBuilder();
			Aconsolewriter(A, sb);

			/*-------------------Algorithm-------------------------------*/
			/* 'A' is our Array to be sorted
			 * 'j' is the current index we are at in the loop where the value is stored and held in the 'key'. 
			 * 'i' is our previous index that is tested against. 
			 * i decreases till 0 (-1 since index 0 is valid) or less than j value (key)
			 * i value keeps swapping places with i+1 value before decrement until i gets towards start 
			 * of array or till lower than key value.
			 * j value (key) gets assigned to index of i once A[i] > key where i+1 is correct index since 
			 * the latest decrement ended the while loop - satisfying conditions */

			for (int i = 0, j = 1; j < A.Length; j++) {
				int key = A[j];
				i = j - 1;
				while (i >= 0 && A[i] > key) {
					A[i + 1] = A[i];
					i -= 1;
				}
				A[i + 1] = key;

				//Display text
				Aconsolewriter(A, sb, j);
			}
			/*-------------------End Algorithm-------------------------------*/
			Console.ReadLine();
		}

		public static void Aconsolewriter(int[] B, StringBuilder SB, int currentindex = 0) {
			for (int x = 0; x < (B.Length); x++) {
				if (currentindex > 0 && x == currentindex) {
					SB.Append("|").Append(B[x].ToString()).Append("| ");
				}
				else {
					SB.Append(B[x].ToString() + " ");
				}
			}
			SB.AppendLine();
			Console.WriteLine(SB.ToString());
			SB.Clear();
		}
	}
}
