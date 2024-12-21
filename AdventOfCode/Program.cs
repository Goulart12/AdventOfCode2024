using AdventOfCode.Day1;

//Day One
Console.WriteLine("Advent of Code - Day 1");

var totalDiff =  FirstProblem.ResolveList();
Console.WriteLine($"The sum of all distances is {totalDiff}");

var similarity = SecondProblem.SimilarityList();
Console.WriteLine($"The sum of all similarities is {similarity}");

Console.WriteLine("-------------------------------------------------------------------");

//Day two
Console.WriteLine("Advent of Code - Day 2");

var safeCode = AdventOfCode.Day2.FirstProblem.DiscoverSafeCodes();
Console.WriteLine($"There is {safeCode} safe codes");

var dampenerSafeCode = AdventOfCode.Day2.SecondProblem.DampenerSafeCodes();
Console.WriteLine($"There is {dampenerSafeCode} safe codes");

Console.WriteLine("-------------------------------------------------------------------");

var mullTotal = AdventOfCode.Day3.FirstProblem.CalculateMull();
Console.WriteLine($"The total multiplication is {mullTotal}");

var mullTotalWithConditional = AdventOfCode.Day3.SecondProblem.CalculateMullWithPermission();
Console.WriteLine($"The total multiplication is {mullTotalWithConditional}");