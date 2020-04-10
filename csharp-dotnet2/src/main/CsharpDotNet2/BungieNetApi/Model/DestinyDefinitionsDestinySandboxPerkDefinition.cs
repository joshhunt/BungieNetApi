using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Perks are modifiers to a character or item that can be applied situationally.  - Perks determine a weapons&#39; damage type.  - Perks put the Mods in Modifiers (they are literally the entity that bestows the Sandbox benefit for whatever fluff text about the modifier in the Socket, Plug or Talent Node)  - Perks are applied for unique alterations of state in Objectives  Anyways, I&#39;m sure you can see why perks are so interesting.  What Perks often don&#39;t have is human readable information, so we attempt to reverse engineer that by pulling that data from places that uniquely refer to these perks: namely, Talent Nodes and Plugs. That only gives us a subset of perks that are human readable, but those perks are the ones people generally care about anyways. The others are left as a mystery, their true purpose mostly unknown and undocumented.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinySandboxPerkDefinition {
    /// <summary>
    /// These display properties are by no means guaranteed to be populated. Usually when it is, it's only because we back-filled them with the displayProperties of some Talent Node or Plug item that happened to be uniquely providing that perk.
    /// </summary>
    /// <value>These display properties are by no means guaranteed to be populated. Usually when it is, it's only because we back-filled them with the displayProperties of some Talent Node or Plug item that happened to be uniquely providing that perk.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The string identifier for the perk.
    /// </summary>
    /// <value>The string identifier for the perk.</value>
    [DataMember(Name="perkIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perkIdentifier")]
    public string PerkIdentifier { get; set; }

    /// <summary>
    /// If true, you can actually show the perk in the UI. Otherwise, it doesn't have useful player-facing information.
    /// </summary>
    /// <value>If true, you can actually show the perk in the UI. Otherwise, it doesn't have useful player-facing information.</value>
    [DataMember(Name="isDisplayable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDisplayable")]
    public bool? IsDisplayable { get; set; }

    /// <summary>
    /// If this perk grants a damage type to a weapon, the damage type will be defined here.  Unless you have a compelling reason to use this enum value, use the damageTypeHash instead to look up the actual DestinyDamageTypeDefinition.
    /// </summary>
    /// <value>If this perk grants a damage type to a weapon, the damage type will be defined here.  Unless you have a compelling reason to use this enum value, use the damageTypeHash instead to look up the actual DestinyDamageTypeDefinition.</value>
    [DataMember(Name="damageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageType")]
    public int? DamageType { get; set; }

    /// <summary>
    /// The hash identifier for looking up the DestinyDamageTypeDefinition, if this perk has a damage type.  This is preferred over using the damageType enumeration value, which has been left purely because it is occasionally convenient.
    /// </summary>
    /// <value>The hash identifier for looking up the DestinyDamageTypeDefinition, if this perk has a damage type.  This is preferred over using the damageType enumeration value, which has been left purely because it is occasionally convenient.</value>
    [DataMember(Name="damageTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageTypeHash")]
    public int? DamageTypeHash { get; set; }

    /// <summary>
    /// An old holdover from the original Armory, this was an attempt to group perks by functionality.  It is as yet unpopulated, and there will be quite a bit of work needed to restore it to its former working order.
    /// </summary>
    /// <value>An old holdover from the original Armory, this was an attempt to group perks by functionality.  It is as yet unpopulated, and there will be quite a bit of work needed to restore it to its former working order.</value>
    [DataMember(Name="perkGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perkGroups")]
    public DestinyDefinitionsDestinyTalentNodeStepGroups PerkGroups { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinySandboxPerkDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  PerkIdentifier: ").Append(PerkIdentifier).Append("\n");
      sb.Append("  IsDisplayable: ").Append(IsDisplayable).Append("\n");
      sb.Append("  DamageType: ").Append(DamageType).Append("\n");
      sb.Append("  DamageTypeHash: ").Append(DamageTypeHash).Append("\n");
      sb.Append("  PerkGroups: ").Append(PerkGroups).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
