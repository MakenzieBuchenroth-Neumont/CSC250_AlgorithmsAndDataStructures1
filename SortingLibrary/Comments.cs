using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestProject {
	internal class Comments {
	}
}

#region Binary Search
/*
  Binary Search

Searches between two ranges to find the midpoint. If its less than, it takes the lower half, if its greater it takes the upper half and continues until it finds the searched value.
	
	Input
		value we are searching for
		sorted list of values
	Output
		location of the value we're looking for (if found)

look at the middle value and compare to search value
	if same as the search value
		return the location
	otherwise determine whether the midpoint value is less than or greater than search value
		start again using first half or last half of values depending on comparison
		
function binarySearch(searchValue, listOfValues, rangeStart, rangeEnd) {
	middleValueIndex = rangeEnd - (rangeEnd - rangeStart) / 2
	middleValue = listOfValues[middleValueIndex]
	if (middleValue = searchValue) {
		return middleValueIndex;
	}
	else if (middleValue > searchValue) {
		newRangeEnd = middleValueIndex - 1;
		return binarySearch(searchValue, listOfValues, rangeStart, newRangeEnd)
	}
	else {
		newRangeStart = middleValueIndex + 1;
		return binarySearch(sarchValue, listOfValues, newRangeStart, rangeEnd);
		}
	}
}
 */
#endregion
#region Bubble Sort
/*
 Understanding the bubble sort
	input: unsorted array(ordered linear collection)
	output: sorted array(ordered linear collection)

[2, 4, 1, 5, 3]
[2, 1, 4, 5, 3]
[2, 1, 4, 3, 5]
[1, 2, 4, 3, 5]
[1, 2, 3, 4, 5]

Verbal Breakdown:
Until nothing has changed
	Iterate over all elements of array except the last one
		Compare current element to next element
			if current > next
				swap

Pseudo-Code:
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

	n + 13n ^ 2 is actually(n ^ 2)

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

	:: is still n ^ 2

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
Assert.IsTrue(swap(array, indexa, indexb).SequenceEqual(expectedOutput))*/
#endregion
#region Selection Sort
/*
	Verbal Breakdown:
		Iterate over the array starting at the beginning
		Select the value at that element
			Iterate over remaining elements to the right
				Compare selected with the value at that element
					If selected value is greater
						Swap selected value with the value at the current index
					Else if selected value is lesser
						Continue
			Set current element (selection index) to the selected value

	Pseudo-Code:
		for (int i = 0; i > numbers.Count(); i++)
			int selectedValue = numbers[i];
			for (int j = i + 1; j > numbers.Count(); j++)
				if (selectedValue > numbers[j])
					int placeholder = numbers[j];
					numbers[j] = selectedValue;
					selectedValue = placeholder;
				}
			numbers[i] = selectedValue;
			}
					

	Cases:
		...*/
#endregion
#region Insertion Sort
/*
	Verbal Breakdown:
		Iterate over the array starting with the second element
			Use this element as the insertion value
			Iterate over previous elements of the array right to left
				If the element to the left is greater
					Set the value of the current element to the value of the left element
				Else if te element to left is lesser
					Set the value of the current element to the insertion value
					Stop iterating
			If current index is the first element
				Set the value of the current element to the insertion value

	Pseudo-Code:
	insertionSort(int[] numbers])
		for (int i = 1; i < numbers.Count(); i++)
	int insertionValue = numbers[i];
for (int j = i - 1; j > 0; j--)
	if (numbers[j] > insertionValue)
		numbers[j + 1] = numbers[j]
					if (j == 0)
	numbers[j] = insertionValue;
else
	numbers[j + 1] = insertionValue;
break;





Cases:
...
	...

	Big - O Complexity:
n ^ 2-- nested for loops*/
#endregion
#region Isomorph
/*
LOOSE ISOMORPH DERIVATION (Algorithm)
	
gag - loose 12 | exact 010
egg - loose 12 | exact 011
bee - loose 12 | exact 011
add - loose 12 | exact 011

	calculate the loose isomorph value of a string
	loose isomorph: character frequency ordered from least to greatest
INPUT: string
OUTPUT: number representing the loose isomorphic value

	create character frequency dictionary
	iterate over string
		check dictionary for character
			if exists in dictionary,
				increment the value
			else
				add it to the dictionary with a starting value of 1
OPTION 1: [1, 4, 11]
	convert dictionary values to array
	sort the array
	concatinate sorted array values
OPTION 2: "1,4,11"
	concatinate dictionary values to string
	sort string
OPTION 3:
	iterate through dictionary
	find least value
	concatinate value to the end of the isomorph
	remove that key value form the dictionary
 */
