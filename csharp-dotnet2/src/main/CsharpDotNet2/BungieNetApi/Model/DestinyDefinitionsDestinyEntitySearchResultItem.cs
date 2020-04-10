using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// An individual Destiny Entity returned from the entity search.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyEntitySearchResultItem {
    /// <summary>
    /// The hash identifier of the entity. You will use this to look up the DestinyDefinition relevant for the entity found.
    /// </summary>
    /// <value>The hash identifier of the entity. You will use this to look up the DestinyDefinition relevant for the entity found.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The type of entity, returned as a string matching the DestinyDefinition's contract class name. You'll have to have your own mapping from class names to actually looking up those definitions in the manifest databases.
    /// </summary>
    /// <value>The type of entity, returned as a string matching the DestinyDefinition's contract class name. You'll have to have your own mapping from class names to actually looking up those definitions in the manifest databases.</value>
    [DataMember(Name="entityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityType")]
    public string EntityType { get; set; }

    /// <summary>
    /// Basic display properties on the entity, so you don't have to look up the definition to show basic results for the item.
    /// </summary>
    /// <value>Basic display properties on the entity, so you don't have to look up the definition to show basic results for the item.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The ranking value for sorting that we calculated using our relevance formula. This will hopefully get better with time and iteration.
    /// </summary>
    /// <value>The ranking value for sorting that we calculated using our relevance formula. This will hopefully get better with time and iteration.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public double? Weight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyEntitySearchResultItem {\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  EntityType: ").Append(EntityType).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
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
