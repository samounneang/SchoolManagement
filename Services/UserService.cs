using SchoolManagement.Helper;
using SchoolManagement.Models;
using SchoolManagement.Repositories;


namespace SchoolManagement.Services
{
    public class UserService
    {
        public static void AddUser()
        {
            try
            {

            }
            catch
            {

            }
            finally { 
            
            }
        }

        public static List<User> GetAllUser()
        {
            try
            {
                return UserRepository.GetAllUsers();
            }
            catch(Exception ex) {
                Filelog.LogError(ex.Message.ToString());
                return null;
            }
            finally {
                Filelog.LogMessage($"Get all User -- {DateTime.Now} ");
            }     
        }
    }
}
