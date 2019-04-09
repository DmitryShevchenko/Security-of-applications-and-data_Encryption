using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Encryption
{
    public static class Utility
    {
        public static Dictionary<T, T> MapToDirectory<T>(this List<T> key, List<T> value)
        {
            if (key == null || value == null)
                throw new ArgumentNullException();

            if (key.Count != value.Count)
                throw new ArgumentException();

            return Enumerable.Range(0, key.Count).ToDictionary(i => key[i], i => value[i]);
        }

        public static string DoubleStrings(this string sourse, int count)
        {
            var value = sourse;

            while (sourse.Length < count)
            {
                sourse += sourse;
            }

            return sourse.Substring(0, count);
        }
    }
}