namespace UserManagment.Entities
{
    public class Manager:Person
    {
        public Manager()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
