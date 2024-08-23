using System;
using System.Diagnostics;
namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            // Original test cases (these should pass)
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            // New test cases designed to fail
            Debug.Assert(Size(38) == "M"); // This should fail, as the original code does not handle cms == 38 correctly
            Debug.Assert(Size(-1) == "Invalid"); // This should fail, as the code doesn't handle negative values
            Debug.Assert(Size(0) == "Invalid"); // This should fail, as the code doesn't handle zero
            Debug.Assert(Size(39) == "L"); // This should fail if expecting "L", but should pass for "M"
            Debug.Assert(Size(int.MaxValue) == "Invalid"); // This should fail, as the code doesn't handle extremely large values
            Console.WriteLine("All tests executed (some should have failed).");
        }
    }
}
has context menu
