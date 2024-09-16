using System.Text.RegularExpressions;

namespace MvcCoreExample.Models
{
    public class ProfessorModel : Person
    {
        public string Employer { get; set; }
        public double Salary { get; set; }
        public List<GroupModel> Groups { get; set; }
        
    }
}
