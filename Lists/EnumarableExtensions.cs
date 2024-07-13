namespace SKitLs.Utils.Extensions.Lists
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var random = new Random();
            var mask = source.Count().ToRange();
            var result = new List<T>();
            while (source.Any())
            {
                var index = random.Next(mask.Count);
                result.Add(source.ElementAt(index));
                mask.RemoveAt(index);
            }
            return result;
        }

        public static bool PairedEquality<T>(this IEnumerable<T> source, IEnumerable<T> other) where T : IEquatable<T> => !source.Except(other).Any();
        public static bool PairedEquality<TKey, TValue>(this IDictionary<TKey, TValue> source, IDictionary<TKey, TValue> other) where TKey : IEquatable<TKey> where TValue : IEquatable<TValue>
        {
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
