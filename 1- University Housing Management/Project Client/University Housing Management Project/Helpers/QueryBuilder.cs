using System;
using System.Collections.Generic;

namespace University_Housing_Management_Project.Helpers
{
    public class QueryBuilder
    {
        private readonly List<string> _parameters = new List<string>();

        public QueryBuilder Add(string key, object value)
        {
            if (value == null)
                return this;

            if (value is string str)
            {
                if (string.IsNullOrWhiteSpace(str))
                    return this;

                _parameters.Add($"{key}={Uri.EscapeDataString(str)}");
            }
            else if (value is DateTime date)
            {
                _parameters.Add($"{key}={date:yyyy-MM-dd}");
            }
            else if (value is decimal number)
            {
                _parameters.Add($"{key}={number.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
            }
            else
            {
                _parameters.Add($"{key}={Uri.EscapeDataString(value.ToString())}");
            }

            return this;
        }

        public string Build()
        {
            return _parameters.Count == 0
                ? string.Empty
                : "?" + string.Join("&", _parameters);
        }
    }
}
