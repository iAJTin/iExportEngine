
namespace iTin.Export
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Static class than contains extension methods for generic enumerable objects.
    /// </summary> 
    public static class LinqExtensions
    {
        /// <summary>
        /// Gets the duplicates.
        /// </summary>
        /// <typeparam name="T">Type of element</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        /// Item duplicates list.
        /// </returns>
        public static IEnumerable<T> GetDuplicates<T>(this IEnumerable<T> source)
        {
            var itemsSeen = new HashSet<T>();
            var itemsYielded = new HashSet<T>();

            foreach (var item in source)
            {
                if (!itemsSeen.Add(item))
                {
                    if (itemsYielded.Add(item))
                    {
                        yield return item;
                    }
                }
            }
        }

        /// <summary>
        /// Determines whether this instance has duplicates.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool HasDuplicates<T>(this IEnumerable<T> source)
        {
            var duplicates = source.GetDuplicates();
            return duplicates.Any();
        }

        /// <summary>
        /// Executes a function if a given predicate is <c>true</c>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val">The value.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="func">The function to execute.</param>
        /// <returns>
        /// </returns>
        public static T If<T>(this T val, Func<T, bool> predicate, Func<T, T> func)
        {
            return predicate(val)
                ? func(val)
                : val;
        }

        /// <summary>
        /// Determines weather values are into list.
        /// </summary>
        /// <typeparam name="T">Type of list elements</typeparam>
        /// <param name="source">Target array.</param>
        /// <param name="values">Values to check.</param>
        /// <returns>
        /// <c>true</c> if values are into list; Otherwise, <c>false</c>.
        /// </returns>
        public static bool In<T>(this T source, params T[] values)
        {
            return values.ToList().Contains(source);
        }

        /// <summary>
        /// Determines weather values are into list.
        /// </summary>
        /// <typeparam name="T">Type of list elements</typeparam>
        /// <param name="source">Target list.</param>
        /// <param name="values">Values to check.</param>
        /// <returns>
        /// <c>true</c> if values are into list; Otherwise, <c>false</c>.
        /// </returns>
        public static bool In<T>(this T source, IEnumerable<T> values)
        {
            return source.In(values.ToArray());
        }


        /// <summary>
        /// Converts an enumeration of groupings into a Dictionary of those groupings.
        /// </summary>
        /// <typeparam name="TKey">Key type of the grouping and dictionary.</typeparam>
        /// <typeparam name="TValue">Element type of the grouping and dictionary list.</typeparam>
        /// <param name="groupings">The enumeration of groupings from a GroupBy() clause.</param>
        /// <returns>A dictionary of groupings such that the key of the dictionary is TKey type and the value is List of TValue type.</returns>
        public static Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(this IEnumerable<IGrouping<TKey, TValue>> groupings)
        {
            return groupings.ToDictionary(group => group.Key, group => group.ToList());
        }

        /// <summary>
        /// Pivots the specified first key selector.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TFirstKey">The type of the first key.</typeparam>
        /// <typeparam name="TSecondKey">The type of the second key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="firstKeySelector">The first key selector.</param>
        /// <param name="secondKeySelector">The second key selector.</param>
        /// <param name="aggregate">The aggregate.</param>
        /// <returns>
        /// A new dictionary with data transformation.
        /// </returns>
        public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TFirstKey> firstKeySelector, Func<TSource, TSecondKey> secondKeySelector, Func<IEnumerable<TSource>, TValue> aggregate)
        {
            var retVal = new Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>();

            var l = source.ToLookup(firstKeySelector);
            foreach (var item in l)
            {
                var dict = new Dictionary<TSecondKey, TValue>();
                retVal.Add(item.Key, dict);
                var subdict = item.ToLookup(secondKeySelector);
                foreach (var subitem in subdict)
                {
                    dict.Add(subitem.Key, aggregate(subitem));
                }
            }

            return retVal;
        }

        /// <summary>
        /// Creates a new datatable from an <see cref="T:System.Collections.IEnumerable" />.
        /// </summary>
        /// <param name="items">Target items.</param>
        /// <param name="name">Table name.</param>
        /// <returns>
        /// <see cref="T:System.Data.DataTable" /> which contains the specified rows.
        /// </returns>
        public static DataTable ToDataTable<T>(this IEnumerable items, string name)
        {
            var table = new DataTable(name);
            var properties = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            var list = items.Cast<T>();
            foreach (var item in list)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }
    }
}
