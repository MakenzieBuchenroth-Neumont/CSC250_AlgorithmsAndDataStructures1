using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary {
	public class Isomorph {
		string file = @"C:\Users\mbuchenroth\Downloads\IsomorphInput1.txt";
		public string[] readFileLineByLine(string filepath) {
			string[] fileContents = File.ReadAllLines(file);

			return fileContents;
		}

		public static string finalProduct(string[] fileContents) {
			string looseTitle = "Loose Isomorphs" + "\n";
			string loose = findLooseIsomorph(fileContents) + "\n";
			string blankLine = "\n";
			string exactTitle = "Exact Isomorphs" + "\n";
			string exact = findExactIsomorph(fileContents) + "\n";
			string nonTitle = "Non Isomorphs" + "\n";
			string non = findNonIsomorphs(fileContents) + "\n";

			string finalOutput = exactTitle + exact + blankLine + looseTitle + loose + blankLine + nonTitle + non;

			return finalOutput;
		}

		public static string findNonIsomorphs(string[] fileContents) {
			Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
			List<string> nonKeys = new List<string>();
			foreach (string word in fileContents) {
				string value = findLooseIsomorphicValue(word);
				if (keyValuePairs.ContainsKey(value)) {
					keyValuePairs[value] += ", " + word;
					nonKeys.Remove(value);
				}
				else {
					keyValuePairs.Add(value, word);
					nonKeys.Add(value);
				}

			}
			string output = "";
			foreach (var value in nonKeys) {
				output += keyValuePairs[value] + " ";
			}
			return output;
		}

		public static string findLooseIsomorph(string[] fileContents) {
			Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
			List<string> loose = new List<string>();
			foreach (string word in fileContents) {
				string value = findLooseIsomorphicValue(word);
				if (keyValuePairs.ContainsKey(value)) {
					keyValuePairs[value] += ", " + word;
					if (!loose.Contains(value)) {
						loose.Add(value);
					}
				}
				else {
					keyValuePairs.Add(value, word);
				}
			}
			string output = "";
			foreach (var value in loose) {
				output += value + ": " + keyValuePairs[value] + "\n";
			}
			return output;
		}

		public static string findExactIsomorph(string[] fileContents) {
			Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
			List<string> exact = new List<string>();
			foreach (string word in fileContents) {
				string value = findExactIsomorphicValue(word);
				if (keyValuePairs.ContainsKey(value)) {
					keyValuePairs[value] += ", " + word;
					if (!exact.Contains(value)) {
						exact.Add(value);
					}
				}
				else {
					keyValuePairs.Add(value, word);
				}
			}
			string output = "";
			foreach (var value in exact) {
				output += value + ": " + keyValuePairs[value] + "\n";
			}
			return output;
		}

		public static string findLooseIsomorphicValue(string word) {
			string looseIsomorph = "";
			Dictionary<string, int> map = new Dictionary<string, int>();
			for (int i = 0; i < word.Length; i++) {
				if (map.ContainsKey(word[i].ToString())) {
					map[word[i].ToString()]++;
				}
				else if (!map.ContainsKey(word[i].ToString())) {
					map.Add(word[i].ToString(), 1);
				}
			}
			int[] isomorph = Sorter<int>.selectionSort(map.Values.ToArray<int>());
			for (int i = 0; i < isomorph.Length; i++) {
				looseIsomorph += isomorph[i].ToString();
			}

			return looseIsomorph;
		}

		public static string findExactIsomorphicValue(string word) {
			// if in key/value pair, don't do anything
			// if it isn't add next digit

			string exactIsomorph = "";
			Dictionary<string, int> map = new Dictionary<string, int>();
			int value = 0;
			for (int i = 0; i < word.Length; i++) {
				if (!map.ContainsKey(word[i].ToString())) {
					map.Add(word[i].ToString(), value);
					value++;
				}
				exactIsomorph += map[word[i].ToString()];
			}

			return exactIsomorph;
		}
	}
}