#endregion
#region Loose Isomorph Derivation (Algorithm)
/*
LOOSE ISOMORPH DERIVATION (Algorithm)
	
gag - loose 12 | exact 010
egg - loose 12 | exact 011
bee - loose 12 | exact 011
add - loose 12 | exact 011




	calculate the loose isomorph value of a string
	loose isomorph: character frequency ordered from least to greatest
INPUT: string
OUTPUT: number representing the loose isomorphic value

	create character frequency dictionary
	iterate over string
		check dictionary for character
			if exists in dictionary,
				increment the value
			else
				add it to the dictionary with a starting value of 1
OPTION 1: [1, 4, 11]
convert dictionary values to array
	sort the array
	concatinate sorted array values
OPTION 2: "1,4,11"
	concatinate dictionary values to string
	sort string
OPTION 3:
	iterate through dictionary
	find least value
	concatinate value to the end of the isomorph
	remove that key value form the dictionary*/
#endregion
#region Merge Sort
/*
big - o: O(nlog(n))

INPUT: unsorted set of data(data must be comparable)
OUTPUT: sorted set of data

	if size of data is more than one
		split data set in half
			merge sort each half
			merge the halves (n)
				~sorted~
	otherwise data is sorted (one value is sorted)
	~sorted~

merge - n

INPUT: two sets of sorted data
OUTPUT: one sorted set of data

	compare both sets of data
		starting from the beginning of both
			compare the first element of each
				insert the lower value into the next available spot of the larger set
			compare next element from the lower value set with the current greater value element
				insert the lower value into the next available spot of the larger set
					continue until all elements from one of the smaller sets are inserted into the larger set
						insert remaining elements from


Pseudo-Code:

	function splitArray() {
	if (size of data > 1) {
		int middleIndex = data.length % 2
			int[] firstHalf = new int[]
			int[] secondHalf = new int[]
			for (int i = 0; i >= middleIndex; i++) {
			firstHalf[i] = data[i]
			}
		for (int j = data.length; j <= data.length; j--) {
			secondHalf[j] = data[j]
			}
		secondHalf.reverse()
		}
		else {
		mergeSort(firstHalf, secondHalf)
			return
		}
}

function mergeSort(array firstHalf, array secondHalf) {
	int[] sortedArray = new int[]
		currentIndex = 0;
	int e;
	int j;
	for (int i = 0; i > firstHalf.length + secondhalf.length; i++) {
		if (e > j) {
			sortedArray[i] = j
					j++
					if (j > firstHalf.length) {
				for (e < secondHalf.length; e++) {
					i++
							sortedArray[i] = e;
				}
				break;
			}
		}
		else if (j > e) {
			sortedArray[i] = e
					e++
					for (j < fistHalf.length; j++) {
				i++
							sortedArray[i] = j;
			}
			break;
		}
	}
}
firstHalf + secondHalf
	}

 */
