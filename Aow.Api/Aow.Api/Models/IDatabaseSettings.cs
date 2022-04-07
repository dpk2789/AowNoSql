namespace Aow.WebApi.Models
{
    public interface IDatabaseSettings
    {
        string StudentCoursesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
