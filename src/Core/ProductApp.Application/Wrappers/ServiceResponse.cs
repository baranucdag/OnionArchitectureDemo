namespace ProductApp.Application.Wrappers
{
    public class ServiceResponse<T>
    {
        public T Value { get; set; }

        public ServiceResponse()
        {

        }

        public ServiceResponse(T value)
        {
            Value = value;  
        }
    }

}
