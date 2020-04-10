using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// All damage types that are possible in the game are defined here, along with localized info and icons as needed.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyDamageTypeDefinition {
    /// <summary>
    /// The description of the damage type, icon etc...
    /// </summary>
    /// <value>The description of the damage type, icon etc...</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// A variant of the icon that is transparent and colorless.
    /// </summary>
    /// <value>A variant of the icon that is transparent and colorless.</value>
    [DataMember(Name="transparentIconPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transparentIconPath")]
    public string TransparentIconPath { get; set; }

    /// <summary>
    /// If TRUE, the game shows this damage type's icon. Otherwise, it doesn't. Whether you show it or not is up to you.
    /// </summary>
    /// <value>If TRUE, the game shows this damage type's icon. Otherwise, it doesn't. Whether you show it or not is up to you.</value>
    [DataMember(Name="showIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showIcon")]
    public bool? ShowIcon { get; set; }

    /// <summary>
    /// We have an enumeration for damage types for quick reference. This is the current definition's damage type enum value.
    /// </summary>
    /// <value>We have an enumeration for damage types for quick reference. This is the current definition's damage type enum value.</value>
    [DataMember(Name="enumValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enumValue")]
    public int? EnumValue { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyDamageTypeDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  TransparentIconPath: ").Append(TransparentIconPath).Append("\n");
      sb.Append("  ShowIcon: ").Append(ShowIcon).Append("\n");
      sb.Append("  EnumValue: ").Append(EnumValue).Append("\n");
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
