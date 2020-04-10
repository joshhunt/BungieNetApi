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
    /// Represents a reference to a Challenge, which for now is just an Objective.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyActivityChallengeDefinition :  IEquatable<DestinyDefinitionsDestinyActivityChallengeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyActivityChallengeDefinition" /> class.
        /// </summary>
        /// <param name="objectiveHash">The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition..</param>
        /// <param name="dummyRewards">The rewards as they&#39;re represented in the UI. Note that they generally link to \&quot;dummy\&quot; items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don&#39;t show the quantity..</param>
        public DestinyDefinitionsDestinyActivityChallengeDefinition(int objectiveHash = default(int), List<DestinyDestinyItemQuantity> dummyRewards = default(List<DestinyDestinyItemQuantity>))
        {
            this.ObjectiveHash = objectiveHash;
            this.DummyRewards = dummyRewards;
        }
        
        /// <summary>
        /// The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition.
        /// </summary>
        /// <value>The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition.</value>
        [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
        public int ObjectiveHash { get; set; }

        /// <summary>
        /// The rewards as they&#39;re represented in the UI. Note that they generally link to \&quot;dummy\&quot; items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don&#39;t show the quantity.
        /// </summary>
        /// <value>The rewards as they&#39;re represented in the UI. Note that they generally link to \&quot;dummy\&quot; items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don&#39;t show the quantity.</value>
        [DataMember(Name="dummyRewards", EmitDefaultValue=false)]
        public List<DestinyDestinyItemQuantity> DummyRewards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyActivityChallengeDefinition {\n");
            sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
            sb.Append("  DummyRewards: ").Append(DummyRewards).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyActivityChallengeDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyActivityChallengeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyActivityChallengeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyActivityChallengeDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectiveHash == input.ObjectiveHash ||
                    (this.ObjectiveHash != null &&
                    this.ObjectiveHash.Equals(input.ObjectiveHash))
                ) && 
                (
                    this.DummyRewards == input.DummyRewards ||
                    this.DummyRewards != null &&
                    input.DummyRewards != null &&
                    this.DummyRewards.SequenceEqual(input.DummyRewards)
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
                if (this.ObjectiveHash != null)
                    hashCode = hashCode * 59 + this.ObjectiveHash.GetHashCode();
                if (this.DummyRewards != null)
                    hashCode = hashCode * 59 + this.DummyRewards.GetHashCode();
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
