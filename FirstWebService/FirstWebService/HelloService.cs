namespace FirstWebService
{
    using ServiceStack.ServiceInterface;

    public class HelloService : ServiceBase<Hello>
    {
        protected override object Run(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }
}
