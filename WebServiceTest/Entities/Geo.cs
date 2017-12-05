using RestSharp.Deserializers;

namespace WebServiceTest.Entities
{
    public class Geo
    {
        [DeserializeAs(Name = "lat")]
        public string Lat { get; set; }

        [DeserializeAs(Name = "lng")]
        public string Lng { get; set; }
    }
}
