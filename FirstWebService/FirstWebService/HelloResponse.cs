namespace FirstWebService
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using ServiceStack.ServiceInterface.ServiceModel;

    [DataContract]
    public class HelloResponse
    {
        [DataMember(Name = "name")]
        public IList<ServiceItemObject> Result { get; set; }

        public ResponseStatus ResponseStatus { get; set; } //Automatic exception handling
    }
}
