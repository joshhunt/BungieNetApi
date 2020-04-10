/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// DestinyAdvancedAwaInitializeResponse
    /// </summary>
    [DataContract]
    public partial class DestinyAdvancedAwaInitializeResponse :  IEquatable<DestinyAdvancedAwaInitializeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyAdvancedAwaInitializeResponse" /> class.
        /// </summary>
        /// <param name="correlationId">ID used to get the token. Present this ID to the user as it will identify this specific request on their device..</param>
        /// <param name="sentToSelf">True if the PUSH message will only be sent to the device that made this request..</param>
        public DestinyAdvancedAwaInitializeResponse(string correlationId = default(string), bool sentToSelf = default(bool))
        {
            this.CorrelationId = correlationId;
            this.SentToSelf = sentToSelf;
        }
        
        /// <summary>
        /// ID used to get the token. Present this ID to the user as it will identify this specific request on their device.
        /// </summary>
        /// <value>ID used to get the token. Present this ID to the user as it will identify this specific request on their device.</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// True if the PUSH message will only be sent to the device that made this request.
        /// </summary>
        /// <value>True if the PUSH message will only be sent to the device that made this request.</value>
        [DataMember(Name="sentToSelf", EmitDefaultValue=false)]
        public bool SentToSelf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyAdvancedAwaInitializeResponse {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  SentToSelf: ").Append(SentToSelf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyAdvancedAwaInitializeResponse);
        }

        /// <summary>
        /// Returns true if DestinyAdvancedAwaInitializeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyAdvancedAwaInitializeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyAdvancedAwaInitializeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.SentToSelf == input.SentToSelf ||
                    this.SentToSelf.Equals(input.SentToSelf)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CorrelationId != null)
                    hashCode = hashCode * 59 + this.CorrelationId.GetHashCode();
                hashCode = hashCode * 59 + this.SentToSelf.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
