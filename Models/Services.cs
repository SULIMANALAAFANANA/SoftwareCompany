namespace SoftwareCompany.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; internal set; }
        public object Categories { get; internal set; }
    }
}
