// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Microsoft.Graph;

using Newtonsoft.Json;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type Photo.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Photo
    {
    
        /// <summary>
        /// Gets or sets cameraMake.
        /// </summary>
        [DataMember(Name = "cameraMake", EmitDefaultValue = false, IsRequired = false)]
        public string CameraMake { get; set; }
    
        /// <summary>
        /// Gets or sets cameraModel.
        /// </summary>
        [DataMember(Name = "cameraModel", EmitDefaultValue = false, IsRequired = false)]
        public string CameraModel { get; set; }
    
        /// <summary>
        /// Gets or sets exposureDenominator.
        /// </summary>
        [DataMember(Name = "exposureDenominator", EmitDefaultValue = false, IsRequired = false)]
        public double? ExposureDenominator { get; set; }
    
        /// <summary>
        /// Gets or sets exposureNumerator.
        /// </summary>
        [DataMember(Name = "exposureNumerator", EmitDefaultValue = false, IsRequired = false)]
        public double? ExposureNumerator { get; set; }
    
        /// <summary>
        /// Gets or sets focalLength.
        /// </summary>
        [DataMember(Name = "focalLength", EmitDefaultValue = false, IsRequired = false)]
        public double? FocalLength { get; set; }
    
        /// <summary>
        /// Gets or sets fNumber.
        /// </summary>
        [DataMember(Name = "fNumber", EmitDefaultValue = false, IsRequired = false)]
        public double? FNumber { get; set; }
    
        /// <summary>
        /// Gets or sets takenDateTime.
        /// </summary>
        [DataMember(Name = "takenDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? TakenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets iso.
        /// </summary>
        [DataMember(Name = "iso", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Iso { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
