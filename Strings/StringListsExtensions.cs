namespace SKitLs.Utils.Extensions.Strings
{
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{string}"/> collections.
    /// </summary>
    public static class StringListsExtensions
    {
        /// <summary>
        /// Trims whitespace from each string in the specified <see cref="IEnumerable{T}"/> collection.
        /// </summary>
        /// <param name="list">The collection of strings to trim.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> containing the trimmed strings.</returns>
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

        /// <summary>
        /// Joins all elements of a collection of strings into a single string, with each element separated by the specified separator.
        /// </summary>
        /// <param name="list">The collection of strings to join.</param>
        /// <param name="separator">The separator to use between each element.</param>
        /// <returns>A single string that consists of the elements in the collection delimited by the separator string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="list"/> or <paramref name="separator"/> is <see langword="null"/>.</exception>
        public static string JoinAll(this IEnumerable<string> list, string separator)
        {
            ArgumentNullException.ThrowIfNull(list);
            ArgumentNullException.ThrowIfNull(separator);
            return string.Join(separator, list);
        }
    }
}