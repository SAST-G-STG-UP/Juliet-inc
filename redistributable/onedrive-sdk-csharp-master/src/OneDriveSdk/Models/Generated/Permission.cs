// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Serialization;

using Microsoft.Graph;

using Newtonsoft.Json;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type Permission.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Permission
    {
    
        /// <summary>
        /// Gets or sets granted to.
        /// </summary>
        [DataMember(Name = "grantedTo", EmitDefaultValue = false, IsRequired = false)]
        public IdentitySet GrantedTo { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets invitation.
        /// </summary>
        [DataMember(Name = "invitation", EmitDefaultValue = false, IsRequired = false)]
        public SharingInvitation Invitation { get; set; }
    
        /// <summary>
        /// Gets or sets inherited from.
        /// </summary>
        [DataMember(Name = "inheritedFrom", EmitDefaultValue = false, IsRequired = false)]
        public ItemReference InheritedFrom { get; set; }
    
        /// <summary>
        /// Gets or sets link.
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false, IsRequired = false)]
        public SharingLink Link { get; set; }
    
        /// <summary>
        /// Gets or sets roles.
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> Roles { get; set; }
    
        /// <summary>
        /// Gets or sets share id.
        /// </summary>
        [DataMember(Name = "shareId", EmitDefaultValue = false, IsRequired = false)]
        public string ShareId { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [DataMember(Name = "@odata.type", EmitDefaultValue = false, IsRequired = false)]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

