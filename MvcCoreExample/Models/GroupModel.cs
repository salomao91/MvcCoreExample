namespace MvcCoreExample.Models
{
    public class GroupModel
    {
        public ProfessorModel Professor { get; set; }
        public List<StudentModel> Students { get; set; }
    }
}