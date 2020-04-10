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
    /// DestinyComponentsRecordsDestinyRecordComponent
    /// </summary>
    [DataContract]
    public partial class DestinyComponentsRecordsDestinyRecordComponent :  IEquatable<DestinyComponentsRecordsDestinyRecordComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsRecordsDestinyRecordComponent" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="objectives">objectives.</param>
        /// <param name="intervalObjectives">intervalObjectives.</param>
        /// <param name="intervalsRedeemedCount">intervalsRedeemedCount.</param>
        public DestinyComponentsRecordsDestinyRecordComponent(int state = default(int), List<DestinyQuestsDestinyObjectiveProgress> objectives = default(List<DestinyQuestsDestinyObjectiveProgress>), List<DestinyQuestsDestinyObjectiveProgress> intervalObjectives = default(List<DestinyQuestsDestinyObjectiveProgress>), int intervalsRedeemedCount = default(int))
        {
            this.State = state;
            this.Objectives = objectives;
            this.IntervalObjectives = intervalObjectives;
            this.IntervalsRedeemedCount = intervalsRedeemedCount;
        }
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int State { get; set; }

        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name="objectives", EmitDefaultValue=false)]
        public List<DestinyQuestsDestinyObjectiveProgress> Objectives { get; set; }

        /// <summary>
        /// Gets or Sets IntervalObjectives
        /// </summary>
        [DataMember(Name="intervalObjectives", EmitDefaultValue=false)]
        public List<DestinyQuestsDestinyObjectiveProgress> IntervalObjectives { get; set; }

        /// <summary>
        /// Gets or Sets IntervalsRedeemedCount
        /// </summary>
        [DataMember(Name="intervalsRedeemedCount", EmitDefaultValue=false)]
        public int IntervalsRedeemedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyComponentsRecordsDestinyRecordComponent {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
            sb.Append("  IntervalObjectives: ").Append(IntervalObjectives).Append("\n");
            sb.Append("  IntervalsRedeemedCount: ").Append(IntervalsRedeemedCount).Append("\n");
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
            return this.Equals(input as DestinyComponentsRecordsDestinyRecordComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsRecordsDestinyRecordComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsRecordsDestinyRecordComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsRecordsDestinyRecordComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Objectives == input.Objectives ||
                    this.Objectives != null &&
                    input.Objectives != null &&
                    this.Objectives.SequenceEqual(input.Objectives)
                ) && 
                (
                    this.IntervalObjectives == input.IntervalObjectives ||
                    this.IntervalObjectives != null &&
                    input.IntervalObjectives != null &&
                    this.IntervalObjectives.SequenceEqual(input.IntervalObjectives)
                ) && 
                (
                    this.IntervalsRedeemedCount == input.IntervalsRedeemedCount ||
                    (this.IntervalsRedeemedCount != null &&
                    this.IntervalsRedeemedCount.Equals(input.IntervalsRedeemedCount))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Objectives != null)
                    hashCode = hashCode * 59 + this.Objectives.GetHashCode();
                if (this.IntervalObjectives != null)
                    hashCode = hashCode * 59 + this.IntervalObjectives.GetHashCode();
                if (this.IntervalsRedeemedCount != null)
                    hashCode = hashCode * 59 + this.IntervalsRedeemedCount.GetHashCode();
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
