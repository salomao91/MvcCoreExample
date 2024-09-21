using MvcCoreExample.Models;

namespace MvcCoreExample
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string SocialNumber { get; set; }
        public AddressModel Address { get; set; }
    }
}
