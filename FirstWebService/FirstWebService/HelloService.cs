namespace FirstWebService
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using ServiceStack.CacheAccess;
    using ServiceStack.Common.Web;
    using ServiceStack.ServiceHost;
    using ServiceStack.ServiceInterface;

    public class HelloService : ServiceBase<Hello>
    {
        public ICacheClient CacheClient { get; set; }

        protected override object Run(Hello request)
        {
            var cacheKey = "bla";

            var expireInTimespan = new TimeSpan(0, 0, 30);

            return RequestContext.ToOptimizedResultUsingCache(this.CacheClient, cacheKey, expireInTimespan, () =>
                {
                    IList<ServiceItemObject> numbers = new List<ServiceItemObject>();
                    numbers.Add(new ServiceItemObject());
                    numbers.Add(new ServiceItemObject());
                    numbers.Add(new ServiceItemObject());

                    HelloResponse response = new HelloResponse { Result = numbers };

                    return response;
                    //return new HttpResult(response, HttpStatusCode.OK);
                    //return new HttpResult(response)
                    //    {
                    //        Headers =
                    //            {
                    //                { "SomethingKey1", "SomethingValue1" }, 
                    //                { "SomethingKey2", "SomethingValue2" }
                    //            },
                    //    };
                });
        }
    }
}
