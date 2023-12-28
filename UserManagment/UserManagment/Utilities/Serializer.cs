using Newtonsoft.Json;
using UserManagment.Entities;

namespace UserManagment.Utilities
{
    public class Serializer
    {
        public string Serialize(List<Member> Members)
        {
            return JsonConvert.SerializeObject(Members);
        }

        public Member Deserialize(string Json)
        {
            return JsonConvert.DeserializeObject<Member>(Json);
        }
    }
}