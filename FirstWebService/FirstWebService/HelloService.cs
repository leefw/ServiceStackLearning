namespace FirstWebService
{
    using System.Collections.Generic;

    using ServiceStack.ServiceInterface;

    public class HelloService : ServiceBase<Hello>
    {
        protected override object Run(Hello request)
        {
            IList<ServiceItemObject> names = new List<ServiceItemObject>();
            names.Add(new ServiceItemObject() { ItemName = "str1" });
            names.Add(new ServiceItemObject() { ItemName = "str2" });
            names.Add(new ServiceItemObject() { ItemName = "str3" });

            return new HelloResponse { Result = names };
        }
    }

    public class ServiceItemObject
    {
        public ServiceItemObject()
        {
        }

        public string ItemName { get; set; }
    }
}
