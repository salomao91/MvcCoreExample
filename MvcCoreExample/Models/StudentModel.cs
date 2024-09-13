namespace MvcCoreExample.Models
{
    public class StudentModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int SocialNumber { get; set; }
        public AddressModel Address { get; set; }
        public string University { get; set; }
        public int Semester { get; set; }
        public List<GroupModel> Groups { get; set; }
    }
}
