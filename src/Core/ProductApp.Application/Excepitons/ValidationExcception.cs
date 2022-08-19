namespace ProductApp.Application.Excepitons
{
    public class ValidationExcception : Exception
    {
        public ValidationExcception():this("Validation Ecception occured")
        {

        }
        public ValidationExcception(string message):base(message)
        {

        }
        public ValidationExcception(Exception exception):this(exception.Message)
        {

        }
    }
}
