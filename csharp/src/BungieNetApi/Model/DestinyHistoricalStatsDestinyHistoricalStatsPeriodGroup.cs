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
    /// DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup
    /// </summary>
    [DataContract]
    public partial class DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup :  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup" /> class.
        /// </summary>
        /// <param name="period">Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is &#39;all time&#39;..</param>
        /// <param name="activityDetails">If the period group is for a specific activity, this property will be set..</param>
        /// <param name="values">Collection of stats for the period..</param>
        public DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup(DateTime period = default(DateTime), DestinyHistoricalStatsDestinyHistoricalStatsActivity activityDetails = default(DestinyHistoricalStatsDestinyHistoricalStatsActivity), Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> values = default(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue>))
        {
            this.Period = period;
            this.ActivityDetails = activityDetails;
            this.Values = values;
        }
        
        /// <summary>
        /// Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is &#39;all time&#39;.
        /// </summary>
        /// <value>Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is &#39;all time&#39;.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public DateTime Period { get; set; }

        /// <summary>
        /// If the period group is for a specific activity, this property will be set.
        /// </summary>
        /// <value>If the period group is for a specific activity, this property will be set.</value>
        [DataMember(Name="activityDetails", EmitDefaultValue=false)]
        public DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails { get; set; }

        /// <summary>
        /// Collection of stats for the period.
        /// </summary>
        /// <value>Collection of stats for the period.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  ActivityDetails: ").Append(ActivityDetails).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.ActivityDetails == input.ActivityDetails ||
                    (this.ActivityDetails != null &&
                    this.ActivityDetails.Equals(input.ActivityDetails))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.ActivityDetails != null)
                    hashCode = hashCode * 59 + this.ActivityDetails.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
