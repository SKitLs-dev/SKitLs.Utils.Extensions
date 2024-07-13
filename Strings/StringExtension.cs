namespace SKitLs.Utils.Extensions.Strings
{
    /// <summary>
    /// Provides extension methods for <see cref="string"/> objects.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Repeats the specified string a given number of times.
        /// </summary>
        /// <param name="value">The string to be repeated.</param>
        /// <param name="count">The number of times to repeat the string.</param>
        /// <returns>A new <see cref="string"/> consisting of the original string repeated the specified number of times.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the string value is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the count is negative.</exception>
        public static string Multiply(this string value, int count)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count cannot be negative.");

            var result = string.Empty;
            for (int i = 0; i < count; i++)
                result += value.ToString();
            return result;
        }
        
        // TODO Fit "10", 5 => "00010"
    }
}