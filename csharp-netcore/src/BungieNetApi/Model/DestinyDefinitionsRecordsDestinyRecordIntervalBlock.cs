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
    /// DestinyDefinitionsRecordsDestinyRecordIntervalBlock
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsRecordsDestinyRecordIntervalBlock :  IEquatable<DestinyDefinitionsRecordsDestinyRecordIntervalBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsRecordsDestinyRecordIntervalBlock" /> class.
        /// </summary>
        /// <param name="intervalObjectives">intervalObjectives.</param>
        /// <param name="originalObjectiveArrayInsertionIndex">originalObjectiveArrayInsertionIndex.</param>
        public DestinyDefinitionsRecordsDestinyRecordIntervalBlock(List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective> intervalObjectives = default(List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective>), int originalObjectiveArrayInsertionIndex = default(int))
        {
            this.IntervalObjectives = intervalObjectives;
            this.OriginalObjectiveArrayInsertionIndex = originalObjectiveArrayInsertionIndex;
        }
        
        /// <summary>
        /// Gets or Sets IntervalObjectives
        /// </summary>
        [DataMember(Name="intervalObjectives", EmitDefaultValue=false)]
        public List<DestinyDefinitionsRecordsDestinyRecordIntervalObjective> IntervalObjectives { get; set; }

        /// <summary>
        /// Gets or Sets OriginalObjectiveArrayInsertionIndex
        /// </summary>
        [DataMember(Name="originalObjectiveArrayInsertionIndex", EmitDefaultValue=false)]
        public int OriginalObjectiveArrayInsertionIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsRecordsDestinyRecordIntervalBlock {\n");
            sb.Append("  IntervalObjectives: ").Append(IntervalObjectives).Append("\n");
            sb.Append("  OriginalObjectiveArrayInsertionIndex: ").Append(OriginalObjectiveArrayInsertionIndex).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsRecordsDestinyRecordIntervalBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsRecordsDestinyRecordIntervalBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsRecordsDestinyRecordIntervalBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsRecordsDestinyRecordIntervalBlock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IntervalObjectives == input.IntervalObjectives ||
                    this.IntervalObjectives != null &&
                    input.IntervalObjectives != null &&
                    this.IntervalObjectives.SequenceEqual(input.IntervalObjectives)
                ) && 
                (
                    this.OriginalObjectiveArrayInsertionIndex == input.OriginalObjectiveArrayInsertionIndex ||
                    this.OriginalObjectiveArrayInsertionIndex.Equals(input.OriginalObjectiveArrayInsertionIndex)
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
                if (this.IntervalObjectives != null)
                    hashCode = hashCode * 59 + this.IntervalObjectives.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalObjectiveArrayInsertionIndex.GetHashCode();
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
