namespace UserManagment.Entities
{
    public class Member:Person
    {
        public Member()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