#endregion
#region Quick Sort (original)
/*
big - o: On(log(n)

INPUT: collection of data
OUTPUT: sorted collection of data

	choose a good pivot
		look for any smaller values to the right of the pivot
			move smaller values to the left of the pivot
		look for any larger values to the left of the pivot
			move larger values to the right
		quicksort left partition
		quicksort right partition


	function quicksort() {
		findPivot()
		for () {
			if (value < pivot) {
			}
		}
	}

FINDING A PIVOT

INPUT: collection of data
OUTPUT: index of value close enough to the middle

		get the index of the middle element
		compare with first index
			if middle value is smaller than the first
				swap
		compare with last index
			if middle value is larger than the last
				swap
		return middle index

 */
#endregion
#region Maze Solver
/*

BIG-O:
	worst case: length x width
	best case: length

INPUT: A maze (2d array of characters 0 - path, 1 - wall), Coords of start and end
OUTPUT: Maze solution (any solution, array of coords leading from start to end)
	
Starting from the start

MAKE NEXT MOVE
		try to turn right
			if can, go right (MAKE NEXT MOVE RIGHT)
				if solution found, we're done!
		try to go straight
			if can, go straight (MAKE NEXT MOVE STRAIGHT)
				if solution found, we're done!
		try to turn left
			if can, go left (MAKE NEXT MOVE LEFT)
				if solution found, we're done!
				
PSEUDO-CODE

move(currentPosition, previousPosition)
	solution is []
	if currentPosition is the end
		return true
	north = getNorth()
	if validateMove(north)
		solution = move(north)
	if no solution and validateMove(west)
		solution = move(west)
	if no solution and validateMove(south)
		solution = move(south)
	if no solution and validateMove(east)
		solution = move(east)
	if solution has length
		add current position to beginning of the solution
	return solution

solution is valid if array of coordinates has length > 0

validateMove(position, previousPosition)
	if position is same as previousPosition
		not valid
	otherwise return if position is a wall

getNorth(currentPosition)
	increment y coordinate by 1

getWest(currentPosition)
	decrement x coordinate by 1

getEast(currentPosition)
	increment x coordinate by 1

getSouth(currentPosition)
	decrement y coordinate by 1

UNIT TESTS:

[TestMethod]
public void testMaze_HappyPath() {
	int[] input = { example };
	int[] expectedOutput = { example };

	int[] output = Maze<int>.maze(input);

	Assert.IsTrue(output.SequenceEqual(expectedOutput));
}

[ExpectedException(typeof(NullReferenceException))]
[TestMethod]
public void testMaze_Null() {
	int[] input = null;
	
	Maze<int>.maze(input);
}
 */
#endregion
#region Quick Sort (Simplified)
/*
 QUICKSORT (SIMPLIFIED)

INPUT: collection of data
OUTPUT: sorted collection of data

	Find the pivot
	Move all values less than the pivot to the left of the pivot
	Move all values greater than the pivot to the right of the pivot
	Quicksort the left
	Quicksort the right
	
Pseudo-Code:

	choosePivot(data) { // average of three
		//find the middle element
		middleElement = element of data length / 2
		firstElement = element at the beginning of data
		lastElement = element at the end of the data
		maxValue = getMax(middle, first, last)
		assign last element to maxValue
		minValue = getMin(remainingValue)
		assign first element to minValue
		assign middle element to remaining value
		return middle value index
	}

	quickSort(data, partitionStart, partiotionEnd) {
		pivot = choosePivot(data, partitionStart, partitionend)
		pivotIndex = partition(data, pivot)
		quickSort(data, partitionStart, pivotIndex - 1)
		quickSort(data, pivotIndex + 1, partitionEnd)
	}

	partition(data, pivot) {
	currentRightElement = end of data
		for each element before the pivot {
			swapMade  = false
			if elementLeft is greater than pivot value {
				for (i = data.length; i > pivot; i--) {
					if elementRight is less than pivot {
						swap(elementLeft, elementRight)
						swapMade = true
						currentRightElement = element just left of current element
						break
					}
				}
				if no swapMade {
					swap pivot with elementLeft
					swapMade = true
					break
				}
			}
			if no swapMade {
				swap(elementRight, pivot, data)
			}
		}
	return pivotIndex;
	}
*/
#endregion