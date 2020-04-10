using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This defines the properties of a \&quot;Talent Node Step\&quot;. When you see a talent node in game, the actual visible properties that you see (its icon, description, the perks and stats it provides) are not provided by the Node itself, but rather by the currently active Step on the node.  When a Talent Node is activated, the currently active step&#39;s benefits are conferred upon the item and character.  The currently active step on talent nodes are determined when an item is first instantiated. Sometimes it is random, sometimes it is more deterministic (particularly when a node has only a single step).  Note that, when dealing with Talent Node Steps, you must ensure that you have the latest version of content. stepIndex and nodeStepHash - two ways of identifying the step within a node - are both content version dependent, and thus are subject to change between content updates.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyNodeStepDefinition {
    /// <summary>
    /// These are the display properties actually used to render the Talent Node. The currently active step's displayProperties are shown.
    /// </summary>
    /// <value>These are the display properties actually used to render the Talent Node. The currently active step's displayProperties are shown.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The index of this step in the list of Steps on the Talent Node.  Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content.
    /// </summary>
    /// <value>The index of this step in the list of Steps on the Talent Node.  Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content.</value>
    [DataMember(Name="stepIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stepIndex")]
    public int? StepIndex { get; set; }

    /// <summary>
    /// The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content.
    /// </summary>
    /// <value>The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content.</value>
    [DataMember(Name="nodeStepHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeStepHash")]
    public int? NodeStepHash { get; set; }

    /// <summary>
    /// If you can interact with this node in some way, this is the localized description of that interaction.
    /// </summary>
    /// <value>If you can interact with this node in some way, this is the localized description of that interaction.</value>
    [DataMember(Name="interactionDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interactionDescription")]
    public string InteractionDescription { get; set; }

    /// <summary>
    /// An enum representing a damage type granted by activating this step, if any.
    /// </summary>
    /// <value>An enum representing a damage type granted by activating this step, if any.</value>
    [DataMember(Name="damageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageType")]
    public int? DamageType { get; set; }

    /// <summary>
    /// If the step provides a damage type, this will be the hash identifier used to look up the damage type's DestinyDamageTypeDefinition.
    /// </summary>
    /// <value>If the step provides a damage type, this will be the hash identifier used to look up the damage type's DestinyDamageTypeDefinition.</value>
    [DataMember(Name="damageTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageTypeHash")]
    public int? DamageTypeHash { get; set; }

    /// <summary>
    /// If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid's Progression to have reached a certain level), they will be defined here.
    /// </summary>
    /// <value>If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid's Progression to have reached a certain level), they will be defined here.</value>
    [DataMember(Name="activationRequirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activationRequirement")]
    public DestinyDefinitionsDestinyNodeActivationRequirement ActivationRequirement { get; set; }

    /// <summary>
    /// There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially \"upgrading\" the node. We have moved away from this, but theoretically the capability still exists.  I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step.
    /// </summary>
    /// <value>There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially \"upgrading\" the node. We have moved away from this, but theoretically the capability still exists.  I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step.</value>
    [DataMember(Name="canActivateNextStep", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canActivateNextStep")]
    public bool? CanActivateNextStep { get; set; }

    /// <summary>
    /// The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.  This doesn't really matter anymore unless canActivateNextStep begins to be used again.
    /// </summary>
    /// <value>The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.  This doesn't really matter anymore unless canActivateNextStep begins to be used again.</value>
    [DataMember(Name="nextStepIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextStepIndex")]
    public int? NextStepIndex { get; set; }

    /// <summary>
    /// If true, the next step to be chosen is random, and if you're allowed to activate the next step. (if canActivateNextStep = true)
    /// </summary>
    /// <value>If true, the next step to be chosen is random, and if you're allowed to activate the next step. (if canActivateNextStep = true)</value>
    [DataMember(Name="isNextStepRandom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isNextStepRandom")]
    public bool? IsNextStepRandom { get; set; }

    /// <summary>
    /// The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more.
    /// </summary>
    /// <value>The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more.</value>
    [DataMember(Name="perkHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perkHashes")]
    public List<int?> PerkHashes { get; set; }

    /// <summary>
    /// When the Talent Grid's progression reaches this value, the circular \"progress bar\" that surrounds the talent node should be shown.  This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time)
    /// </summary>
    /// <value>When the Talent Grid's progression reaches this value, the circular \"progress bar\" that surrounds the talent node should be shown.  This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time)</value>
    [DataMember(Name="startProgressionBarAtProgress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startProgressionBarAtProgress")]
    public int? StartProgressionBarAtProgress { get; set; }

    /// <summary>
    /// When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided.
    /// </summary>
    /// <value>When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided.</value>
    [DataMember(Name="statHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statHashes")]
    public List<int?> StatHashes { get; set; }

    /// <summary>
    /// If this is true, the step affects the item's Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late
    /// </summary>
    /// <value>If this is true, the step affects the item's Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late</value>
    [DataMember(Name="affectsQuality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affectsQuality")]
    public bool? AffectsQuality { get; set; }

    /// <summary>
    /// In Destiny 1, the Armory's Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn't a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around.
    /// </summary>
    /// <value>In Destiny 1, the Armory's Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn't a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around.</value>
    [DataMember(Name="stepGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stepGroups")]
    public DestinyDefinitionsDestinyTalentNodeStepGroups StepGroups { get; set; }

    /// <summary>
    /// If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats.
    /// </summary>
    /// <value>If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats.</value>
    [DataMember(Name="affectsLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affectsLevel")]
    public bool? AffectsLevel { get; set; }

    /// <summary>
    /// If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs.
    /// </summary>
    /// <value>If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs.</value>
    [DataMember(Name="socketReplacements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketReplacements")]
    public List<DestinyDefinitionsDestinyNodeSocketReplaceResponse> SocketReplacements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyNodeStepDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  StepIndex: ").Append(StepIndex).Append("\n");
      sb.Append("  NodeStepHash: ").Append(NodeStepHash).Append("\n");
      sb.Append("  InteractionDescription: ").Append(InteractionDescription).Append("\n");
      sb.Append("  DamageType: ").Append(DamageType).Append("\n");
      sb.Append("  DamageTypeHash: ").Append(DamageTypeHash).Append("\n");
      sb.Append("  ActivationRequirement: ").Append(ActivationRequirement).Append("\n");
      sb.Append("  CanActivateNextStep: ").Append(CanActivateNextStep).Append("\n");
      sb.Append("  NextStepIndex: ").Append(NextStepIndex).Append("\n");
      sb.Append("  IsNextStepRandom: ").Append(IsNextStepRandom).Append("\n");
      sb.Append("  PerkHashes: ").Append(PerkHashes).Append("\n");
      sb.Append("  StartProgressionBarAtProgress: ").Append(StartProgressionBarAtProgress).Append("\n");
      sb.Append("  StatHashes: ").Append(StatHashes).Append("\n");
      sb.Append("  AffectsQuality: ").Append(AffectsQuality).Append("\n");
      sb.Append("  StepGroups: ").Append(StepGroups).Append("\n");
      sb.Append("  AffectsLevel: ").Append(AffectsLevel).Append("\n");
      sb.Append("  SocketReplacements: ").Append(SocketReplacements).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
