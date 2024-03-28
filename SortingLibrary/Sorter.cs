using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary {
	public class Sorter<T> where T : IComparable<T> {
		public T bubbleSort(T numbers) {

			return numbers;
		}
	}
}

/*
Understanding the bubble sort
	input: unsorted array (ordered linear collection)
	output: sorted array (ordered linear collection)

[2, 4, 1, 5, 3]
[2, 1, 4, 5, 3]
[2, 1, 4, 3, 5]
[1, 2, 4, 3, 5]
[1, 2, 3, 4, 5]

Until nothing has changed
	Iterate over all elements of array except the last one
		Compare current element to next element
			if current > next
				swap


sort(array numbers)
	int numberSwapped = 0
	int currentNumber = 0
	do
		numberSwapped = 0
		for int i = 0; i < numbers.length - 1; i++
			if numbers[i] > numbers[i + 1]
				currentNumber = numbers[i]
				numbers[i] = numbers[i + 1]
				numbers[i + 1] = currentNumber
				numberSwapped++
	while numberSwapped > 0

	n + 13n^2 is actually (n^2)

bool version ::
sort(array numbers)
	bool hasChanged = false;
	int currentNumber = 0
	do
		hasChanged = false
		for int i = 0; i < numbers.length - 1; i++
			if numbers[i] > numbers[i + 1]
				swap(numbers, numbers[i], numbers[i + 1])
				hasChanged = true
	while hasChanged

swap(array, indexa, indexb) {
	placeholder = array[indexa]
	numbers[i] = numbers[i + 1]
	numbers[i + 1] = currentNumber
}

	:: is still n^2

Cases:
	Test_Sort_HappyPath -
		INPUT:			 [5, 3, 4, 1, 2]
		EXPECTED OUTPUT: [1, 2, 3, 4, 5]
		Assert.IsTrue(sort(input).SequenceEqual(expectedOutput))
	Test_Sort_NullCollection -
		INPUT: null
		[ExpectedException(typeof(NullReferenceException))]
	
	Test_Swap_HappyPath - 
		INPUT: array = [5, 3, 4, 1, 2], indexa = 3, indexb = 4
		EXPECTED OUTPUT: [5, 3, 4, 2, 1]
		Assert.IsTrue(swap(array, indexa, indexb).SequenceEqual(expectedOutput))
 */