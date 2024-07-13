namespace SKitLs.Utils.Extensions.Strings
{
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{string}"/> collections.
    /// </summary>
    public static class StringListsExtensions
    {
        /// <summary>
        /// Trims whitespace from each string in the specified <see cref="IEnumerable{string}"/> collection.
        /// </summary>
        /// <param name="list">The collection of strings to trim.</param>
        /// <returns>A new <see cref="IEnumerable{string}"/> containing the trimmed strings.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the list is null.</exception>
        public static IEnumerable<string> TrimAll(this IEnumerable<string> list)
        {
            ArgumentNullException.ThrowIfNull(list);

            var result = new List<string>();
            var i = 0;
            foreach (var item in list)
            {
                result[i] = item.Trim();
                i++;
            }
            return list;
        }
    }
}