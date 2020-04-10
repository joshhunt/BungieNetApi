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
    /// A PresentationNode is an entity that represents a logical grouping of other entities visually/organizationally.  For now, Presentation Nodes may contain the following... but it may be used for more in the future:  - Collectibles - Records (Or, as the public will call them, \&quot;Triumphs.\&quot; Don&#39;t ask me why we&#39;re overloading the term \&quot;Triumph\&quot;, it still hurts me to think about it) - Metrics (aka Stat Trackers) - Other Presentation Nodes, allowing a tree of Presentation Nodes to be created  Part of me wants to break these into conceptual definitions per entity being collected, but the possibility of these different types being mixed in the same UI and the possibility that it could actually be more useful to return the \&quot;bare metal\&quot; presentation node concept has resulted in me deciding against that for the time being.  We&#39;ll see if I come to regret this as well.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsPresentationDestinyPresentationNodeDefinition :  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyPresentationNodeDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="originalIcon">The original icon for this presentation node, before we futzed with it..</param>
        /// <param name="rootViewIcon">Some presentation nodes are meant to be explicitly shown on the \&quot;root\&quot; or \&quot;entry\&quot; screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \&quot;entry point\&quot; view in your UI. If you don&#39;t have a UI, then I guess it doesn&#39;t matter either way does it?.</param>
        /// <param name="nodeType">nodeType.</param>
        /// <param name="scope">Indicates whether this presentation node&#39;s state is determined on a per-character or on an account-wide basis..</param>
        /// <param name="objectiveHash">If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here..</param>
        /// <param name="completionRecordHash">If this presentation node has an associated \&quot;Record\&quot; that you can accomplish for completing its children, this is the identifier of that Record..</param>
        /// <param name="children">The child entities contained by this presentation node..</param>
        /// <param name="displayStyle">A hint for how to display this presentation node when it&#39;s shown in a list..</param>
        /// <param name="screenStyle">A hint for how to display this presentation node when it&#39;s shown in its own detail screen..</param>
        /// <param name="requirements">The requirements for being able to interact with this presentation node and its children..</param>
        /// <param name="disableChildSubscreenNavigation">If this presentation node has children, but the game doesn&#39;t let you inspect the details of those children, that is indicated here..</param>
        /// <param name="presentationNodeType">presentationNodeType.</param>
        /// <param name="traitIds">traitIds.</param>
        /// <param name="traitHashes">traitHashes.</param>
        /// <param name="parentNodeHashes">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsPresentationDestinyPresentationNodeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string originalIcon = default(string), string rootViewIcon = default(string), int nodeType = default(int), int scope = default(int), int objectiveHash = default(int), int completionRecordHash = default(int), DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock children = default(DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock), int displayStyle = default(int), int screenStyle = default(int), DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock requirements = default(DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock), bool disableChildSubscreenNavigation = default(bool), int presentationNodeType = default(int), List<string> traitIds = default(List<string>), List<int> traitHashes = default(List<int>), List<int> parentNodeHashes = default(List<int>), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.OriginalIcon = originalIcon;
            this.RootViewIcon = rootViewIcon;
            this.NodeType = nodeType;
            this.Scope = scope;
            this.ObjectiveHash = objectiveHash;
            this.CompletionRecordHash = completionRecordHash;
            this.Children = children;
            this.DisplayStyle = displayStyle;
            this.ScreenStyle = screenStyle;
            this.Requirements = requirements;
            this.DisableChildSubscreenNavigation = disableChildSubscreenNavigation;
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
        /// The original icon for this presentation node, before we futzed with it.
        /// </summary>
        /// <value>The original icon for this presentation node, before we futzed with it.</value>
        [DataMember(Name="originalIcon", EmitDefaultValue=false)]
        public string OriginalIcon { get; set; }

        /// <summary>
        /// Some presentation nodes are meant to be explicitly shown on the \&quot;root\&quot; or \&quot;entry\&quot; screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \&quot;entry point\&quot; view in your UI. If you don&#39;t have a UI, then I guess it doesn&#39;t matter either way does it?
        /// </summary>
        /// <value>Some presentation nodes are meant to be explicitly shown on the \&quot;root\&quot; or \&quot;entry\&quot; screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \&quot;entry point\&quot; view in your UI. If you don&#39;t have a UI, then I guess it doesn&#39;t matter either way does it?</value>
        [DataMember(Name="rootViewIcon", EmitDefaultValue=false)]
        public string RootViewIcon { get; set; }

        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public int NodeType { get; set; }

        /// <summary>
        /// Indicates whether this presentation node&#39;s state is determined on a per-character or on an account-wide basis.
        /// </summary>
        /// <value>Indicates whether this presentation node&#39;s state is determined on a per-character or on an account-wide basis.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public int Scope { get; set; }

        /// <summary>
        /// If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here.
        /// </summary>
        /// <value>If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here.</value>
        [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
        public int ObjectiveHash { get; set; }

        /// <summary>
        /// If this presentation node has an associated \&quot;Record\&quot; that you can accomplish for completing its children, this is the identifier of that Record.
        /// </summary>
        /// <value>If this presentation node has an associated \&quot;Record\&quot; that you can accomplish for completing its children, this is the identifier of that Record.</value>
        [DataMember(Name="completionRecordHash", EmitDefaultValue=false)]
        public int CompletionRecordHash { get; set; }

        /// <summary>
        /// The child entities contained by this presentation node.
        /// </summary>
        /// <value>The child entities contained by this presentation node.</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock Children { get; set; }

        /// <summary>
        /// A hint for how to display this presentation node when it&#39;s shown in a list.
        /// </summary>
        /// <value>A hint for how to display this presentation node when it&#39;s shown in a list.</value>
        [DataMember(Name="displayStyle", EmitDefaultValue=false)]
        public int DisplayStyle { get; set; }

        /// <summary>
        /// A hint for how to display this presentation node when it&#39;s shown in its own detail screen.
        /// </summary>
        /// <value>A hint for how to display this presentation node when it&#39;s shown in its own detail screen.</value>
        [DataMember(Name="screenStyle", EmitDefaultValue=false)]
        public int ScreenStyle { get; set; }

        /// <summary>
        /// The requirements for being able to interact with this presentation node and its children.
        /// </summary>
        /// <value>The requirements for being able to interact with this presentation node and its children.</value>
        [DataMember(Name="requirements", EmitDefaultValue=false)]
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; set; }

        /// <summary>
        /// If this presentation node has children, but the game doesn&#39;t let you inspect the details of those children, that is indicated here.
        /// </summary>
        /// <value>If this presentation node has children, but the game doesn&#39;t let you inspect the details of those children, that is indicated here.</value>
        [DataMember(Name="disableChildSubscreenNavigation", EmitDefaultValue=false)]
        public bool DisableChildSubscreenNavigation { get; set; }

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
        public List<int> TraitHashes { get; set; }

        /// <summary>
        /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
        /// </summary>
        /// <value>A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</value>
        [DataMember(Name="parentNodeHashes", EmitDefaultValue=false)]
        public List<int> ParentNodeHashes { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public int Hash { get; set; }

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
            sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  OriginalIcon: ").Append(OriginalIcon).Append("\n");
            sb.Append("  RootViewIcon: ").Append(RootViewIcon).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
            sb.Append("  CompletionRecordHash: ").Append(CompletionRecordHash).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  DisplayStyle: ").Append(DisplayStyle).Append("\n");
            sb.Append("  ScreenStyle: ").Append(ScreenStyle).Append("\n");
            sb.Append("  Requirements: ").Append(Requirements).Append("\n");
            sb.Append("  DisableChildSubscreenNavigation: ").Append(DisableChildSubscreenNavigation).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsPresentationDestinyPresentationNodeDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyPresentationNodeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyPresentationNodeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeDefinition input)
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
                    this.OriginalIcon == input.OriginalIcon ||
                    (this.OriginalIcon != null &&
                    this.OriginalIcon.Equals(input.OriginalIcon))
                ) && 
                (
                    this.RootViewIcon == input.RootViewIcon ||
                    (this.RootViewIcon != null &&
                    this.RootViewIcon.Equals(input.RootViewIcon))
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    this.NodeType.Equals(input.NodeType)
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
                (
                    this.ObjectiveHash == input.ObjectiveHash ||
                    this.ObjectiveHash.Equals(input.ObjectiveHash)
                ) && 
                (
                    this.CompletionRecordHash == input.CompletionRecordHash ||
                    this.CompletionRecordHash.Equals(input.CompletionRecordHash)
                ) && 
                (
                    this.Children == input.Children ||
                    (this.Children != null &&
                    this.Children.Equals(input.Children))
                ) && 
                (
                    this.DisplayStyle == input.DisplayStyle ||
                    this.DisplayStyle.Equals(input.DisplayStyle)
                ) && 
                (
                    this.ScreenStyle == input.ScreenStyle ||
                    this.ScreenStyle.Equals(input.ScreenStyle)
                ) && 
                (
                    this.Requirements == input.Requirements ||
                    (this.Requirements != null &&
                    this.Requirements.Equals(input.Requirements))
                ) && 
                (
                    this.DisableChildSubscreenNavigation == input.DisableChildSubscreenNavigation ||
                    this.DisableChildSubscreenNavigation.Equals(input.DisableChildSubscreenNavigation)
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
                if (this.OriginalIcon != null)
                    hashCode = hashCode * 59 + this.OriginalIcon.GetHashCode();
                if (this.RootViewIcon != null)
                    hashCode = hashCode * 59 + this.RootViewIcon.GetHashCode();
                hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectiveHash.GetHashCode();
                hashCode = hashCode * 59 + this.CompletionRecordHash.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                hashCode = hashCode * 59 + this.DisplayStyle.GetHashCode();
                hashCode = hashCode * 59 + this.ScreenStyle.GetHashCode();
                if (this.Requirements != null)
                    hashCode = hashCode * 59 + this.Requirements.GetHashCode();
                hashCode = hashCode * 59 + this.DisableChildSubscreenNavigation.GetHashCode();
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
