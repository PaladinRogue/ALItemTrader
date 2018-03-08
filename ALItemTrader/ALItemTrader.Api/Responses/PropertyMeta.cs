using System.Collections.Generic;

namespace ALItemTrader.Api.Responses
{
    public class PropertyMeta
    {
        public PropertyMeta(string property, IEnumerable<string> constraints)
        {
            Property = property.ToCamelCase();
            Constraints = constraints;
        }

        public string Property { get; set; }
        public IEnumerable<string> Constraints { get; set; }
    }
}