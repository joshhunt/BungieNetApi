using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// An artificial construct provided by Bungie.Net, where we attempt to group talent nodes by functionality.  This is a single set of references to Talent Nodes that share a common trait or purpose.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyTalentNodeCategory {
    /// <summary>
    /// Mostly just for debug purposes, but if you find it useful you can have it. This is BNet's manually created identifier for this category.
    /// </summary>
    /// <value>Mostly just for debug purposes, but if you find it useful you can have it. This is BNet's manually created identifier for this category.</value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// If true, we found the localized content in a related DestinyLoreDefinition instead of local BNet localization files. This is mostly for ease of my own future investigations.
    /// </summary>
    /// <value>If true, we found the localized content in a related DestinyLoreDefinition instead of local BNet localization files. This is mostly for ease of my own future investigations.</value>
    [DataMember(Name="isLoreDriven", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isLoreDriven")]
    public bool? IsLoreDriven { get; set; }

    /// <summary>
    /// Will contain at least the \"name\", which will be the title of the category. We will likely not have description and an icon yet, but I'm going to keep my options open.
    /// </summary>
    /// <value>Will contain at least the \"name\", which will be the title of the category. We will likely not have description and an icon yet, but I'm going to keep my options open.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The set of all hash identifiers for Talent Nodes (DestinyTalentNodeDefinition) in this Talent Grid that are part of this Category.
    /// </summary>
    /// <value>The set of all hash identifiers for Talent Nodes (DestinyTalentNodeDefinition) in this Talent Grid that are part of this Category.</value>
    [DataMember(Name="nodeHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeHashes")]
    public List<int?> NodeHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyTalentNodeCategory {\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  IsLoreDriven: ").Append(IsLoreDriven).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  NodeHashes: ").Append(NodeHashes).Append("\n");
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
