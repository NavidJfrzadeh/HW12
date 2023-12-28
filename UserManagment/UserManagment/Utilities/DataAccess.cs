using Newtonsoft.Json;
using UserManagment.Entities;

namespace UserManagment.Utilities
{
    public class DataAccess
    {
        public DataAccess(string Path)
        {
            _Path = Path;
        }


        private readonly string _Path;

        public void SaveToFile(string Data)
        {
            File.WriteAllText(_Path, Data);
        }


        public List<Member> ReadFile()
        {
            var fileData = File.ReadAllText(_Path);
            return JsonConvert.DeserializeObject<List<Member>>(fileData);
        }
    }
}