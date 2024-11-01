﻿namespace net.openstack.Providers.Rackspace.Objects.LoadBalancers.Response
{
    using Newtonsoft.Json;

    /// <threadsafety static="true" instance="false"/>
    /// <preliminary/>
    [JsonObject(MemberSerialization.OptIn)]
    internal class GetLoadBalancerNodeResponse
    {
#pragma warning disable 649 // Field 'fieldName' is never assigned to, and will always have its default value
        [JsonProperty("node")]
        private Node _node;
#pragma warning restore 649

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoadBalancerNodeResponse"/> class
        /// during JSON deserialization.
        /// </summary>
        [JsonConstructor]
        protected GetLoadBalancerNodeResponse()
        {
        }

        public Node Node
        {
            get
            {
                return _node;
            }
        }
    }
}
