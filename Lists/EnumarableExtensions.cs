namespace SKitLs.Utils.Extensions.Lists
{
    /// <summary>
    /// Provides extension methods for IEnumerable and IDictionary collections.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Gets or sets the <see cref="Random"/> instance used for random operations.
        /// </summary>
        public static Random Random { get; set; } = new Random();

        /// <summary>
        /// Shuffles the elements of the specified <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the source collection.</typeparam>
        /// <param name="source">The source collection to shuffle.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> containing the shuffled elements.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the source collection is null.</exception>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            ArgumentNullException.ThrowIfNull(source);

            var mask = source.Count().ToRange();
            var result = new List<T>();
            while (source.Any())
            {
                var index = Random.Next(mask.Count);
                result.Add(source.ElementAt(index));
                mask.RemoveAt(index);
            }
            return result;
        }

        /// <summary>
        /// Determines whether two <see cref="IEnumerable{T}"/> collections are equal by comparing their elements.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the collections.</typeparam>
        /// <param name="source">The first collection to compare.</param>
        /// <param name="other">The second collection to compare.</param>
        /// <returns><see langword="true"/> if the collections are equal; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when either of the collections is null.</exception>
        public static bool SequenceEquality<T>(this IEnumerable<T> source, IEnumerable<T> other) where T : IEquatable<T>
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(other);

            return !source.Except(other).Any();
        }

        /// <summary>
        /// Determines whether two <see cref="IDictionary{TKey, TValue}"/> collections are equal by comparing their keys and values.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionaries.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionaries.</typeparam>
        /// <param name="source">The first dictionary to compare.</param>
        /// <param name="other">The second dictionary to compare.</param>
        /// <returns><see langword="true"/> if the dictionaries are equal; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when either of the dictionaries is null.</exception>
        public static bool DictionaryEquality<TKey, TValue>(this IDictionary<TKey, TValue> source, IDictionary<TKey, TValue> other) where TKey : IEquatable<TKey> where TValue : IEquatable<TValue>
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(other);

            var ok = true;
            foreach (var item in source)
            {
                if (other.TryGetValue(item.Key, out var otherValue))
                    ok &= item.Value.Equals(otherValue);
                else
                    return false;
            }
            return ok;
        }
    }
}