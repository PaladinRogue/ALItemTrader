using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ALItemTrader.Api.Responses
{
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
}