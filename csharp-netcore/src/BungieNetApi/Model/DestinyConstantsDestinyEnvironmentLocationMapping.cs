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
    /// DestinyConstantsDestinyEnvironmentLocationMapping
    /// </summary>
    [DataContract]
    public partial class DestinyConstantsDestinyEnvironmentLocationMapping :  IEquatable<DestinyConstantsDestinyEnvironmentLocationMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyConstantsDestinyEnvironmentLocationMapping" /> class.
        /// </summary>
        /// <param name="locationHash">The location that is revealed on the director by this mapping..</param>
        /// <param name="activationSource">A hint that the UI uses to figure out how this location is activated by the player..</param>
        /// <param name="itemHash">If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don&#39;t).</param>
        /// <param name="objectiveHash">If this is populated, this is an objective related to the location..</param>
        /// <param name="activityHash">If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don&#39;t).</param>
        public DestinyConstantsDestinyEnvironmentLocationMapping(int locationHash = default(int), string activationSource = default(string), int itemHash = default(int), int objectiveHash = default(int), int activityHash = default(int))
        {
            this.LocationHash = locationHash;
            this.ActivationSource = activationSource;
            this.ItemHash = itemHash;
            this.ObjectiveHash = objectiveHash;
            this.ActivityHash = activityHash;
        }
        
        /// <summary>
        /// The location that is revealed on the director by this mapping.
        /// </summary>
        /// <value>The location that is revealed on the director by this mapping.</value>
        [DataMember(Name="locationHash", EmitDefaultValue=false)]
        public int LocationHash { get; set; }

        /// <summary>
        /// A hint that the UI uses to figure out how this location is activated by the player.
        /// </summary>
        /// <value>A hint that the UI uses to figure out how this location is activated by the player.</value>
        [DataMember(Name="activationSource", EmitDefaultValue=false)]
        public string ActivationSource { get; set; }

        /// <summary>
        /// If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don&#39;t)
        /// </summary>
        /// <value>If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don&#39;t)</value>
        [DataMember(Name="itemHash", EmitDefaultValue=false)]
        public int ItemHash { get; set; }

        /// <summary>
        /// If this is populated, this is an objective related to the location.
        /// </summary>
        /// <value>If this is populated, this is an objective related to the location.</value>
        [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
        public int ObjectiveHash { get; set; }

        /// <summary>
        /// If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don&#39;t)
        /// </summary>
        /// <value>If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don&#39;t)</value>
        [DataMember(Name="activityHash", EmitDefaultValue=false)]
        public int ActivityHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyConstantsDestinyEnvironmentLocationMapping {\n");
            sb.Append("  LocationHash: ").Append(LocationHash).Append("\n");
            sb.Append("  ActivationSource: ").Append(ActivationSource).Append("\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
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
            return this.Equals(input as DestinyConstantsDestinyEnvironmentLocationMapping);
        }

        /// <summary>
        /// Returns true if DestinyConstantsDestinyEnvironmentLocationMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyConstantsDestinyEnvironmentLocationMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyConstantsDestinyEnvironmentLocationMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationHash == input.LocationHash ||
                    this.LocationHash.Equals(input.LocationHash)
                ) && 
                (
                    this.ActivationSource == input.ActivationSource ||
                    (this.ActivationSource != null &&
                    this.ActivationSource.Equals(input.ActivationSource))
                ) && 
                (
                    this.ItemHash == input.ItemHash ||
                    this.ItemHash.Equals(input.ItemHash)
                ) && 
                (
                    this.ObjectiveHash == input.ObjectiveHash ||
                    this.ObjectiveHash.Equals(input.ObjectiveHash)
                ) && 
                (
                    this.ActivityHash == input.ActivityHash ||
                    this.ActivityHash.Equals(input.ActivityHash)
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
                hashCode = hashCode * 59 + this.LocationHash.GetHashCode();
                if (this.ActivationSource != null)
                    hashCode = hashCode * 59 + this.ActivationSource.GetHashCode();
                hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectiveHash.GetHashCode();
                hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
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
