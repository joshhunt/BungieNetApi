using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a Character Class in Destiny 2. These are types of characters you can play, like Titan, Warlock, and Hunter.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyClassDefinition {
    /// <summary>
    /// In Destiny 1, we added a convenience Enumeration for referring to classes. We've kept it, though mostly for posterity. This is the enum value for this definition's class.
    /// </summary>
    /// <value>In Destiny 1, we added a convenience Enumeration for referring to classes. We've kept it, though mostly for posterity. This is the enum value for this definition's class.</value>
    [DataMember(Name="classType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classType")]
    public int? ClassType { get; set; }

    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// A localized string referring to the singular form of the Class's name when referred to in gendered form. Keyed by the DestinyGender.
    /// </summary>
    /// <value>A localized string referring to the singular form of the Class's name when referred to in gendered form. Keyed by the DestinyGender.</value>
    [DataMember(Name="genderedClassNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "genderedClassNames")]
    public Dictionary<string, string> GenderedClassNames { get; set; }

    /// <summary>
    /// Gets or Sets GenderedClassNamesByGenderHash
    /// </summary>
    [DataMember(Name="genderedClassNamesByGenderHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "genderedClassNamesByGenderHash")]
    public Dictionary<string, string> GenderedClassNamesByGenderHash { get; set; }

    /// <summary>
    /// Mentors don't really mean anything anymore. Don't expect this to be populated.
    /// </summary>
    /// <value>Mentors don't really mean anything anymore. Don't expect this to be populated.</value>
    [DataMember(Name="mentorVendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mentorVendorHash")]
    public int? MentorVendorHash { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyClassDefinition {\n");
      sb.Append("  ClassType: ").Append(ClassType).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  GenderedClassNames: ").Append(GenderedClassNames).Append("\n");
      sb.Append("  GenderedClassNamesByGenderHash: ").Append(GenderedClassNamesByGenderHash).Append("\n");
      sb.Append("  MentorVendorHash: ").Append(MentorVendorHash).Append("\n");
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
