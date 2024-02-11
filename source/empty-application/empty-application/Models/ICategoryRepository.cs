namespace empty_application.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories {  get; }
    }
}
