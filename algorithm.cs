using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC250_AlgorithmsAndDataStructures1 {
	internal class algorithm {
		public static int addOne(int numberToAdd) {
			return numberToAdd++;
		}

		static void Main(string[] args) {
			int addedNumber = addOne(1);
			Console.WriteLine(addedNumber);
		}
	}
}