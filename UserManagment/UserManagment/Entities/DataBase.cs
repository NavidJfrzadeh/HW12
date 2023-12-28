using Newtonsoft.Json;
using UserManagment.Utilities;

namespace UserManagment.Entities
{
    public static class DataBase
    {
        public static List<Member> memberList = new List<Member>();
        public static Manager manager;

        static DataBase()
        {
            manager = new Manager() { Id = "1", FirstName = "Navid", LastName = "Jafarzadeh", Email = "navid@gmail.com", Number = "1234" };
        }

        public static List<Member> LoadMembers(string path)
        {
            var file = File.ReadAllText(path);
            var members = JsonConvert.DeserializeObject<List<Member>>(file);
            return members;
        }
    }
}
