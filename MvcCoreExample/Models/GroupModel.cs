namespace MvcCoreExample.Models
{
    public class GroupModel
    {
        public string Code { get; set; }
        public ProfessorModel Professor { get; set; }
        public List<StudentModel> Students { get; set; }
    }
}