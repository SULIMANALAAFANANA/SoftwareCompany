namespace SoftwareCompany.Controllers
{
    internal class CategoryModel
    {
        public CategoryModel()
        {
        }

        public object Id { get; set; }
        public object Name { get; set; }
        public object Image { get; set; }
        public int Price { get; set; }
        public object Title { get; internal set; }
        public object TitleEn { get; internal set; }
        public object CategoryId { get; internal set; }
        public object Categories { get; internal set; }
    }
}