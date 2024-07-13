using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKitLs.Utils.Extensions.Strings
{
    public class StringExtension(string value)
    {
        public string Value { get; set; } = value ?? throw new ArgumentNullException(nameof(value));
        public StringExtension() : this(string.Empty) { }

        public override string ToString() => Value;

        public static implicit operator StringExtension(string input) => new(input);
        public static implicit operator string(StringExtension input) => input.Value;
        public static string operator *(int count, StringExtension input)
        {
            var result = string.Empty;
            for (int i = 0; i < count; i++)
                result += input.ToString();
            return result;
        }
    }
}