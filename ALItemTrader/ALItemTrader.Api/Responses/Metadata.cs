using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ALItemTrader.Api.Responses
{
    public class Metadata
    {
        public Metadata(dynamic data)
        {

            //TODO reflectively get links - could do this from an attribute / named property?


            PropertyMetadatas = new List<PropertyMetadata>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(data.GetType()))
            {
                List<string> constraints = new List<string>();
                if (property.Attributes.OfType<RequiredAttribute>().Any())
                {
                    constraints.Add("Required");
                }


                //TODO check for all meta attributes


                if (constraints.Any())
                {
                    PropertyMetadatas.Add(new PropertyMetadata(property.Name, constraints));
                }
            }
        }

        public IList<PropertyMetadata> PropertyMetadatas { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}