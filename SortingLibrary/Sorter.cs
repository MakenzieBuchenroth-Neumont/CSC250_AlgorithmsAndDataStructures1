using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary {
	public class Sorter<T> where T : IComparable<T> {
		#region BubbleSort
		public static int[] bubbleSort(int[] numbers) {
			bool hasChanged = false;
			do {
				hasChanged = false;
				for (int i = 0; i < (numbers.Count() - 1); i++) {
					if (numbers[i] > numbers[i + 1]) {
						numbers = swapNumbers(numbers, i, i + 1);
						hasChanged = true;
					}
				}
			}
			while (hasChanged);
			return numbers;
		}

		public static int[] swapNumbers(int[] array, int indexa, int indexb) {
			int placeholder = array[indexa];
			array[indexa] = array[indexb];
			array[indexb] = placeholder;

			return array;
		}
		#endregion

		#region SelectionSort
		// big-o complexity: n^2, because two nested for loops.
		public static int[] selectionSort(int[] numbers) {
			for (int i = 0; i < numbers.Count(); i++) {
				numbers = selectionCompare(i, numbers);
			}
			return numbers;
		}

		public static int[] selectionCompare(int i, int[] numbers) {
			int selectedValue = numbers[i];
			for (int j = i + 1; j < numbers.Count(); j++) {
				if (selectedValue > numbers[j]) {
					int placeholder = numbers[j];
					numbers[j] = selectedValue;
					selectedValue = placeholder;
				}
			}
			numbers[i] = selectedValue;
			return numbers;
		}
		#endregion

		#region InsertionSort
		// big-o complexity: n^2, because of two nested for loops
		public static int[] insertionSort(int[] numbers) {
			for (int i = 1; i < numbers.Count(); i++) {
				int insertionValue = numbers[i];
				insertionCompare(numbers, insertionValue, i);
			}
			return numbers;
		}

		public static int[] insertionCompare(int[] numbers, int insertionValue, int i) {
			for (int j = i - 1; j >= 0; j--) {
				if (numbers[j] > insertionValue) {
					numbers[j + 1] = numbers[j];
					if (j == 0)
						numbers[j] = insertionValue;
				}
				else {
					numbers[j + 1] = insertionValue;
					break;
				}
			}
			return numbers;
		}
		#endregion
	}
}