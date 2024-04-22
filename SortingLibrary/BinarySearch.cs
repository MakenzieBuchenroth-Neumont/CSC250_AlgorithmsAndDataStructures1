using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary {
	public class BinarySearch<T> where T : IComparable<T> {
		// log(n)

		// if range is 1, if not the number, end and give -1
		public static int binarySearch(int searchValue, int[] list, int rangeStart, int rangeEnd) {
			int range = rangeEnd - rangeStart;
			if (range == 0) {
				return -1;
			}
			int middleValueIndex = rangeEnd - (rangeEnd - rangeStart) / 2;
			int middleValue = list[middleValueIndex];
			if (middleValue == searchValue) {
				return middleValueIndex;
			}
			else if (middleValue > searchValue) {
				int newRangeEnd = middleValueIndex - 1;
				return binarySearch(searchValue, list, rangeStart, newRangeEnd);
			}
			else {
				int newRangeStart = middleValueIndex + 1;
				return binarySearch(searchValue, list, newRangeStart, rangeEnd);
			}
		}
	}
}