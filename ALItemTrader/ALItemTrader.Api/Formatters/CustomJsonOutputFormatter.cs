using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;

namespace ALItemTrader.Api.Formatters
{
    public class CustomJsonOutputFormatter : JsonOutputFormatter
    {
        public CustomJsonOutputFormatter(JsonSerializerSettings serializerSettings, ArrayPool<char> charPool)
            : base(serializerSettings, charPool)
        {
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            if (context.Object == null)
            {
                await base.WriteResponseBodyAsync(context, selectedEncoding);
            }

            if (context.ObjectType.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
            {
                await WriteResponse(context, selectedEncoding, new CollectionResponse(context));
            }
            else
            {
                await WriteResponse(context, selectedEncoding, new Response(context.Object));
            }
        }

        private async Task WriteResponse(OutputFormatterWriteContext context, Encoding selectedEncoding, object response)
        {
            using (TextWriter writer = context.WriterFactory(context.HttpContext.Response.Body, selectedEncoding))
            {
                WriteObject(writer, response);

                await writer.FlushAsync();
            }

            await base.WriteResponseBodyAsync(context, selectedEncoding);
        }

        public class Response
        {
            public Response(dynamic data)
            {
                Data = data;
                Meta = new Metadata(data);
            }

            public dynamic Data { get; set; }
            public Metadata Meta { get; set; }
        }

        public class Metadata
        {
            public Metadata(dynamic data)
            {

                //TODO reflectively get links - could do this from an attribute / named property?


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

        public class Link
        {
            public string Uri { get; set; }
        }

        public class CollectionResponse
        {
            public CollectionResponse(OutputFormatterWriteContext context)
            {
                if (!(context.Object is IEnumerable<dynamic>)) return;

                foreach (dynamic data in context.Object as IEnumerable<dynamic>)
                {
                    CollectionData.Add(new Response(data));
                }

                CollectionMeta = new CollectionMetadata(context);
            }

            public IList<Response> CollectionData { get; set; }
            public CollectionMetadata CollectionMeta { get; set; }
        }

        public class CollectionMetadata
        {
            public CollectionMetadata(OutputFormatterWriteContext context)
            {
                if (context.Object is IEnumerable<dynamic> objects)
                {
                    Count = objects.Count();
                }
            }

            //TODO add paging info etc from the context
            //TODO how to create links on collection metadata?

            public int Count { get; set; }
        }

    }
}
