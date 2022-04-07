namespace Aow.WebApi.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string StudentCoursesCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
