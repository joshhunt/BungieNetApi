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
    /// Defines a single subscription: permission to send emails for a specific, focused subject (generally timeboxed, such as for a specific release of a product or feature).
    /// </summary>
    [DataContract]
    public partial class UserEmailSubscriptionDefinition :  IEquatable<UserEmailSubscriptionDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEmailSubscriptionDefinition" /> class.
        /// </summary>
        /// <param name="name">The unique identifier for this subscription..</param>
        /// <param name="localization">A dictionary of localized text for the EMail Opt-in setting, keyed by the locale..</param>
        /// <param name="value">The bitflag value for this subscription. Should be a unique power of two value..</param>
        public UserEmailSubscriptionDefinition(string name = default(string), Dictionary<string, UserEMailSettingSubscriptionLocalization> localization = default(Dictionary<string, UserEMailSettingSubscriptionLocalization>), long value = default(long))
        {
            this.Name = name;
            this.Localization = localization;
            this.Value = value;
        }
        
        /// <summary>
        /// The unique identifier for this subscription.
        /// </summary>
        /// <value>The unique identifier for this subscription.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.
        /// </summary>
        /// <value>A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.</value>
        [DataMember(Name="localization", EmitDefaultValue=false)]
        public Dictionary<string, UserEMailSettingSubscriptionLocalization> Localization { get; set; }

        /// <summary>
        /// The bitflag value for this subscription. Should be a unique power of two value.
        /// </summary>
        /// <value>The bitflag value for this subscription. Should be a unique power of two value.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserEmailSubscriptionDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Localization: ").Append(Localization).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as UserEmailSubscriptionDefinition);
        }

        /// <summary>
        /// Returns true if UserEmailSubscriptionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of UserEmailSubscriptionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEmailSubscriptionDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Localization == input.Localization ||
                    this.Localization != null &&
                    input.Localization != null &&
                    this.Localization.SequenceEqual(input.Localization)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Localization != null)
                    hashCode = hashCode * 59 + this.Localization.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
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
