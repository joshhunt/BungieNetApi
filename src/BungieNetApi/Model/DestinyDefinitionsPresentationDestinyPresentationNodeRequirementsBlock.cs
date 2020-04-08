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
    /// Presentation nodes can be restricted by various requirements. This defines the rules of those requirements, and the message(s) to be shown if these requirements aren&#39;t met.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock :  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock" /> class.
        /// </summary>
        /// <param name="entitlementUnavailableMessage">If this node is not accessible due to Entitlements (for instance, you don&#39;t own the required game expansion), this is the message to show..</param>
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock(string entitlementUnavailableMessage = default(string))
        {
            this.EntitlementUnavailableMessage = entitlementUnavailableMessage;
        }
        
        /// <summary>
        /// If this node is not accessible due to Entitlements (for instance, you don&#39;t own the required game expansion), this is the message to show.
        /// </summary>
        /// <value>If this node is not accessible due to Entitlements (for instance, you don&#39;t own the required game expansion), this is the message to show.</value>
        [DataMember(Name="entitlementUnavailableMessage", EmitDefaultValue=false)]
        public string EntitlementUnavailableMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock {\n");
            sb.Append("  EntitlementUnavailableMessage: ").Append(EntitlementUnavailableMessage).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntitlementUnavailableMessage == input.EntitlementUnavailableMessage ||
                    (this.EntitlementUnavailableMessage != null &&
                    this.EntitlementUnavailableMessage.Equals(input.EntitlementUnavailableMessage))
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
                if (this.EntitlementUnavailableMessage != null)
                    hashCode = hashCode * 59 + this.EntitlementUnavailableMessage.GetHashCode();
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
