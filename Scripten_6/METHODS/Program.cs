using System;

namespace METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASSIGNMENT : METHODS

            #region Assignment 01
            // 01. Create a method which accepts height and base (width) of a triangle as parameters,
            //     with that calculates and returns the area the triangle.
            //     The formula to calculate the area of a trinagle is:
            //     Area = 0.5 * (base * height)

            Console.WriteLine("----------------");
            Console.WriteLine("Assignent 01");
            Console.WriteLine("----------------");
            Console.WriteLine("The surface area of a triangle with h=3 and b=5 is : {0}", calculateAreaTriangle(3, 5));

            double calculateAreaTriangle(double h, double b)
            {
                return 0.5 * (b * h);
            }

            #endregion

            Console.WriteLine();

            #region Assignment 02
            // 02. Rewrite the ArrowDamageCalculator in such a way that damage is also provided as a parameter

            Console.WriteLine("----------------");
            Console.WriteLine("Assignent 02");
            Console.WriteLine("----------------");
            Console.WriteLine("Damage with distance=70 and damage=50 is : {0}", ArrowDamageCalculator(70, 50));

            int ArrowDamageCalculator(int distance, int damage)
            {
                if (distance > 50 && distance < 100)
                {
                    // damage = damage;
                }

                if (distance < 50)
                {
                    damage = damage * 2;
                }

                if (distance > 100)
                {
                    damage = damage / 2;
                }

                return damage;
            }

            #endregion

            Console.WriteLine();

            #region Assignment 03
            // 03. Rewrite the ArrowDamageCalculator again implementing the following:
            //       - The method has the following parameters [pull] and [distance].
            //       - When [pull = 10] and [distance = 10], [damage = 50].
            //       - When [pull = 50] and [distance = 10], [damage = 250].
            //       - when [pull = 9000] and [distance = 1], [damage = 4500].
            //       - Do not use IF statements, but try to figure out the formula
            //         and use it in the method to calculate the damage.

            Console.WriteLine("----------------");
            Console.WriteLine("Assignent 03");
            Console.WriteLine("----------------");
            Console.WriteLine("Damage for pull=10 and distance=10 is : {0}", FancyArrowDamageCalculator(10, 10));
            Console.WriteLine("Damage for pull=50 and distance=10 is : {0}", FancyArrowDamageCalculator(50, 10));
            Console.WriteLine("Damage for pull=9000 and distance=1 is : {0}", FancyArrowDamageCalculator(9000, 1));

            int FancyArrowDamageCalculator(int pull, int distance)
            {
                return pull / 2 * distance;
            }


            #endregion

            Console.WriteLine();

            #region Assignment 04
            // 04. Create a method called TargetHit() and add the following:
            //       - Input parameters are damage and distance.
            //       - The target is destroyed when damage > distance to the target.
            //       - Return True when the target is destroyed.
            //       - Return False when the target is destroyed.

            Console.WriteLine("----------------");
            Console.WriteLine("Assignent 04");
            Console.WriteLine("----------------");
            Console.WriteLine("Damage=10, Distance=10, Destroyed is : {0}", TargetHit(10, 10));
            Console.WriteLine("Damage=10, Distance=25, Destroyed is : {0}", TargetHit(10, 25));
            Console.WriteLine("Damage=25, Distance=10, Destroyed is : {0}", TargetHit(25, 10));

            bool TargetHit(int damage, int distance)
            {
                bool destroyed = false;

                if (damage > distance)
                {
                    destroyed = true;
                }

                return destroyed;
            }


            #endregion

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
