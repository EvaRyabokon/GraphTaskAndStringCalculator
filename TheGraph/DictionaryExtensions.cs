using System;
using System.Collections.Generic;
using System.Text;

namespace TheGraph
{
    public static class DictionaryExtensions
    {
        public static T2 GetValueOrDefault<T1, T2>(this Dictionary<T1, T2> dict, T1 key)
        {
            T2 foundValue;
            if (dict.TryGetValue(key, out foundValue))
            {
                return foundValue;
            }

            return default(T2);
        }
    }
}
