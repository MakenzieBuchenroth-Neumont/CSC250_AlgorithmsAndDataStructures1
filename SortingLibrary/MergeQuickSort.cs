using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary {
	public class MergeQuickSort {
		#region MergeSort
		// used ChatGPT to help debug the errors in my code:
		//prompt: "without giving me any code, can you tell me what is wrong with this method to split an array into two halves?:"
		// my original was:
		/*
		int firstHalfLength = 0;
		int secondHalfLength = 0;
		if (array.Length > 1) {
			int middleIndex = array.Length % 2;
			for (int i = middleIndex; i == 0; i--) {
				firstHalfLength++;
			}
			for (int i = middleIndex; i == array.Length; i++) {
				secondHalfLength++;
			}
		int[] firstHalf = new int[firstHalfLength];
		int[] secondHalf = new int[secondHalfLength];
		for (int i = 0; i >= middleIndex; i++) {
			firstHalf[i] = array[i];
		}
		for (int j = array.Length; j <= array.Length; j--) {
			secondHalf[j] = array[j];
		}
		secondHalf.Reverse();
		return array;
	}
	else {
		return array;
		}
	}
		*/
		public static int[][] splitArray(int[] array) {
			if (array.Length > 1) {
				int middleIndex = array.Length / 2;
				int[] firstHalf = new int[middleIndex];
				int[] secondHalf = new int[array.Length - middleIndex];

				for (int i = 0; i < firstHalf.Length; i++) {
					firstHalf[i] = array[i];
				}
				for (int j = 0; j < secondHalf.Length; j++) {
					secondHalf[j] = array[middleIndex + j];
				}

				int[][] finalArray = new int[2][];
				finalArray[0] = firstHalf;
				finalArray[1] = secondHalf;

				return finalArray;
			}
			else {
				return null;
			}
		}

		public static int[] mergeSort(int[] data) {
			if (data.Length <= 1) {
				return data;
			}
			int[][] split = splitArray(data);

			split[0] = mergeSort(split[0]);
			split[1] = mergeSort(split[1]);

			return merge(split);
		}

		public static int[] merge(int[][] split) {
			int[] finalArray = new int[split[0].Length + split[1].Length];

			int zeroIndex = 0;
			int firstIndex = 0;

			for (int i = 0; i < finalArray.Length - 1; i++) {
				if (split[0][zeroIndex] > split[1][firstIndex]) {
					finalArray[i] = split[1][firstIndex];
					firstIndex++;
					if (split[1].Length - 1 < firstIndex) {
						for (int j = zeroIndex; j < split[0].Length; j++) {
							i++;
							finalArray[i] = split[0][zeroIndex];
							zeroIndex++;
						}
					}
				}
				else {
					finalArray[i] = split[0][zeroIndex];
					zeroIndex++;
					if (split[0].Length - 1 < zeroIndex) {
						for (int j = firstIndex; j < split[1].Length; j++) {
							i++;
							finalArray[i] = split[1][firstIndex];
							firstIndex++;
						}
					}
				}
			}
			return finalArray;
		}
		#endregion

		#region QuickSort
		public static int[] choosePivot(int[] data, int start, int end) { // average of three
			int minValue = 0;
			int middleElement = data[((end - start) / 2) + start];
			int firstElement = data[start];
			int lastElement = data[end];
			int maxValue = Math.Max(middleElement, Math.Max(firstElement, lastElement));
			data[end] = maxValue;
			if (maxValue == middleElement) {
				minValue = Math.Min(firstElement, lastElement);
				maxValue = Math.Max(firstElement, lastElement);
			}
			else if (maxValue == firstElement) {
				minValue = Math.Min(middleElement, lastElement);
				maxValue = Math.Max(middleElement, lastElement);
			}
			else {
				minValue = Math.Min(firstElement, middleElement);
				maxValue = Math.Max(firstElement, middleElement);
			}
			data[start] = minValue;
			data[((end - start) / 2) + start] = maxValue;
			return data;
		}

		public static int[] quickSort(int[] data, int partitionStart, int partitionEnd) {
			if (partitionStart - partitionEnd == 0) {
				return data;
			}
			data = choosePivot(data, partitionStart, partitionEnd);
			int pivotIndex = (((partitionEnd - partitionStart) / 2) + partitionStart);
			pivotIndex = partition(data, partitionStart, partitionEnd, pivotIndex);
			data = quickSort(data, partitionStart, pivotIndex - 1);
			return quickSort(data, pivotIndex + 1, partitionEnd);
		}

		public static int partition(int[] data, int partitionStart, int partitionEnd, int pivot) {
			data = Sorter<int>.swapNumbers(data, pivot, partitionEnd);
			int leftBound = partitionStart;
			int rightBound = partitionEnd - 1;
			bool swapped = false;
			while (!swapped) {
				while (data[leftBound] < data[partitionEnd] && leftBound < rightBound) {
					leftBound++;
				}
				while (data[rightBound] > data[partitionEnd] && rightBound > leftBound) {
					rightBound--;
				}
				if (rightBound > leftBound) {
					data = Sorter<int>.swapNumbers(data, rightBound, leftBound);
				}
				else {
					swapped = true;
					data = Sorter<int>.swapNumbers(data, leftBound, partitionEnd);
				}
			}
			return leftBound;
		}
		#endregion
	}
}