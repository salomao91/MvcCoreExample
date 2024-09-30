namespace MvcCoreExample.Models
{
    public class GroupClassModel
    {
        public string Code { get; set; }
        public CourseModel Course { get; set; }
        public ProfessorModel Professor { get; set; }
        public List<StudentModel> Students { get; set; }
    }
}