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
    /// DestinyItemComponentSetOfint64
    /// </summary>
    [DataContract]
    public partial class DestinyItemComponentSetOfint64 :  IEquatable<DestinyItemComponentSetOfint64>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyItemComponentSetOfint64" /> class.
        /// </summary>
        /// <param name="instances">instances.</param>
        /// <param name="perks">perks.</param>
        /// <param name="renderData">renderData.</param>
        /// <param name="stats">stats.</param>
        /// <param name="sockets">sockets.</param>
        /// <param name="reusablePlugs">reusablePlugs.</param>
        /// <param name="plugObjectives">plugObjectives.</param>
        /// <param name="talentGrids">talentGrids.</param>
        /// <param name="plugStates">plugStates.</param>
        /// <param name="objectives">objectives.</param>
        public DestinyItemComponentSetOfint64(DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent instances = default(DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent), DictionaryComponentResponseOfint64AndDestinyItemPerksComponent perks = default(DictionaryComponentResponseOfint64AndDestinyItemPerksComponent), DictionaryComponentResponseOfint64AndDestinyItemRenderComponent renderData = default(DictionaryComponentResponseOfint64AndDestinyItemRenderComponent), DictionaryComponentResponseOfint64AndDestinyItemStatsComponent stats = default(DictionaryComponentResponseOfint64AndDestinyItemStatsComponent), DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent sockets = default(DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent), DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent reusablePlugs = default(DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent), DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent plugObjectives = default(DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent), DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent talentGrids = default(DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent), DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent plugStates = default(DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent), DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent objectives = default(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent))
        {
            this.Instances = instances;
            this.Perks = perks;
            this.RenderData = renderData;
            this.Stats = stats;
            this.Sockets = sockets;
            this.ReusablePlugs = reusablePlugs;
            this.PlugObjectives = plugObjectives;
            this.TalentGrids = talentGrids;
            this.PlugStates = plugStates;
            this.Objectives = objectives;
        }
        
        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name="instances", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent Instances { get; set; }

        /// <summary>
        /// Gets or Sets Perks
        /// </summary>
        [DataMember(Name="perks", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemPerksComponent Perks { get; set; }

        /// <summary>
        /// Gets or Sets RenderData
        /// </summary>
        [DataMember(Name="renderData", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemRenderComponent RenderData { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemStatsComponent Stats { get; set; }

        /// <summary>
        /// Gets or Sets Sockets
        /// </summary>
        [DataMember(Name="sockets", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent Sockets { get; set; }

        /// <summary>
        /// Gets or Sets ReusablePlugs
        /// </summary>
        [DataMember(Name="reusablePlugs", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

        /// <summary>
        /// Gets or Sets PlugObjectives
        /// </summary>
        [DataMember(Name="plugObjectives", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }

        /// <summary>
        /// Gets or Sets TalentGrids
        /// </summary>
        [DataMember(Name="talentGrids", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent TalentGrids { get; set; }

        /// <summary>
        /// Gets or Sets PlugStates
        /// </summary>
        [DataMember(Name="plugStates", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }

        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name="objectives", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyItemComponentSetOfint64 {\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  Perks: ").Append(Perks).Append("\n");
            sb.Append("  RenderData: ").Append(RenderData).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Sockets: ").Append(Sockets).Append("\n");
            sb.Append("  ReusablePlugs: ").Append(ReusablePlugs).Append("\n");
            sb.Append("  PlugObjectives: ").Append(PlugObjectives).Append("\n");
            sb.Append("  TalentGrids: ").Append(TalentGrids).Append("\n");
            sb.Append("  PlugStates: ").Append(PlugStates).Append("\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
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
            return this.Equals(input as DestinyItemComponentSetOfint64);
        }

        /// <summary>
        /// Returns true if DestinyItemComponentSetOfint64 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyItemComponentSetOfint64 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyItemComponentSetOfint64 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instances == input.Instances ||
                    (this.Instances != null &&
                    this.Instances.Equals(input.Instances))
                ) && 
                (
                    this.Perks == input.Perks ||
                    (this.Perks != null &&
                    this.Perks.Equals(input.Perks))
                ) && 
                (
                    this.RenderData == input.RenderData ||
                    (this.RenderData != null &&
                    this.RenderData.Equals(input.RenderData))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Sockets == input.Sockets ||
                    (this.Sockets != null &&
                    this.Sockets.Equals(input.Sockets))
                ) && 
                (
                    this.ReusablePlugs == input.ReusablePlugs ||
                    (this.ReusablePlugs != null &&
                    this.ReusablePlugs.Equals(input.ReusablePlugs))
                ) && 
                (
                    this.PlugObjectives == input.PlugObjectives ||
                    (this.PlugObjectives != null &&
                    this.PlugObjectives.Equals(input.PlugObjectives))
                ) && 
                (
                    this.TalentGrids == input.TalentGrids ||
                    (this.TalentGrids != null &&
                    this.TalentGrids.Equals(input.TalentGrids))
                ) && 
                (
                    this.PlugStates == input.PlugStates ||
                    (this.PlugStates != null &&
                    this.PlugStates.Equals(input.PlugStates))
                ) && 
                (
                    this.Objectives == input.Objectives ||
                    (this.Objectives != null &&
                    this.Objectives.Equals(input.Objectives))
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
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.Perks != null)
                    hashCode = hashCode * 59 + this.Perks.GetHashCode();
                if (this.RenderData != null)
                    hashCode = hashCode * 59 + this.RenderData.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Sockets != null)
                    hashCode = hashCode * 59 + this.Sockets.GetHashCode();
                if (this.ReusablePlugs != null)
                    hashCode = hashCode * 59 + this.ReusablePlugs.GetHashCode();
                if (this.PlugObjectives != null)
                    hashCode = hashCode * 59 + this.PlugObjectives.GetHashCode();
                if (this.TalentGrids != null)
                    hashCode = hashCode * 59 + this.TalentGrids.GetHashCode();
                if (this.PlugStates != null)
                    hashCode = hashCode * 59 + this.PlugStates.GetHashCode();
                if (this.Objectives != null)
                    hashCode = hashCode * 59 + this.Objectives.GetHashCode();
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
