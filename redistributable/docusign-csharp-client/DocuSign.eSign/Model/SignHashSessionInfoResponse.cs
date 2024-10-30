/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// SignHashSessionInfoResponse
    /// </summary>
    [DataContract]
    public partial class SignHashSessionInfoResponse :  IEquatable<SignHashSessionInfoResponse>, IValidatableObject
    {
        public SignHashSessionInfoResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignHashSessionInfoResponse" /> class.
        /// </summary>
        /// <param name="Documents">Complex element contains the details on the documents in the envelope..</param>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="Language">.</param>
        /// <param name="RedirectionUrl">.</param>
        /// <param name="RemainingSignatureRequests">.</param>
        /// <param name="Seal">Seal.</param>
        /// <param name="User">User.</param>
        public SignHashSessionInfoResponse(List<SignHashDocument> Documents = default(List<SignHashDocument>), string EnvelopeId = default(string), string Language = default(string), string RedirectionUrl = default(string), string RemainingSignatureRequests = default(string), Seal Seal = default(Seal), User User = default(User))
        {
            this.Documents = Documents;
            this.EnvelopeId = EnvelopeId;
            this.Language = Language;
            this.RedirectionUrl = RedirectionUrl;
            this.RemainingSignatureRequests = RemainingSignatureRequests;
            this.Seal = Seal;
            this.User = User;
        }
        
        /// <summary>
        /// Complex element contains the details on the documents in the envelope.
        /// </summary>
        /// <value>Complex element contains the details on the documents in the envelope.</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<SignHashDocument> Documents { get; set; }
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="redirectionUrl", EmitDefaultValue=false)]
        public string RedirectionUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="remainingSignatureRequests", EmitDefaultValue=false)]
        public string RemainingSignatureRequests { get; set; }
        /// <summary>
        /// Gets or Sets Seal
        /// </summary>
        [DataMember(Name="seal", EmitDefaultValue=false)]
        public Seal Seal { get; set; }
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignHashSessionInfoResponse {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  RedirectionUrl: ").Append(RedirectionUrl).Append("\n");
            sb.Append("  RemainingSignatureRequests: ").Append(RemainingSignatureRequests).Append("\n");
            sb.Append("  Seal: ").Append(Seal).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SignHashSessionInfoResponse);
        }

        /// <summary>
        /// Returns true if SignHashSessionInfoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SignHashSessionInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignHashSessionInfoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.RedirectionUrl == other.RedirectionUrl ||
                    this.RedirectionUrl != null &&
                    this.RedirectionUrl.Equals(other.RedirectionUrl)
                ) && 
                (
                    this.RemainingSignatureRequests == other.RemainingSignatureRequests ||
                    this.RemainingSignatureRequests != null &&
                    this.RemainingSignatureRequests.Equals(other.RemainingSignatureRequests)
                ) && 
                (
                    this.Seal == other.Seal ||
                    this.Seal != null &&
                    this.Seal.Equals(other.Seal)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.RedirectionUrl != null)
                    hash = hash * 59 + this.RedirectionUrl.GetHashCode();
                if (this.RemainingSignatureRequests != null)
                    hash = hash * 59 + this.RemainingSignatureRequests.GetHashCode();
                if (this.Seal != null)
                    hash = hash * 59 + this.Seal.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
