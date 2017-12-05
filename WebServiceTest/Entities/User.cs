using RestSharp.Deserializers;

namespace WebServiceTest.Entities
{
    public class User
    {
        [DeserializeAs(Name = "id")]
        public int Id { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "username")]
        public string Username { get; set; }

        [DeserializeAs(Name = "email")]
        public string Email { get; set; }

        [DeserializeAs(Name = "address")]
        public Address Address { get; set; }

        [DeserializeAs(Name = "phone")]
        public string Phone { get; set; }

        [DeserializeAs(Name = "website")]
        public string Website { get; set; }

        [DeserializeAs(Name = "company")]
        public Company Company { get; set; }
    }
}
