namespace SKitLs.Utils.Extensions.Lists
{
    /// <summary>
    /// Provides extension methods for IEnumerable of boolean values.
    /// </summary>
    public static class BoolListsExtensions
    {
        /// <summary>
        /// Determines whether <b>any</b> element in the sequence is <see langword="true"/>.
        /// </summary>
        /// <param name="list">The <see cref="IEnumerable{T}"/> of boolean values to check.</param>
        /// <returns><see langword="true"/> if <b>any</b> element in the sequence is <see langword="true"/>, otherwise <see langword="false"/>.</returns>
        public static bool AnyTrue(this IEnumerable<bool> list)
        {
            bool ok = false;
            foreach (var item in list)
                ok |= item;
            return ok;
        }

        /// <summary>
        /// Determines whether <b>all</b> elements in the sequence are <see langword="true"/>.
        /// </summary>
        /// <param name="list">The <see cref="IEnumerable{T}"/> of boolean values to check.</param>
        /// <returns><see langword="true"/> if <b>all</b> elements in the sequence are <see langword="true"/>, otherwise <see langword="false"/>.</returns>
        public static bool AllTrue(this IEnumerable<bool> list)
        {
            bool ok = true;
            foreach (var item in list)
                ok &= item;
            return ok;
        }

        /// <summary>
        /// Determines whether <b>any</b> element in the sequence is <see langword="false"/>.
        /// </summary>
        /// <param name="list">The <see cref="IEnumerable{T}"/> of boolean values to check.</param>
        /// <returns><see langword="true"/> if <b>any</b> element in the sequence is <see langword="false"/>, otherwise <see langword="false"/>.</returns>
        public static bool AnyFalse(this IEnumerable<bool> list) => !AllTrue(list);

        /// <summary>
        /// Determines whether <b>all</b> elements in the sequence are <see langword="false"/>.
        /// </summary>
        /// <param name="list">The <see cref="IEnumerable{T}"/> of boolean values to check.</param>
        /// <returns><see langword="true"/> if <b>all</b> elements in the sequence are <see langword="false"/>, otherwise <see langword="false"/>.</returns>
        public static bool AllFalse(this IEnumerable<bool> list) => !AnyTrue(list);
    }
}
