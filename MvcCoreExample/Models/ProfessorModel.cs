using System.Text.RegularExpressions;

namespace MvcCoreExample.Models
{
    public class ProfessorModel : Person
    {
        public string Employer { get; set; }
        public double Salary { get; set; }
        public List<GroupClassModel> Groups { get; set; }
        
    }
}
