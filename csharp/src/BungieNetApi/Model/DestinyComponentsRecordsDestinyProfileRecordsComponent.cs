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
    /// DestinyComponentsRecordsDestinyProfileRecordsComponent
    /// </summary>
    [DataContract]
    public partial class DestinyComponentsRecordsDestinyProfileRecordsComponent :  IEquatable<DestinyComponentsRecordsDestinyProfileRecordsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsRecordsDestinyProfileRecordsComponent" /> class.
        /// </summary>
        /// <param name="score">Your \&quot;Triumphs\&quot; score..</param>
        /// <param name="trackedRecordHash">If this profile is tracking a record, this is the hash identifier of the record it is tracking..</param>
        /// <param name="records">records.</param>
        /// <param name="recordCategoriesRootNodeHash">The hash for the root presentation node definition of Triumph categories..</param>
        /// <param name="recordSealsRootNodeHash">The hash for the root presentation node definition of Triumph Seals..</param>
        public DestinyComponentsRecordsDestinyProfileRecordsComponent(int score = default(int), int trackedRecordHash = default(int), Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> records = default(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent>), int recordCategoriesRootNodeHash = default(int), int recordSealsRootNodeHash = default(int))
        {
            this.Score = score;
            this.TrackedRecordHash = trackedRecordHash;
            this.Records = records;
            this.RecordCategoriesRootNodeHash = recordCategoriesRootNodeHash;
            this.RecordSealsRootNodeHash = recordSealsRootNodeHash;
        }
        
        /// <summary>
        /// Your \&quot;Triumphs\&quot; score.
        /// </summary>
        /// <value>Your \&quot;Triumphs\&quot; score.</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public int Score { get; set; }

        /// <summary>
        /// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
        /// </summary>
        /// <value>If this profile is tracking a record, this is the hash identifier of the record it is tracking.</value>
        [DataMember(Name="trackedRecordHash", EmitDefaultValue=false)]
        public int TrackedRecordHash { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph categories.
        /// </summary>
        /// <value>The hash for the root presentation node definition of Triumph categories.</value>
        [DataMember(Name="recordCategoriesRootNodeHash", EmitDefaultValue=false)]
        public int RecordCategoriesRootNodeHash { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph Seals.
        /// </summary>
        /// <value>The hash for the root presentation node definition of Triumph Seals.</value>
        [DataMember(Name="recordSealsRootNodeHash", EmitDefaultValue=false)]
        public int RecordSealsRootNodeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyComponentsRecordsDestinyProfileRecordsComponent {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  TrackedRecordHash: ").Append(TrackedRecordHash).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  RecordCategoriesRootNodeHash: ").Append(RecordCategoriesRootNodeHash).Append("\n");
            sb.Append("  RecordSealsRootNodeHash: ").Append(RecordSealsRootNodeHash).Append("\n");
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
            return this.Equals(input as DestinyComponentsRecordsDestinyProfileRecordsComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsRecordsDestinyProfileRecordsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsRecordsDestinyProfileRecordsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsRecordsDestinyProfileRecordsComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.TrackedRecordHash == input.TrackedRecordHash ||
                    (this.TrackedRecordHash != null &&
                    this.TrackedRecordHash.Equals(input.TrackedRecordHash))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.RecordCategoriesRootNodeHash == input.RecordCategoriesRootNodeHash ||
                    (this.RecordCategoriesRootNodeHash != null &&
                    this.RecordCategoriesRootNodeHash.Equals(input.RecordCategoriesRootNodeHash))
                ) && 
                (
                    this.RecordSealsRootNodeHash == input.RecordSealsRootNodeHash ||
                    (this.RecordSealsRootNodeHash != null &&
                    this.RecordSealsRootNodeHash.Equals(input.RecordSealsRootNodeHash))
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
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.TrackedRecordHash != null)
                    hashCode = hashCode * 59 + this.TrackedRecordHash.GetHashCode();
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.RecordCategoriesRootNodeHash != null)
                    hashCode = hashCode * 59 + this.RecordCategoriesRootNodeHash.GetHashCode();
                if (this.RecordSealsRootNodeHash != null)
                    hashCode = hashCode * 59 + this.RecordSealsRootNodeHash.GetHashCode();
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
