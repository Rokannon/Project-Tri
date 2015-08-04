using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.mindbox
{
    /// <summary>
    /// Class containing geometry utility functions.
    /// </summary>
    public static class GeomUtils
    {
        /// <summary>
        /// Internal constant used for contract checks.
        /// </summary>
        const double EPSILON = 1.0e-9;

        /// <summary>
        /// Calculates area of a right-angled triangle taking <code>a</code> and <code>b</code>
        /// as catheti lengths and <code>c</code> as length of it's hypotenuse.
        /// </summary>
        /// <param name="a">Length of triangle's first leg.</param>
        /// <param name="b">Length of triangle's second leg.</param>
        /// <param name="c">Length of triangle's hypotenuse.</param>
        /// <returns>Area of a triangle with specified metrics.</returns>
        public static double CalculateRightTriangleArea(double a, double b, double c)
        {
            Contract.Requires(a >= 0 && b >= 0 && c >= 0, "Specified arguments must be positive.");
            Contract.Requires(checked(Math.Abs(c * c - a * a - b * b)) < EPSILON,
                "Specified arguments does not belong to a right triangle.");
            return checked(0.5 * a * b);
        }
    }
}
