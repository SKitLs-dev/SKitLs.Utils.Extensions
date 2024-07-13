namespace SKitLs.Utils.Extensions.Strings
{
    public static class StringListsExtensions
    {
        public static IList<string> TrimAll(this IList<string> list)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] = list[i].Trim();
            return list;
        }
    }
}
