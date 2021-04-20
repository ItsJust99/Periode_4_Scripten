using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Assignment for this week...
                https://github.com/SintPieterrrr/SD1_2020/blob/main/Scripten_6/Week_1.3_Assignments/Program.cs
 
                Upload the solution to your github or onedrive BEFORE the start of next weeks lesson for Werkhouding points.
                Handed in work also helps with test results... 
             */

            #region AND operator
            // 01. Note down the symbol of the AND operator.
                // &&

            // 02. Explain what an AND operator is and what it does.
                // The And operator is an operator that both statement need to be true 
                // It checks if the statement are true 

            // 03. Finish the Truth table for the AND operator.
            //     A     | B     | C
            //     true  | true  | true
            //     true  | false | false
            //     false | true  | false
            //     false | false | false
            #endregion

            #region OR operator
            // 04. Note down the symbol of the OR operator.
                // ||

            // 05. Explain what an OR operator is and what it does.
                // The OR operator is an operator that need just one of the statement need to be true 
                // It checks if onte of the statement are true

            // 06. Finish the Truth table for the OR operator.
            //     A     | B     | C
            //     true  | true  | true
            //     true  | false | true
            //     false | true  | true
            //     false | false | false

            #endregion

            #region NOT operator
            // 07. Note down the symbol of the NOT operator.
                // !

            // 08. Explain what an NOT operator is and what it does.
                // when placing this it before a condition it inverts the value, so true becomes false, and false becomes true

            #endregion

            #region Truth table coding
            // 09.
            // Write code that satisfies the following Truth tables
            // For the given values of A and B you need to write code that
            // calculates the correct value for C

            // You may write the code however you like.
            // Just IF statements might do the trick but... 
            // Try to use them in combination with logical operators and write clean readable code.

            bool a = true;
            bool b = true;
            bool c;

            //   a.  A     | B     | C
            //      -------|-------|------
            //       true  | true  | false
            //       true  | false | true
            //       false | true  | false
            //       false | false | true

            //   b.  A     | B     | C
            //      -------|-------|------
            //       true  | true  | true
            //       true  | false | true
            //       false | true  | false
            //       false | false | true

            //   c.  A     | B     | C
            //      -------|-------|------
            //       true  | true  | true
            //       true  | false | true
            //       false | true  | true
            //       false | false | true

            #endregion

            #region Weird car
            // 10.
            // A car has 3 booleans, 'hasFuel', 'hasElectricity' and 'canDrive'.
            // the car can only drive when it has either fuel OR electricity.
            // It can not drive on both.
            // It is a weird car...
            // Write code which assigns the correct value to 'canDrive' depending on the available fuel.

            #endregion
        }
    }
}
