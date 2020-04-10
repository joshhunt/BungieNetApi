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
    /// Represents localized, extended content related to Milestones. This is intentionally returned by a separate endpoint and not with Character-level Milestone data because we do not put localized data into standard Destiny responses, both for brevity of response and for caching purposes. If you really need this data, hit the Milestone Content endpoint.
    /// </summary>
    [DataContract]
    public partial class DestinyMilestonesDestinyMilestoneContent :  IEquatable<DestinyMilestonesDestinyMilestoneContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestoneContent" /> class.
        /// </summary>
        /// <param name="about">The \&quot;About this Milestone\&quot; text from the Firehose..</param>
        /// <param name="status">The Current Status of the Milestone, as driven by the Firehose..</param>
        /// <param name="tips">A list of tips, provided by the Firehose..</param>
        /// <param name="itemCategories">If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here..</param>
        public DestinyMilestonesDestinyMilestoneContent(string about = default(string), string status = default(string), List<string> tips = default(List<string>), List<DestinyMilestonesDestinyMilestoneContentItemCategory> itemCategories = default(List<DestinyMilestonesDestinyMilestoneContentItemCategory>))
        {
            this.About = about;
            this.Status = status;
            this.Tips = tips;
            this.ItemCategories = itemCategories;
        }
        
        /// <summary>
        /// The \&quot;About this Milestone\&quot; text from the Firehose.
        /// </summary>
        /// <value>The \&quot;About this Milestone\&quot; text from the Firehose.</value>
        [DataMember(Name="about", EmitDefaultValue=false)]
        public string About { get; set; }

        /// <summary>
        /// The Current Status of the Milestone, as driven by the Firehose.
        /// </summary>
        /// <value>The Current Status of the Milestone, as driven by the Firehose.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// A list of tips, provided by the Firehose.
        /// </summary>
        /// <value>A list of tips, provided by the Firehose.</value>
        [DataMember(Name="tips", EmitDefaultValue=false)]
        public List<string> Tips { get; set; }

        /// <summary>
        /// If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here.
        /// </summary>
        /// <value>If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here.</value>
        [DataMember(Name="itemCategories", EmitDefaultValue=false)]
        public List<DestinyMilestonesDestinyMilestoneContentItemCategory> ItemCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyMilestoneContent {\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tips: ").Append(Tips).Append("\n");
            sb.Append("  ItemCategories: ").Append(ItemCategories).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyMilestoneContent);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestoneContent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestoneContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestoneContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.About == input.About ||
                    (this.About != null &&
                    this.About.Equals(input.About))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tips == input.Tips ||
                    this.Tips != null &&
                    input.Tips != null &&
                    this.Tips.SequenceEqual(input.Tips)
                ) && 
                (
                    this.ItemCategories == input.ItemCategories ||
                    this.ItemCategories != null &&
                    input.ItemCategories != null &&
                    this.ItemCategories.SequenceEqual(input.ItemCategories)
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
                if (this.About != null)
                    hashCode = hashCode * 59 + this.About.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tips != null)
                    hashCode = hashCode * 59 + this.Tips.GetHashCode();
                if (this.ItemCategories != null)
                    hashCode = hashCode * 59 + this.ItemCategories.GetHashCode();
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
