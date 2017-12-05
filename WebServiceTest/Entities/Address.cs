using RestSharp.Deserializers;

namespace WebServiceTest.Entities
{
    public class Address
    {
        [DeserializeAs(Name = "street")]
        public string Street { get; set; }

        [DeserializeAs(Name = "suite")]
        public string Suite { get; set; }

        [DeserializeAs(Name = "city")]
        public string City { get; set; }

        [DeserializeAs(Name = "zipcode")]
        public string Zipcode { get; set; }

        [DeserializeAs(Name = "geo")]
        public Geo Geo { get; set; }
    }
}
