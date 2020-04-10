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
    /// DestinyDefinitionsRecordsDestinyRecordDefinition
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsRecordsDestinyRecordDefinition :  IEquatable<DestinyDefinitionsRecordsDestinyRecordDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsRecordsDestinyRecordDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="scope">Indicates whether this Record&#39;s state is determined on a per-character or on an account-wide basis..</param>
        /// <param name="presentationInfo">presentationInfo.</param>
        /// <param name="loreHash">loreHash.</param>
        /// <param name="objectiveHashes">objectiveHashes.</param>
        /// <param name="recordValueStyle">recordValueStyle.</param>
        /// <param name="titleInfo">titleInfo.</param>
        /// <param name="completionInfo">completionInfo.</param>
        /// <param name="stateInfo">stateInfo.</param>
        /// <param name="requirements">requirements.</param>
        /// <param name="expirationInfo">expirationInfo.</param>
        /// <param name="intervalInfo">Some records have multiple &#39;interval&#39; objectives, and the record may be claimed at each completed interval.</param>
        /// <param name="rewardItems">If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \&quot;hidden\&quot; rewards. These will not be returned in this list..</param>
        /// <param name="presentationNodeType">presentationNodeType.</param>
        /// <param name="traitIds">traitIds.</param>
        /// <param name="traitHashes">traitHashes.</param>
        /// <param name="parentNodeHashes">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsRecordsDestinyRecordDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), int scope = default(int), DestinyDefinitionsPresentationDestinyPresentationChildBlock presentationInfo = default(DestinyDefinitionsPresentationDestinyPresentationChildBlock), long loreHash = default(long), List<long> objectiveHashes = default(List<long>), int recordValueStyle = default(int), DestinyDefinitionsRecordsDestinyRecordTitleBlock titleInfo = default(DestinyDefinitionsRecordsDestinyRecordTitleBlock), DestinyDefinitionsRecordsDestinyRecordCompletionBlock completionInfo = default(DestinyDefinitionsRecordsDestinyRecordCompletionBlock), DestinyDefinitionsRecordsSchemaRecordStateBlock stateInfo = default(DestinyDefinitionsRecordsSchemaRecordStateBlock), DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock requirements = default(DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock), DestinyDefinitionsRecordsDestinyRecordExpirationBlock expirationInfo = default(DestinyDefinitionsRecordsDestinyRecordExpirationBlock), DestinyDefinitionsRecordsDestinyRecordIntervalBlock intervalInfo = default(DestinyDefinitionsRecordsDestinyRecordIntervalBlock), List<DestinyDestinyItemQuantity> rewardItems = default(List<DestinyDestinyItemQuantity>), int presentationNodeType = default(int), List<string> traitIds = default(List<string>), List<long> traitHashes = default(List<long>), List<long> parentNodeHashes = default(List<long>), long hash = default(long), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.Scope = scope;
            this.PresentationInfo = presentationInfo;
            this.LoreHash = loreHash;
            this.ObjectiveHashes = objectiveHashes;
            this.RecordValueStyle = recordValueStyle;
            this.TitleInfo = titleInfo;
            this.CompletionInfo = completionInfo;
            this.StateInfo = stateInfo;
            this.Requirements = requirements;
            this.ExpirationInfo = expirationInfo;
            this.IntervalInfo = intervalInfo;
            this.RewardItems = rewardItems;
            this.PresentationNodeType = presentationNodeType;
            this.TraitIds = traitIds;
            this.TraitHashes = traitHashes;
            this.ParentNodeHashes = parentNodeHashes;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }
        
        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Indicates whether this Record&#39;s state is determined on a per-character or on an account-wide basis.
        /// </summary>
        /// <value>Indicates whether this Record&#39;s state is determined on a per-character or on an account-wide basis.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public int Scope { get; set; }

        /// <summary>
        /// Gets or Sets PresentationInfo
        /// </summary>
        [DataMember(Name="presentationInfo", EmitDefaultValue=false)]
        public DestinyDefinitionsPresentationDestinyPresentationChildBlock PresentationInfo { get; set; }

        /// <summary>
        /// Gets or Sets LoreHash
        /// </summary>
        [DataMember(Name="loreHash", EmitDefaultValue=false)]
        public long LoreHash { get; set; }

        /// <summary>
        /// Gets or Sets ObjectiveHashes
        /// </summary>
        [DataMember(Name="objectiveHashes", EmitDefaultValue=false)]
        public List<long> ObjectiveHashes { get; set; }

        /// <summary>
        /// Gets or Sets RecordValueStyle
        /// </summary>
        [DataMember(Name="recordValueStyle", EmitDefaultValue=false)]
        public int RecordValueStyle { get; set; }

        /// <summary>
        /// Gets or Sets TitleInfo
        /// </summary>
        [DataMember(Name="titleInfo", EmitDefaultValue=false)]
        public DestinyDefinitionsRecordsDestinyRecordTitleBlock TitleInfo { get; set; }

        /// <summary>
        /// Gets or Sets CompletionInfo
        /// </summary>
        [DataMember(Name="completionInfo", EmitDefaultValue=false)]
        public DestinyDefinitionsRecordsDestinyRecordCompletionBlock CompletionInfo { get; set; }

        /// <summary>
        /// Gets or Sets StateInfo
        /// </summary>
        [DataMember(Name="stateInfo", EmitDefaultValue=false)]
        public DestinyDefinitionsRecordsSchemaRecordStateBlock StateInfo { get; set; }

        /// <summary>
        /// Gets or Sets Requirements
        /// </summary>
        [DataMember(Name="requirements", EmitDefaultValue=false)]
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationInfo
        /// </summary>
        [DataMember(Name="expirationInfo", EmitDefaultValue=false)]
        public DestinyDefinitionsRecordsDestinyRecordExpirationBlock ExpirationInfo { get; set; }

        /// <summary>
        /// Some records have multiple &#39;interval&#39; objectives, and the record may be claimed at each completed interval
        /// </summary>
        /// <value>Some records have multiple &#39;interval&#39; objectives, and the record may be claimed at each completed interval</value>
        [DataMember(Name="intervalInfo", EmitDefaultValue=false)]
        public DestinyDefinitionsRecordsDestinyRecordIntervalBlock IntervalInfo { get; set; }

        /// <summary>
        /// If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \&quot;hidden\&quot; rewards. These will not be returned in this list.
        /// </summary>
        /// <value>If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \&quot;hidden\&quot; rewards. These will not be returned in this list.</value>
        [DataMember(Name="rewardItems", EmitDefaultValue=false)]
        public List<DestinyDestinyItemQuantity> RewardItems { get; set; }

        /// <summary>
        /// Gets or Sets PresentationNodeType
        /// </summary>
        [DataMember(Name="presentationNodeType", EmitDefaultValue=false)]
        public int PresentationNodeType { get; set; }

        /// <summary>
        /// Gets or Sets TraitIds
        /// </summary>
        [DataMember(Name="traitIds", EmitDefaultValue=false)]
        public List<string> TraitIds { get; set; }

        /// <summary>
        /// Gets or Sets TraitHashes
        /// </summary>
        [DataMember(Name="traitHashes", EmitDefaultValue=false)]
        public List<long> TraitHashes { get; set; }

        /// <summary>
        /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
        /// </summary>
        /// <value>A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</value>
        [DataMember(Name="parentNodeHashes", EmitDefaultValue=false)]
        public List<long> ParentNodeHashes { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public long Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsRecordsDestinyRecordDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  PresentationInfo: ").Append(PresentationInfo).Append("\n");
            sb.Append("  LoreHash: ").Append(LoreHash).Append("\n");
            sb.Append("  ObjectiveHashes: ").Append(ObjectiveHashes).Append("\n");
            sb.Append("  RecordValueStyle: ").Append(RecordValueStyle).Append("\n");
            sb.Append("  TitleInfo: ").Append(TitleInfo).Append("\n");
            sb.Append("  CompletionInfo: ").Append(CompletionInfo).Append("\n");
            sb.Append("  StateInfo: ").Append(StateInfo).Append("\n");
            sb.Append("  Requirements: ").Append(Requirements).Append("\n");
            sb.Append("  ExpirationInfo: ").Append(ExpirationInfo).Append("\n");
            sb.Append("  IntervalInfo: ").Append(IntervalInfo).Append("\n");
            sb.Append("  RewardItems: ").Append(RewardItems).Append("\n");
            sb.Append("  PresentationNodeType: ").Append(PresentationNodeType).Append("\n");
            sb.Append("  TraitIds: ").Append(TraitIds).Append("\n");
            sb.Append("  TraitHashes: ").Append(TraitHashes).Append("\n");
            sb.Append("  ParentNodeHashes: ").Append(ParentNodeHashes).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsRecordsDestinyRecordDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsRecordsDestinyRecordDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsRecordsDestinyRecordDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsRecordsDestinyRecordDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
                (
                    this.PresentationInfo == input.PresentationInfo ||
                    (this.PresentationInfo != null &&
                    this.PresentationInfo.Equals(input.PresentationInfo))
                ) && 
                (
                    this.LoreHash == input.LoreHash ||
                    this.LoreHash.Equals(input.LoreHash)
                ) && 
                (
                    this.ObjectiveHashes == input.ObjectiveHashes ||
                    this.ObjectiveHashes != null &&
                    input.ObjectiveHashes != null &&
                    this.ObjectiveHashes.SequenceEqual(input.ObjectiveHashes)
                ) && 
                (
                    this.RecordValueStyle == input.RecordValueStyle ||
                    this.RecordValueStyle.Equals(input.RecordValueStyle)
                ) && 
                (
                    this.TitleInfo == input.TitleInfo ||
                    (this.TitleInfo != null &&
                    this.TitleInfo.Equals(input.TitleInfo))
                ) && 
                (
                    this.CompletionInfo == input.CompletionInfo ||
                    (this.CompletionInfo != null &&
                    this.CompletionInfo.Equals(input.CompletionInfo))
                ) && 
                (
                    this.StateInfo == input.StateInfo ||
                    (this.StateInfo != null &&
                    this.StateInfo.Equals(input.StateInfo))
                ) && 
                (
                    this.Requirements == input.Requirements ||
                    (this.Requirements != null &&
                    this.Requirements.Equals(input.Requirements))
                ) && 
                (
                    this.ExpirationInfo == input.ExpirationInfo ||
                    (this.ExpirationInfo != null &&
                    this.ExpirationInfo.Equals(input.ExpirationInfo))
                ) && 
                (
                    this.IntervalInfo == input.IntervalInfo ||
                    (this.IntervalInfo != null &&
                    this.IntervalInfo.Equals(input.IntervalInfo))
                ) && 
                (
                    this.RewardItems == input.RewardItems ||
                    this.RewardItems != null &&
                    input.RewardItems != null &&
                    this.RewardItems.SequenceEqual(input.RewardItems)
                ) && 
                (
                    this.PresentationNodeType == input.PresentationNodeType ||
                    this.PresentationNodeType.Equals(input.PresentationNodeType)
                ) && 
                (
                    this.TraitIds == input.TraitIds ||
                    this.TraitIds != null &&
                    input.TraitIds != null &&
                    this.TraitIds.SequenceEqual(input.TraitIds)
                ) && 
                (
                    this.TraitHashes == input.TraitHashes ||
                    this.TraitHashes != null &&
                    input.TraitHashes != null &&
                    this.TraitHashes.SequenceEqual(input.TraitHashes)
                ) && 
                (
                    this.ParentNodeHashes == input.ParentNodeHashes ||
                    this.ParentNodeHashes != null &&
                    input.ParentNodeHashes != null &&
                    this.ParentNodeHashes.SequenceEqual(input.ParentNodeHashes)
                ) && 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    this.Redacted.Equals(input.Redacted)
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
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.PresentationInfo != null)
                    hashCode = hashCode * 59 + this.PresentationInfo.GetHashCode();
                hashCode = hashCode * 59 + this.LoreHash.GetHashCode();
                if (this.ObjectiveHashes != null)
                    hashCode = hashCode * 59 + this.ObjectiveHashes.GetHashCode();
                hashCode = hashCode * 59 + this.RecordValueStyle.GetHashCode();
                if (this.TitleInfo != null)
                    hashCode = hashCode * 59 + this.TitleInfo.GetHashCode();
                if (this.CompletionInfo != null)
                    hashCode = hashCode * 59 + this.CompletionInfo.GetHashCode();
                if (this.StateInfo != null)
                    hashCode = hashCode * 59 + this.StateInfo.GetHashCode();
                if (this.Requirements != null)
                    hashCode = hashCode * 59 + this.Requirements.GetHashCode();
                if (this.ExpirationInfo != null)
                    hashCode = hashCode * 59 + this.ExpirationInfo.GetHashCode();
                if (this.IntervalInfo != null)
                    hashCode = hashCode * 59 + this.IntervalInfo.GetHashCode();
                if (this.RewardItems != null)
                    hashCode = hashCode * 59 + this.RewardItems.GetHashCode();
                hashCode = hashCode * 59 + this.PresentationNodeType.GetHashCode();
                if (this.TraitIds != null)
                    hashCode = hashCode * 59 + this.TraitIds.GetHashCode();
                if (this.TraitHashes != null)
                    hashCode = hashCode * 59 + this.TraitHashes.GetHashCode();
                if (this.ParentNodeHashes != null)
                    hashCode = hashCode * 59 + this.ParentNodeHashes.GetHashCode();
                hashCode = hashCode * 59 + this.Hash.GetHashCode();
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                hashCode = hashCode * 59 + this.Redacted.GetHashCode();
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
