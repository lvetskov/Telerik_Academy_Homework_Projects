﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    //Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

    public static class IEnumerableTExtension
    {
        private static decimal Sum<T>(this IEnumerable<T> enumeration)
            where T : struct
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the sum of an empty enumeration!");
            }
            decimal sum = 0;
            try
            {
                foreach (var element in enumeration)
                {
                    sum += Convert.ToDecimal(element);
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("The sum is bigger than Maximal Decimal number!");
            }
            catch (FormatException)
            {
                throw new FormatException("The element cannot be converted to Decimal number!");
            }
            return sum;
        }
        public static decimal Product<T>(this IEnumerable<T> enumeration)
            where T : struct
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the product of an empty enumeration!");
            }
            decimal product = 1;
            try
            {
                foreach (var element in enumeration)
                {
                    product *= Convert.ToDecimal(element);
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("The product is bigger than Maximal Decimal number!");
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> enumeration)
            where T : IComparable<T>
        {
            if (enumeration.ToList().Count == 0)
            {
                throw new ArgumentException("Cannot find the Minimal element of an empty enumeration!");
            }

            //Assign the first element to be the minimal one
            T minimal = enumeration.ToList()[0];
            foreach (var element in enumeration)
            {
                if (minimal.CompareTo(element) > 0)
                {
                    minimal = element;
                }
            }
            return minimal;
        }
    }
}