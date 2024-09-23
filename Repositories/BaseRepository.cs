using System.Configuration;

namespace SchoolManagement.Repositories
{
    public class BaseRepository
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["SchoolManagement.Properties.Settings.SqlConnection"].ToString();
    }
}
