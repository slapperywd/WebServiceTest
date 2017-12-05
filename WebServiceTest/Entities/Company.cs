using RestSharp.Deserializers;

namespace WebServiceTest.Entities
{
    public class Company
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "catchPhrase")]
        public string CatchPhrase { get; set; }

        [DeserializeAs(Name = "bs")]
        public string Bs { get; set; }
    }
}
