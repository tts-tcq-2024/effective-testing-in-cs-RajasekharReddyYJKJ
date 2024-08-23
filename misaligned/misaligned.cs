using System;
using System.Diagnostics;
namespace MisalignedSpace
{
    // Class to handle color mapping
    class ColorMap
    {
        private string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        private string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
        // Method to print the color map
        public int PrintColorMap()
        {
            int i = 0, j = 0;
            for (i = 0; i < majorColors.Length; i++)
            {
                for (j = 0; j < minorColors.Length; j++)
                {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[j]);
                }
            }
            return i * j; // Total combinations
        }
        // Method to get the count of major colors
        public int GetMajorColorsCount()
        {
            return majorColors.Length;
        }
        // Method to get the count of minor colors
        public int GetMinorColorsCount()
        {
            return minorColors.Length;
        }
    }
    // Test class for the ColorMap class
    class Program
    {
        static void Main(string[] args)
        {
            ColorMap colorMap = new ColorMap();
            int result = colorMap.PrintColorMap();
            RunTests(colorMap, result);
            Console.WriteLine("All tests completed (check for expected failures).\n");
        }
        static void RunTests(ColorMap colorMap, int result)
        {
            int failedTests = 0;
            // Test case for correct total color combinations
            failedTests += TestPrintColorMap(result, 25); // Expected successful test
            // Additional test cases
            failedTests += TestArrayLength(colorMap.GetMajorColorsCount(), 5); // Major colors count
            failedTests += TestArrayLength(colorMap.GetMinorColorsCount(), 5); // Minor colors count
            Console.WriteLine($"Total failed tests: {failedTests}");
        }
        static int TestPrintColorMap(int actual, int expected)
        {
            if (actual != expected)
            {
                Console.WriteLine($"Test failed: Expected PrintColorMap() to return {expected}, but got {actual}.");
                return 1; // Count this as a failed test
            }
            return 0; // No failure
        }
        static int TestArrayLength(int actualLength, int expectedLength)
        {
            if (actualLength != expectedLength)
            {
                Console.WriteLine($"Test failed: Expected array length to be {expectedLength}, but got {actualLength}.");
                return 1; // Count this as a failed test
            }
            return 0; // No failure
        }
    }
}
