using System.Collections.Generic;

namespace ALItemTrader.Api.Responses
{
    public class PropertyMetadata
    {
        public PropertyMetadata(string property, IEnumerable<string> constraints)
        {
            Property = property;
            Constraints = constraints;
        }

        public string Property { get; set; }
        public IEnumerable<string> Constraints { get; set; }
    }
}