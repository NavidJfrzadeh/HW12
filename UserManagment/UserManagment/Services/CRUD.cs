using UserManagment.Entities;
using UserManagment.Utilities;

namespace UserManagment.Services
{
    public class CRUD
    {

        Serializer serialize = new Serializer();
        DataAccess dataAccess = new DataAccess(Directory.GetCurrentDirectory() + "\\members.jsom");


        public List<Member> ReadAllUsers()
        {
            return DataBase.memberList;
        }
    }
}
