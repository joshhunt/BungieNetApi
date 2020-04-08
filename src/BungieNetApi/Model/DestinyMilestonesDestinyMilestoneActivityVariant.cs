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
    /// Represents custom data that we know about an individual variant of an activity.
    /// </summary>
    [DataContract]
    public partial class DestinyMilestonesDestinyMilestoneActivityVariant :  IEquatable<DestinyMilestonesDestinyMilestoneActivityVariant>, IValidatableObject
    {
        /// <summary>
        /// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
        /// </summary>
        /// <value>The enumeration equivalent of the most specific Activity Mode under which this activity is played.</value>
        public enum ActivityModeTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6,

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            NUMBER_7 = 7,

            /// <summary>
            /// Enum NUMBER_9 for value: 9
            /// </summary>
            NUMBER_9 = 9,

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            NUMBER_10 = 10,

            /// <summary>
            /// Enum NUMBER_11 for value: 11
            /// </summary>
            NUMBER_11 = 11,

            /// <summary>
            /// Enum NUMBER_12 for value: 12
            /// </summary>
            NUMBER_12 = 12,

            /// <summary>
            /// Enum NUMBER_13 for value: 13
            /// </summary>
            NUMBER_13 = 13,

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            NUMBER_15 = 15,

            /// <summary>
            /// Enum NUMBER_16 for value: 16
            /// </summary>
            NUMBER_16 = 16,

            /// <summary>
            /// Enum NUMBER_17 for value: 17
            /// </summary>
            NUMBER_17 = 17,

            /// <summary>
            /// Enum NUMBER_18 for value: 18
            /// </summary>
            NUMBER_18 = 18,

            /// <summary>
            /// Enum NUMBER_19 for value: 19
            /// </summary>
            NUMBER_19 = 19,

            /// <summary>
            /// Enum NUMBER_20 for value: 20
            /// </summary>
            NUMBER_20 = 20,

            /// <summary>
            /// Enum NUMBER_21 for value: 21
            /// </summary>
            NUMBER_21 = 21,

            /// <summary>
            /// Enum NUMBER_22 for value: 22
            /// </summary>
            NUMBER_22 = 22,

            /// <summary>
            /// Enum NUMBER_24 for value: 24
            /// </summary>
            NUMBER_24 = 24,

            /// <summary>
            /// Enum NUMBER_25 for value: 25
            /// </summary>
            NUMBER_25 = 25,

            /// <summary>
            /// Enum NUMBER_26 for value: 26
            /// </summary>
            NUMBER_26 = 26,

            /// <summary>
            /// Enum NUMBER_27 for value: 27
            /// </summary>
            NUMBER_27 = 27,

            /// <summary>
            /// Enum NUMBER_28 for value: 28
            /// </summary>
            NUMBER_28 = 28,

            /// <summary>
            /// Enum NUMBER_29 for value: 29
            /// </summary>
            NUMBER_29 = 29,

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            NUMBER_30 = 30,

            /// <summary>
            /// Enum NUMBER_31 for value: 31
            /// </summary>
            NUMBER_31 = 31,

            /// <summary>
            /// Enum NUMBER_32 for value: 32
            /// </summary>
            NUMBER_32 = 32,

            /// <summary>
            /// Enum NUMBER_37 for value: 37
            /// </summary>
            NUMBER_37 = 37,

            /// <summary>
            /// Enum NUMBER_38 for value: 38
            /// </summary>
            NUMBER_38 = 38,

            /// <summary>
            /// Enum NUMBER_39 for value: 39
            /// </summary>
            NUMBER_39 = 39,

            /// <summary>
            /// Enum NUMBER_40 for value: 40
            /// </summary>
            NUMBER_40 = 40,

            /// <summary>
            /// Enum NUMBER_41 for value: 41
            /// </summary>
            NUMBER_41 = 41,

            /// <summary>
            /// Enum NUMBER_42 for value: 42
            /// </summary>
            NUMBER_42 = 42,

            /// <summary>
            /// Enum NUMBER_43 for value: 43
            /// </summary>
            NUMBER_43 = 43,

            /// <summary>
            /// Enum NUMBER_44 for value: 44
            /// </summary>
            NUMBER_44 = 44,

            /// <summary>
            /// Enum NUMBER_45 for value: 45
            /// </summary>
            NUMBER_45 = 45,

            /// <summary>
            /// Enum NUMBER_46 for value: 46
            /// </summary>
            NUMBER_46 = 46,

            /// <summary>
            /// Enum NUMBER_47 for value: 47
            /// </summary>
            NUMBER_47 = 47,

            /// <summary>
            /// Enum NUMBER_48 for value: 48
            /// </summary>
            NUMBER_48 = 48,

            /// <summary>
            /// Enum NUMBER_49 for value: 49
            /// </summary>
            NUMBER_49 = 49,

            /// <summary>
            /// Enum NUMBER_50 for value: 50
            /// </summary>
            NUMBER_50 = 50,

            /// <summary>
            /// Enum NUMBER_51 for value: 51
            /// </summary>
            NUMBER_51 = 51,

            /// <summary>
            /// Enum NUMBER_52 for value: 52
            /// </summary>
            NUMBER_52 = 52,

            /// <summary>
            /// Enum NUMBER_53 for value: 53
            /// </summary>
            NUMBER_53 = 53,

            /// <summary>
            /// Enum NUMBER_54 for value: 54
            /// </summary>
            NUMBER_54 = 54,

            /// <summary>
            /// Enum NUMBER_55 for value: 55
            /// </summary>
            NUMBER_55 = 55,

            /// <summary>
            /// Enum NUMBER_56 for value: 56
            /// </summary>
            NUMBER_56 = 56,

            /// <summary>
            /// Enum NUMBER_57 for value: 57
            /// </summary>
            NUMBER_57 = 57,

            /// <summary>
            /// Enum NUMBER_58 for value: 58
            /// </summary>
            NUMBER_58 = 58,

            /// <summary>
            /// Enum NUMBER_59 for value: 59
            /// </summary>
            NUMBER_59 = 59,

            /// <summary>
            /// Enum NUMBER_60 for value: 60
            /// </summary>
            NUMBER_60 = 60,

            /// <summary>
            /// Enum NUMBER_61 for value: 61
            /// </summary>
            NUMBER_61 = 61,

            /// <summary>
            /// Enum NUMBER_62 for value: 62
            /// </summary>
            NUMBER_62 = 62,

            /// <summary>
            /// Enum NUMBER_63 for value: 63
            /// </summary>
            NUMBER_63 = 63,

            /// <summary>
            /// Enum NUMBER_64 for value: 64
            /// </summary>
            NUMBER_64 = 64,

            /// <summary>
            /// Enum NUMBER_65 for value: 65
            /// </summary>
            NUMBER_65 = 65,

            /// <summary>
            /// Enum NUMBER_66 for value: 66
            /// </summary>
            NUMBER_66 = 66,

            /// <summary>
            /// Enum NUMBER_67 for value: 67
            /// </summary>
            NUMBER_67 = 67,

            /// <summary>
            /// Enum NUMBER_68 for value: 68
            /// </summary>
            NUMBER_68 = 68,

            /// <summary>
            /// Enum NUMBER_69 for value: 69
            /// </summary>
            NUMBER_69 = 69,

            /// <summary>
            /// Enum NUMBER_70 for value: 70
            /// </summary>
            NUMBER_70 = 70,

            /// <summary>
            /// Enum NUMBER_71 for value: 71
            /// </summary>
            NUMBER_71 = 71,

            /// <summary>
            /// Enum NUMBER_72 for value: 72
            /// </summary>
            NUMBER_72 = 72,

            /// <summary>
            /// Enum NUMBER_73 for value: 73
            /// </summary>
            NUMBER_73 = 73,

            /// <summary>
            /// Enum NUMBER_74 for value: 74
            /// </summary>
            NUMBER_74 = 74,

            /// <summary>
            /// Enum NUMBER_75 for value: 75
            /// </summary>
            NUMBER_75 = 75,

            /// <summary>
            /// Enum NUMBER_76 for value: 76
            /// </summary>
            NUMBER_76 = 76,

            /// <summary>
            /// Enum NUMBER_77 for value: 77
            /// </summary>
            NUMBER_77 = 77,

            /// <summary>
            /// Enum NUMBER_78 for value: 78
            /// </summary>
            NUMBER_78 = 78,

            /// <summary>
            /// Enum NUMBER_79 for value: 79
            /// </summary>
            NUMBER_79 = 79,

            /// <summary>
            /// Enum NUMBER_80 for value: 80
            /// </summary>
            NUMBER_80 = 80,

            /// <summary>
            /// Enum NUMBER_81 for value: 81
            /// </summary>
            NUMBER_81 = 81,

            /// <summary>
            /// Enum NUMBER_82 for value: 82
            /// </summary>
            NUMBER_82 = 82,

            /// <summary>
            /// Enum NUMBER_83 for value: 83
            /// </summary>
            NUMBER_83 = 83,

            /// <summary>
            /// Enum NUMBER_84 for value: 84
            /// </summary>
            NUMBER_84 = 84

        }

        /// <summary>
        /// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
        /// </summary>
        /// <value>The enumeration equivalent of the most specific Activity Mode under which this activity is played.</value>
        [DataMember(Name="activityModeType", EmitDefaultValue=false)]
        public ActivityModeTypeEnum? ActivityModeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestoneActivityVariant" /> class.
        /// </summary>
        /// <param name="activityHash">The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level..</param>
        /// <param name="completionStatus">An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL..</param>
        /// <param name="activityModeHash">The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way..</param>
        /// <param name="activityModeType">The enumeration equivalent of the most specific Activity Mode under which this activity is played..</param>
        public DestinyMilestonesDestinyMilestoneActivityVariant(int activityHash = default(int), DestinyMilestonesDestinyMilestoneActivityCompletionStatus completionStatus = default(DestinyMilestonesDestinyMilestoneActivityCompletionStatus), int activityModeHash = default(int), ActivityModeTypeEnum? activityModeType = default(ActivityModeTypeEnum?))
        {
            this.ActivityHash = activityHash;
            this.CompletionStatus = completionStatus;
            this.ActivityModeHash = activityModeHash;
            this.ActivityModeType = activityModeType;
        }
        
        /// <summary>
        /// The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.
        /// </summary>
        /// <value>The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.</value>
        [DataMember(Name="activityHash", EmitDefaultValue=false)]
        public int ActivityHash { get; set; }

        /// <summary>
        /// An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL.
        /// </summary>
        /// <value>An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL.</value>
        [DataMember(Name="completionStatus", EmitDefaultValue=false)]
        public DestinyMilestonesDestinyMilestoneActivityCompletionStatus CompletionStatus { get; set; }

        /// <summary>
        /// The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way.
        /// </summary>
        /// <value>The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way.</value>
        [DataMember(Name="activityModeHash", EmitDefaultValue=false)]
        public int ActivityModeHash { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyMilestoneActivityVariant {\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
            sb.Append("  ActivityModeHash: ").Append(ActivityModeHash).Append("\n");
            sb.Append("  ActivityModeType: ").Append(ActivityModeType).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyMilestoneActivityVariant);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestoneActivityVariant instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestoneActivityVariant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestoneActivityVariant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityHash == input.ActivityHash ||
                    (this.ActivityHash != null &&
                    this.ActivityHash.Equals(input.ActivityHash))
                ) && 
                (
                    this.CompletionStatus == input.CompletionStatus ||
                    (this.CompletionStatus != null &&
                    this.CompletionStatus.Equals(input.CompletionStatus))
                ) && 
                (
                    this.ActivityModeHash == input.ActivityModeHash ||
                    (this.ActivityModeHash != null &&
                    this.ActivityModeHash.Equals(input.ActivityModeHash))
                ) && 
                (
                    this.ActivityModeType == input.ActivityModeType ||
                    (this.ActivityModeType != null &&
                    this.ActivityModeType.Equals(input.ActivityModeType))
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
                if (this.ActivityHash != null)
                    hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
                if (this.CompletionStatus != null)
                    hashCode = hashCode * 59 + this.CompletionStatus.GetHashCode();
                if (this.ActivityModeHash != null)
                    hashCode = hashCode * 59 + this.ActivityModeHash.GetHashCode();
                if (this.ActivityModeType != null)
                    hashCode = hashCode * 59 + this.ActivityModeType.GetHashCode();
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
