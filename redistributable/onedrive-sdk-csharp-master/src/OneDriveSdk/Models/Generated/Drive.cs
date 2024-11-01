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
    /// The type Drive.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Drive
    {
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets drive type.
        /// </summary>
        [DataMember(Name = "driveType", EmitDefaultValue = false, IsRequired = false)]
        public string DriveType { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false, IsRequired = false)]
        public IdentitySet Owner { get; set; }
    
        /// <summary>
        /// Gets or sets quota.
        /// </summary>
        [DataMember(Name = "quota", EmitDefaultValue = false, IsRequired = false)]
        public Quota Quota { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false, IsRequired = false)]
        public IDriveItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets shared.
        /// </summary>
        [DataMember(Name = "shared", EmitDefaultValue = false, IsRequired = false)]
        public IDriveSharedCollectionPage Shared { get; set; }
    
        /// <summary>
        /// Gets or sets special.
        /// </summary>
        [DataMember(Name = "special", EmitDefaultValue = false, IsRequired = false)]
        public IDriveSpecialCollectionPage Special { get; set; }
    
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

