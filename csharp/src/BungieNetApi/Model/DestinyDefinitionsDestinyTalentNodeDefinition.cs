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
    /// Talent Grids on items have Nodes. These nodes have positions in the talent grid&#39;s UI, and contain \&quot;Steps\&quot; (DestinyTalentNodeStepDefinition), one of whom will be the \&quot;Current\&quot; step.  The Current Step determines the visual properties of the node, as well as what the node grants when it is activated.  See DestinyTalentGridDefinition for a more complete overview of how Talent Grids work, and how they are used in Destiny 2 (and how they were used in Destiny 1).
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyTalentNodeDefinition :  IEquatable<DestinyDefinitionsDestinyTalentNodeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyTalentNodeDefinition" /> class.
        /// </summary>
        /// <param name="nodeIndex">The index into the DestinyTalentGridDefinition&#39;s \&quot;nodes\&quot; property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties..</param>
        /// <param name="nodeHash">The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.  The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!.</param>
        /// <param name="row">The visual \&quot;row\&quot; where the node should be shown in the UI. If negative, then the node is hidden..</param>
        /// <param name="column">The visual \&quot;column\&quot; where the node should be shown in the UI. If negative, the node is hidden..</param>
        /// <param name="prerequisiteNodeIndexes">Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.  I would have liked to change this to hashes for Destiny 2, but we have run out of time..</param>
        /// <param name="binaryPairNodeIndex">At one point, Talent Nodes supported the idea of \&quot;Binary Pairs\&quot;: nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.  If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other..</param>
        /// <param name="autoUnlocks">If true, this node will automatically unlock when the Talent Grid&#39;s level reaches the required level of the current step of this node..</param>
        /// <param name="lastStepRepeats">At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times.   This is not currently used, but it isn&#39;t out of the question that this could end up being used again in a theoretical future..</param>
        /// <param name="isRandom">If this is true, the node&#39;s step is determined randomly rather than the first step being chosen..</param>
        /// <param name="randomActivationRequirement">At one point, you were going to be able to repurchase talent nodes that had random steps, to \&quot;re-roll\&quot; the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.  The system still exists to do this, as far as I know, so it may yet come back around!.</param>
        /// <param name="isRandomRepurchasable">If this is true, the node can be \&quot;re-rolled\&quot; to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids..</param>
        /// <param name="steps">At this point, \&quot;steps\&quot; have been obfuscated into conceptual entities, aggregating the underlying notions of \&quot;properties\&quot; and \&quot;true steps\&quot;.  If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you&#39;ll have to use the \&quot;realSteps\&quot; property below..</param>
        /// <param name="exclusiveWithNodeHashes">The nodeHash values for nodes that are in an Exclusive Set with this node.  See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.  Again, note that these are nodeHashes and *not* nodeIndexes..</param>
        /// <param name="randomStartProgressionBarAtProgression">If the node&#39;s step is randomly selected, this is the amount of the Talent Grid&#39;s progression experience at which the progression bar for the node should be shown..</param>
        /// <param name="layoutIdentifier">A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts..</param>
        /// <param name="groupHash">As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.  See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node&#39;s group, if it is part of one..</param>
        /// <param name="loreHash">Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show..</param>
        /// <param name="nodeStyleIdentifier">Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI..</param>
        /// <param name="ignoreForCompletion">Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete..</param>
        public DestinyDefinitionsDestinyTalentNodeDefinition(int nodeIndex = default(int), int nodeHash = default(int), int row = default(int), int column = default(int), List<int> prerequisiteNodeIndexes = default(List<int>), int binaryPairNodeIndex = default(int), bool autoUnlocks = default(bool), bool lastStepRepeats = default(bool), bool isRandom = default(bool), DestinyDefinitionsDestinyNodeActivationRequirement randomActivationRequirement = default(DestinyDefinitionsDestinyNodeActivationRequirement), bool isRandomRepurchasable = default(bool), List<DestinyDefinitionsDestinyNodeStepDefinition> steps = default(List<DestinyDefinitionsDestinyNodeStepDefinition>), List<int> exclusiveWithNodeHashes = default(List<int>), int randomStartProgressionBarAtProgression = default(int), string layoutIdentifier = default(string), int groupHash = default(int), int loreHash = default(int), string nodeStyleIdentifier = default(string), bool ignoreForCompletion = default(bool))
        {
            this.NodeIndex = nodeIndex;
            this.NodeHash = nodeHash;
            this.Row = row;
            this.Column = column;
            this.PrerequisiteNodeIndexes = prerequisiteNodeIndexes;
            this.BinaryPairNodeIndex = binaryPairNodeIndex;
            this.AutoUnlocks = autoUnlocks;
            this.LastStepRepeats = lastStepRepeats;
            this.IsRandom = isRandom;
            this.RandomActivationRequirement = randomActivationRequirement;
            this.IsRandomRepurchasable = isRandomRepurchasable;
            this.Steps = steps;
            this.ExclusiveWithNodeHashes = exclusiveWithNodeHashes;
            this.RandomStartProgressionBarAtProgression = randomStartProgressionBarAtProgression;
            this.LayoutIdentifier = layoutIdentifier;
            this.GroupHash = groupHash;
            this.LoreHash = loreHash;
            this.NodeStyleIdentifier = nodeStyleIdentifier;
            this.IgnoreForCompletion = ignoreForCompletion;
        }
        
        /// <summary>
        /// The index into the DestinyTalentGridDefinition&#39;s \&quot;nodes\&quot; property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties.
        /// </summary>
        /// <value>The index into the DestinyTalentGridDefinition&#39;s \&quot;nodes\&quot; property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties.</value>
        [DataMember(Name="nodeIndex", EmitDefaultValue=false)]
        public int NodeIndex { get; set; }

        /// <summary>
        /// The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.  The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!
        /// </summary>
        /// <value>The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.  The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!</value>
        [DataMember(Name="nodeHash", EmitDefaultValue=false)]
        public int NodeHash { get; set; }

        /// <summary>
        /// The visual \&quot;row\&quot; where the node should be shown in the UI. If negative, then the node is hidden.
        /// </summary>
        /// <value>The visual \&quot;row\&quot; where the node should be shown in the UI. If negative, then the node is hidden.</value>
        [DataMember(Name="row", EmitDefaultValue=false)]
        public int Row { get; set; }

        /// <summary>
        /// The visual \&quot;column\&quot; where the node should be shown in the UI. If negative, the node is hidden.
        /// </summary>
        /// <value>The visual \&quot;column\&quot; where the node should be shown in the UI. If negative, the node is hidden.</value>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public int Column { get; set; }

        /// <summary>
        /// Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.  I would have liked to change this to hashes for Destiny 2, but we have run out of time.
        /// </summary>
        /// <value>Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.  I would have liked to change this to hashes for Destiny 2, but we have run out of time.</value>
        [DataMember(Name="prerequisiteNodeIndexes", EmitDefaultValue=false)]
        public List<int> PrerequisiteNodeIndexes { get; set; }

        /// <summary>
        /// At one point, Talent Nodes supported the idea of \&quot;Binary Pairs\&quot;: nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.  If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other.
        /// </summary>
        /// <value>At one point, Talent Nodes supported the idea of \&quot;Binary Pairs\&quot;: nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.  If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other.</value>
        [DataMember(Name="binaryPairNodeIndex", EmitDefaultValue=false)]
        public int BinaryPairNodeIndex { get; set; }

        /// <summary>
        /// If true, this node will automatically unlock when the Talent Grid&#39;s level reaches the required level of the current step of this node.
        /// </summary>
        /// <value>If true, this node will automatically unlock when the Talent Grid&#39;s level reaches the required level of the current step of this node.</value>
        [DataMember(Name="autoUnlocks", EmitDefaultValue=false)]
        public bool AutoUnlocks { get; set; }

        /// <summary>
        /// At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times.   This is not currently used, but it isn&#39;t out of the question that this could end up being used again in a theoretical future.
        /// </summary>
        /// <value>At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times.   This is not currently used, but it isn&#39;t out of the question that this could end up being used again in a theoretical future.</value>
        [DataMember(Name="lastStepRepeats", EmitDefaultValue=false)]
        public bool LastStepRepeats { get; set; }

        /// <summary>
        /// If this is true, the node&#39;s step is determined randomly rather than the first step being chosen.
        /// </summary>
        /// <value>If this is true, the node&#39;s step is determined randomly rather than the first step being chosen.</value>
        [DataMember(Name="isRandom", EmitDefaultValue=false)]
        public bool IsRandom { get; set; }

        /// <summary>
        /// At one point, you were going to be able to repurchase talent nodes that had random steps, to \&quot;re-roll\&quot; the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.  The system still exists to do this, as far as I know, so it may yet come back around!
        /// </summary>
        /// <value>At one point, you were going to be able to repurchase talent nodes that had random steps, to \&quot;re-roll\&quot; the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.  The system still exists to do this, as far as I know, so it may yet come back around!</value>
        [DataMember(Name="randomActivationRequirement", EmitDefaultValue=false)]
        public DestinyDefinitionsDestinyNodeActivationRequirement RandomActivationRequirement { get; set; }

        /// <summary>
        /// If this is true, the node can be \&quot;re-rolled\&quot; to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids.
        /// </summary>
        /// <value>If this is true, the node can be \&quot;re-rolled\&quot; to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids.</value>
        [DataMember(Name="isRandomRepurchasable", EmitDefaultValue=false)]
        public bool IsRandomRepurchasable { get; set; }

        /// <summary>
        /// At this point, \&quot;steps\&quot; have been obfuscated into conceptual entities, aggregating the underlying notions of \&quot;properties\&quot; and \&quot;true steps\&quot;.  If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you&#39;ll have to use the \&quot;realSteps\&quot; property below.
        /// </summary>
        /// <value>At this point, \&quot;steps\&quot; have been obfuscated into conceptual entities, aggregating the underlying notions of \&quot;properties\&quot; and \&quot;true steps\&quot;.  If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you&#39;ll have to use the \&quot;realSteps\&quot; property below.</value>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<DestinyDefinitionsDestinyNodeStepDefinition> Steps { get; set; }

        /// <summary>
        /// The nodeHash values for nodes that are in an Exclusive Set with this node.  See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.  Again, note that these are nodeHashes and *not* nodeIndexes.
        /// </summary>
        /// <value>The nodeHash values for nodes that are in an Exclusive Set with this node.  See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.  Again, note that these are nodeHashes and *not* nodeIndexes.</value>
        [DataMember(Name="exclusiveWithNodeHashes", EmitDefaultValue=false)]
        public List<int> ExclusiveWithNodeHashes { get; set; }

        /// <summary>
        /// If the node&#39;s step is randomly selected, this is the amount of the Talent Grid&#39;s progression experience at which the progression bar for the node should be shown.
        /// </summary>
        /// <value>If the node&#39;s step is randomly selected, this is the amount of the Talent Grid&#39;s progression experience at which the progression bar for the node should be shown.</value>
        [DataMember(Name="randomStartProgressionBarAtProgression", EmitDefaultValue=false)]
        public int RandomStartProgressionBarAtProgression { get; set; }

        /// <summary>
        /// A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts.
        /// </summary>
        /// <value>A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts.</value>
        [DataMember(Name="layoutIdentifier", EmitDefaultValue=false)]
        public string LayoutIdentifier { get; set; }

        /// <summary>
        /// As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.  See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node&#39;s group, if it is part of one.
        /// </summary>
        /// <value>As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.  See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node&#39;s group, if it is part of one.</value>
        [DataMember(Name="groupHash", EmitDefaultValue=false)]
        public int GroupHash { get; set; }

        /// <summary>
        /// Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show.
        /// </summary>
        /// <value>Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show.</value>
        [DataMember(Name="loreHash", EmitDefaultValue=false)]
        public int LoreHash { get; set; }

        /// <summary>
        /// Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI.
        /// </summary>
        /// <value>Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI.</value>
        [DataMember(Name="nodeStyleIdentifier", EmitDefaultValue=false)]
        public string NodeStyleIdentifier { get; set; }

        /// <summary>
        /// Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete.
        /// </summary>
        /// <value>Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete.</value>
        [DataMember(Name="ignoreForCompletion", EmitDefaultValue=false)]
        public bool IgnoreForCompletion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyTalentNodeDefinition {\n");
            sb.Append("  NodeIndex: ").Append(NodeIndex).Append("\n");
            sb.Append("  NodeHash: ").Append(NodeHash).Append("\n");
            sb.Append("  Row: ").Append(Row).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  PrerequisiteNodeIndexes: ").Append(PrerequisiteNodeIndexes).Append("\n");
            sb.Append("  BinaryPairNodeIndex: ").Append(BinaryPairNodeIndex).Append("\n");
            sb.Append("  AutoUnlocks: ").Append(AutoUnlocks).Append("\n");
            sb.Append("  LastStepRepeats: ").Append(LastStepRepeats).Append("\n");
            sb.Append("  IsRandom: ").Append(IsRandom).Append("\n");
            sb.Append("  RandomActivationRequirement: ").Append(RandomActivationRequirement).Append("\n");
            sb.Append("  IsRandomRepurchasable: ").Append(IsRandomRepurchasable).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  ExclusiveWithNodeHashes: ").Append(ExclusiveWithNodeHashes).Append("\n");
            sb.Append("  RandomStartProgressionBarAtProgression: ").Append(RandomStartProgressionBarAtProgression).Append("\n");
            sb.Append("  LayoutIdentifier: ").Append(LayoutIdentifier).Append("\n");
            sb.Append("  GroupHash: ").Append(GroupHash).Append("\n");
            sb.Append("  LoreHash: ").Append(LoreHash).Append("\n");
            sb.Append("  NodeStyleIdentifier: ").Append(NodeStyleIdentifier).Append("\n");
            sb.Append("  IgnoreForCompletion: ").Append(IgnoreForCompletion).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyTalentNodeDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyTalentNodeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyTalentNodeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyTalentNodeDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeIndex == input.NodeIndex ||
                    (this.NodeIndex != null &&
                    this.NodeIndex.Equals(input.NodeIndex))
                ) && 
                (
                    this.NodeHash == input.NodeHash ||
                    (this.NodeHash != null &&
                    this.NodeHash.Equals(input.NodeHash))
                ) && 
                (
                    this.Row == input.Row ||
                    (this.Row != null &&
                    this.Row.Equals(input.Row))
                ) && 
                (
                    this.Column == input.Column ||
                    (this.Column != null &&
                    this.Column.Equals(input.Column))
                ) && 
                (
                    this.PrerequisiteNodeIndexes == input.PrerequisiteNodeIndexes ||
                    this.PrerequisiteNodeIndexes != null &&
                    input.PrerequisiteNodeIndexes != null &&
                    this.PrerequisiteNodeIndexes.SequenceEqual(input.PrerequisiteNodeIndexes)
                ) && 
                (
                    this.BinaryPairNodeIndex == input.BinaryPairNodeIndex ||
                    (this.BinaryPairNodeIndex != null &&
                    this.BinaryPairNodeIndex.Equals(input.BinaryPairNodeIndex))
                ) && 
                (
                    this.AutoUnlocks == input.AutoUnlocks ||
                    (this.AutoUnlocks != null &&
                    this.AutoUnlocks.Equals(input.AutoUnlocks))
                ) && 
                (
                    this.LastStepRepeats == input.LastStepRepeats ||
                    (this.LastStepRepeats != null &&
                    this.LastStepRepeats.Equals(input.LastStepRepeats))
                ) && 
                (
                    this.IsRandom == input.IsRandom ||
                    (this.IsRandom != null &&
                    this.IsRandom.Equals(input.IsRandom))
                ) && 
                (
                    this.RandomActivationRequirement == input.RandomActivationRequirement ||
                    (this.RandomActivationRequirement != null &&
                    this.RandomActivationRequirement.Equals(input.RandomActivationRequirement))
                ) && 
                (
                    this.IsRandomRepurchasable == input.IsRandomRepurchasable ||
                    (this.IsRandomRepurchasable != null &&
                    this.IsRandomRepurchasable.Equals(input.IsRandomRepurchasable))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.ExclusiveWithNodeHashes == input.ExclusiveWithNodeHashes ||
                    this.ExclusiveWithNodeHashes != null &&
                    input.ExclusiveWithNodeHashes != null &&
                    this.ExclusiveWithNodeHashes.SequenceEqual(input.ExclusiveWithNodeHashes)
                ) && 
                (
                    this.RandomStartProgressionBarAtProgression == input.RandomStartProgressionBarAtProgression ||
                    (this.RandomStartProgressionBarAtProgression != null &&
                    this.RandomStartProgressionBarAtProgression.Equals(input.RandomStartProgressionBarAtProgression))
                ) && 
                (
                    this.LayoutIdentifier == input.LayoutIdentifier ||
                    (this.LayoutIdentifier != null &&
                    this.LayoutIdentifier.Equals(input.LayoutIdentifier))
                ) && 
                (
                    this.GroupHash == input.GroupHash ||
                    (this.GroupHash != null &&
                    this.GroupHash.Equals(input.GroupHash))
                ) && 
                (
                    this.LoreHash == input.LoreHash ||
                    (this.LoreHash != null &&
                    this.LoreHash.Equals(input.LoreHash))
                ) && 
                (
                    this.NodeStyleIdentifier == input.NodeStyleIdentifier ||
                    (this.NodeStyleIdentifier != null &&
                    this.NodeStyleIdentifier.Equals(input.NodeStyleIdentifier))
                ) && 
                (
                    this.IgnoreForCompletion == input.IgnoreForCompletion ||
                    (this.IgnoreForCompletion != null &&
                    this.IgnoreForCompletion.Equals(input.IgnoreForCompletion))
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
                if (this.NodeIndex != null)
                    hashCode = hashCode * 59 + this.NodeIndex.GetHashCode();
                if (this.NodeHash != null)
                    hashCode = hashCode * 59 + this.NodeHash.GetHashCode();
                if (this.Row != null)
                    hashCode = hashCode * 59 + this.Row.GetHashCode();
                if (this.Column != null)
                    hashCode = hashCode * 59 + this.Column.GetHashCode();
                if (this.PrerequisiteNodeIndexes != null)
                    hashCode = hashCode * 59 + this.PrerequisiteNodeIndexes.GetHashCode();
                if (this.BinaryPairNodeIndex != null)
                    hashCode = hashCode * 59 + this.BinaryPairNodeIndex.GetHashCode();
                if (this.AutoUnlocks != null)
                    hashCode = hashCode * 59 + this.AutoUnlocks.GetHashCode();
                if (this.LastStepRepeats != null)
                    hashCode = hashCode * 59 + this.LastStepRepeats.GetHashCode();
                if (this.IsRandom != null)
                    hashCode = hashCode * 59 + this.IsRandom.GetHashCode();
                if (this.RandomActivationRequirement != null)
                    hashCode = hashCode * 59 + this.RandomActivationRequirement.GetHashCode();
                if (this.IsRandomRepurchasable != null)
                    hashCode = hashCode * 59 + this.IsRandomRepurchasable.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.ExclusiveWithNodeHashes != null)
                    hashCode = hashCode * 59 + this.ExclusiveWithNodeHashes.GetHashCode();
                if (this.RandomStartProgressionBarAtProgression != null)
                    hashCode = hashCode * 59 + this.RandomStartProgressionBarAtProgression.GetHashCode();
                if (this.LayoutIdentifier != null)
                    hashCode = hashCode * 59 + this.LayoutIdentifier.GetHashCode();
                if (this.GroupHash != null)
                    hashCode = hashCode * 59 + this.GroupHash.GetHashCode();
                if (this.LoreHash != null)
                    hashCode = hashCode * 59 + this.LoreHash.GetHashCode();
                if (this.NodeStyleIdentifier != null)
                    hashCode = hashCode * 59 + this.NodeStyleIdentifier.GetHashCode();
                if (this.IgnoreForCompletion != null)
                    hashCode = hashCode * 59 + this.IgnoreForCompletion.GetHashCode();
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
