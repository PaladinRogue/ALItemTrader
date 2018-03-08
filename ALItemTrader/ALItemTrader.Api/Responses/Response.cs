namespace ALItemTrader.Api.Responses
{
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
}