using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Primarily for Quests, this is the definition of properties related to the item if it is a quest and its various quest steps.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSetBlockDefinition {
    /// <summary>
    /// A collection of hashes of set items, for items such as Quest Metadata items that possess this data.
    /// </summary>
    /// <value>A collection of hashes of set items, for items such as Quest Metadata items that possess this data.</value>
    [DataMember(Name="itemList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemList")]
    public List<DestinyDefinitionsDestinyItemSetBlockEntryDefinition> ItemList { get; set; }

    /// <summary>
    /// If true, items in the set can only be added in increasing order, and adding an item will remove any previous item. For Quests, this is by necessity true. Only one quest step is present at a time, and previous steps are removed as you advance in the quest.
    /// </summary>
    /// <value>If true, items in the set can only be added in increasing order, and adding an item will remove any previous item. For Quests, this is by necessity true. Only one quest step is present at a time, and previous steps are removed as you advance in the quest.</value>
    [DataMember(Name="requireOrderedSetItemAdd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requireOrderedSetItemAdd")]
    public bool? RequireOrderedSetItemAdd { get; set; }

    /// <summary>
    /// If true, the UI should treat this quest as \"featured\"
    /// </summary>
    /// <value>If true, the UI should treat this quest as \"featured\"</value>
    [DataMember(Name="setIsFeatured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setIsFeatured")]
    public bool? SetIsFeatured { get; set; }

    /// <summary>
    /// A string identifier we can use to attempt to identify the category of the Quest.
    /// </summary>
    /// <value>A string identifier we can use to attempt to identify the category of the Quest.</value>
    [DataMember(Name="setType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setType")]
    public string SetType { get; set; }

    /// <summary>
    /// The name of the quest line that this quest step is a part of.
    /// </summary>
    /// <value>The name of the quest line that this quest step is a part of.</value>
    [DataMember(Name="questLineName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questLineName")]
    public string QuestLineName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSetBlockDefinition {\n");
      sb.Append("  ItemList: ").Append(ItemList).Append("\n");
      sb.Append("  RequireOrderedSetItemAdd: ").Append(RequireOrderedSetItemAdd).Append("\n");
      sb.Append("  SetIsFeatured: ").Append(SetIsFeatured).Append("\n");
      sb.Append("  SetType: ").Append(SetType).Append("\n");
      sb.Append("  QuestLineName: ").Append(QuestLineName).Append("\n");
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
