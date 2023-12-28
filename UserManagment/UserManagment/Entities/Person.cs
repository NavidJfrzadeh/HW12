namespace UserManagment.Entities
{
    public abstract class Person
    {
        public string Password {  get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string? Address { get; set; }
        public string gender { get; set; }


        //public bool SetPassword(string Password, out string Message)
        //{
        //    passwprd = Password;
        //    Message = "your password has been set";
        //    return true;
        //}
    }
}
