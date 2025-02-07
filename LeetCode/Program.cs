// See https://aka.ms/new-console-template for more information

using LeetCode;

int[] x = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
var n = RemoveDuplicatesFromSortedArray26.RemoveDuplicates(x);
Console.WriteLine(string.Join(", ", x));
Console.WriteLine($"Index: {n}");
