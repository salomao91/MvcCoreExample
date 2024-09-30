namespace MvcCoreExample.Models
{
    public class StudentModel : Person
    {
        public string University { get; set; }
        public int Semester { get; set; }
        public List<GroupClassModel> Groups { get; set; }
    }
}
