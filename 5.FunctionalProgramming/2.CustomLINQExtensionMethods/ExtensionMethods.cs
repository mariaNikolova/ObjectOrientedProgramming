using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CustomLINQExtensionMethods
{
   public static class ExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, 
                                                 Func<T, bool> predicate)
        {
            return collection.Where(x => !predicate(x));
        }
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection,int count)
        {
            StringBuilder result = new StringBuilder();
            var list = collection.ToList();
            for (int i = 0; i <count; i++)
            {
                list.AddRange(collection);
            }
            return list as IEnumerable<T>;
        }
        public static IEnumerable<string> WhereEndsWith<T>(this IEnumerable<string> collection, 
            IEnumerable<string> suffixes) 
        {
            List<string> result = new List<string>();

            foreach (var item in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        result.Add(item);
                    }
                }
           }

            return result as IEnumerable<string>;
        }
        
    }   
}
