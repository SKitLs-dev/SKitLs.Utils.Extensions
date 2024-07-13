namespace SKitLs.Utils.Extensions.Lists
{
    /// <summary>
    /// Provides extension methods for numeric lists.
    /// </summary>
    public static class NumListsExtensions
    {
        /// <summary>
        /// Generates a list of integers in a specified range.
        /// </summary>
        /// <param name="count">The number of elements in the range.</param>
        /// <param name="fill">Optional. The value to fill the list with. If <see langword="null"/>, the list will be filled with a sequence from <c>0</c> to <c>count-1</c>.</param>
        /// <returns>A <see cref="List{int}"/> containing the specified range of integers.</returns>
        public static List<int> ToRange(this int count, int? fill = null)
        {
            var res = new List<int>();
            for (int i = 0; i < count; i++)
                res.Add(fill is null ? i : fill.Value);
            return res;
        }

        /// <summary>
        /// Shifts each number in the list by a specified amount.
        /// </summary>
        /// <param name="list">The list of integers to shift.</param>
        /// <param name="swift">The amount to shift each number.</param>
        /// <returns>The modified <see cref="List{int}"/> with each number shifted by the specified amount.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the list is null.</exception>
        public static List<int> ShiftValues(this List<int> list, int swift)
        {
            ArgumentNullException.ThrowIfNull(list);

            for (int i = 0; i < list.Count; i++)
                list[i] += swift;
            return list;
        }

        /// <summary>
        /// Finds the first available integer value that is greater than a specified minimum value and not present in the list.
        /// </summary>
        /// <param name="list">The list of integers to check.</param>
        /// <param name="minValue">The minimum value to consider.</param>
        /// <returns>The first available integer value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the list is null.</exception>
        public static int FirstAvailableValue(this IEnumerable<int> list, int minValue = 0) => FirstAvailableValue(list, minValue);

        /// <summary>
        /// Finds the first available long value that is greater than a specified minimum value and not present in the list.
        /// </summary>
        /// <param name="list">The list of long values to check.</param>
        /// <param name="minValue">The minimum value to consider. Default is 0.</param>
        /// <returns>The first available long value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the list is null.</exception>
        public static long FirstAvailableValue(this IEnumerable<long> list, long minValue = 0)
        {
            ArgumentNullException.ThrowIfNull(list);
            if (!list.Any())
                return minValue;

            var ordered = list.Order().ToList();
            var i = 0;
            for (; i < ordered.Count; i++)
            {
                if (ordered[i] > minValue + i)
                    break;
            }
            return minValue + i;
        }
    }
}