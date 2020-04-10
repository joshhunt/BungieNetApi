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
    /// DestinyArtifactsDestinyArtifactCharacterScoped
    /// </summary>
    [DataContract]
    public partial class DestinyArtifactsDestinyArtifactCharacterScoped :  IEquatable<DestinyArtifactsDestinyArtifactCharacterScoped>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyArtifactsDestinyArtifactCharacterScoped" /> class.
        /// </summary>
        /// <param name="artifactHash">artifactHash.</param>
        /// <param name="pointsUsed">pointsUsed.</param>
        /// <param name="resetCount">resetCount.</param>
        /// <param name="tiers">tiers.</param>
        public DestinyArtifactsDestinyArtifactCharacterScoped(int artifactHash = default(int), int pointsUsed = default(int), int resetCount = default(int), List<DestinyArtifactsDestinyArtifactTier> tiers = default(List<DestinyArtifactsDestinyArtifactTier>))
        {
            this.ArtifactHash = artifactHash;
            this.PointsUsed = pointsUsed;
            this.ResetCount = resetCount;
            this.Tiers = tiers;
        }
        
        /// <summary>
        /// Gets or Sets ArtifactHash
        /// </summary>
        [DataMember(Name="artifactHash", EmitDefaultValue=false)]
        public int ArtifactHash { get; set; }

        /// <summary>
        /// Gets or Sets PointsUsed
        /// </summary>
        [DataMember(Name="pointsUsed", EmitDefaultValue=false)]
        public int PointsUsed { get; set; }

        /// <summary>
        /// Gets or Sets ResetCount
        /// </summary>
        [DataMember(Name="resetCount", EmitDefaultValue=false)]
        public int ResetCount { get; set; }

        /// <summary>
        /// Gets or Sets Tiers
        /// </summary>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<DestinyArtifactsDestinyArtifactTier> Tiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyArtifactsDestinyArtifactCharacterScoped {\n");
            sb.Append("  ArtifactHash: ").Append(ArtifactHash).Append("\n");
            sb.Append("  PointsUsed: ").Append(PointsUsed).Append("\n");
            sb.Append("  ResetCount: ").Append(ResetCount).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
            return this.Equals(input as DestinyArtifactsDestinyArtifactCharacterScoped);
        }

        /// <summary>
        /// Returns true if DestinyArtifactsDestinyArtifactCharacterScoped instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyArtifactsDestinyArtifactCharacterScoped to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyArtifactsDestinyArtifactCharacterScoped input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArtifactHash == input.ArtifactHash ||
                    (this.ArtifactHash != null &&
                    this.ArtifactHash.Equals(input.ArtifactHash))
                ) && 
                (
                    this.PointsUsed == input.PointsUsed ||
                    (this.PointsUsed != null &&
                    this.PointsUsed.Equals(input.PointsUsed))
                ) && 
                (
                    this.ResetCount == input.ResetCount ||
                    (this.ResetCount != null &&
                    this.ResetCount.Equals(input.ResetCount))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    input.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers)
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
                if (this.ArtifactHash != null)
                    hashCode = hashCode * 59 + this.ArtifactHash.GetHashCode();
                if (this.PointsUsed != null)
                    hashCode = hashCode * 59 + this.PointsUsed.GetHashCode();
                if (this.ResetCount != null)
                    hashCode = hashCode * 59 + this.ResetCount.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
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
