namespace FirstWebService
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using ServiceStack.ServiceInterface.ServiceModel;

    [DataContract]
    public class HelloResponse
    {
        [DataMember(Name = "numbers")]
        public IList<ServiceItemObject> Result { get; set; }

        public ResponseStatus ResponseStatus { get; set; } //Automatic exception handling
    }

    [DataContract]
    public class ServiceItemObject
    {
        private static Random randomizer;

        static ServiceItemObject()
        {
            randomizer = new Random();
        }

        public ServiceItemObject()
        {
            ItemName = randomizer.Next(100);
        }

        [DataMember(Name = "number")]
        public int ItemName { get; private set; }
    }
}
