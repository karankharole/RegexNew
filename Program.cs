namespace RegexNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserForm user = new UserForm();
            user.UserInputName();
            user.Email();
            user.MobileNumber();
            user.PassWord();
        }
    }
}