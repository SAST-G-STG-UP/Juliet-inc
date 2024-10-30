// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Runtime.Serialization;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type ItemCopyRequestBody.
    /// </summary>
    [DataContract]
    public partial class ItemCopyRequestBody
    {
    
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets ParentReference.
        /// </summary>
        [DataMember(Name = "parentReference", EmitDefaultValue = false, IsRequired = false)]
        public ItemReference ParentReference { get; set; }
    
    }
}
