namespace SKitLs.Utils.Extensions.Lists
{
    public static class NumListsExtensions
    {
        public static List<int> ToRange(this int count, int? fill = null)
        {
            var res = new List<int>();
            for (int i = 0; i < count; i++)
                res.Add(fill is null ? i : fill.Value);
            return res;
        }

        public static List<int> SwiftNums(this List<int> list, int swift)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] += swift;
            return list;
        }

        public static int FirstAvailableValue(this IEnumerable<int> list, int minValue) => FirstAvailableValue(list, minValue);
        public static long FirstAvailableValue(this IEnumerable<long> list, long minValue = 0)
        {
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