using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Many actions relating to items require you to expend materials: - Activating a talent node - Inserting a plug into a socket The items will refer to material requirements by a materialRequirementsHash in these cases, and this is the definition for those requirements in terms of the item required, how much of it is required and other interesting info. This is one of the rare/strange times where a single contract class is used both in definitions *and* in live data response contracts. I&#39;m not sure yet whether I regret that.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyMaterialRequirement {
    /// <summary>
    /// The hash identifier of the material required. Use it to look up the material's DestinyInventoryItemDefinition.
    /// </summary>
    /// <value>The hash identifier of the material required. Use it to look up the material's DestinyInventoryItemDefinition.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// If True, the material will be removed from the character's inventory when the action is performed.
    /// </summary>
    /// <value>If True, the material will be removed from the character's inventory when the action is performed.</value>
    [DataMember(Name="deleteOnAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleteOnAction")]
    public bool? DeleteOnAction { get; set; }

    /// <summary>
    /// The amount of the material required.
    /// </summary>
    /// <value>The amount of the material required.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// If True, this requirement is \"silent\": don't bother showing it in a material requirements display. I mean, I'm not your mom: I'm not going to tell you you *can't* show it. But we won't show it in our UI.
    /// </summary>
    /// <value>If True, this requirement is \"silent\": don't bother showing it in a material requirements display. I mean, I'm not your mom: I'm not going to tell you you *can't* show it. But we won't show it in our UI.</value>
    [DataMember(Name="omitFromRequirements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "omitFromRequirements")]
    public bool? OmitFromRequirements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyMaterialRequirement {\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  DeleteOnAction: ").Append(DeleteOnAction).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  OmitFromRequirements: ").Append(OmitFromRequirements).Append("\n");
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
