using System.Text.RegularExpressions;

namespace MvcCoreExample.Models
{
    public class ProfessorModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int SocialNumber { get; set; }
        public AddressModel Address { get; set; }
        public string Employer { get; set; }
        public double Salary { get; set; }
        public List<GroupModel> Groups { get; set; }
        
    }
}
