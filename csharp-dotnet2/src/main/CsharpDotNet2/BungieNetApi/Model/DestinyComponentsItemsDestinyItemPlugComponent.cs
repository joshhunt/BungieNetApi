using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Plugs are non-instanced items that can provide Stat and Perk benefits when socketed into an instanced item. Items have Sockets, and Plugs are inserted into Sockets.  This component finds all items that are considered \&quot;Plugs\&quot; in your inventory, and return information about the plug aside from any specific Socket into which it could be inserted.
  /// </summary>
  [DataContract]
  public class DestinyComponentsItemsDestinyItemPlugComponent {
    /// <summary>
    /// Sometimes, Plugs may have objectives: these are often used for flavor and display purposes, but they can be used for any arbitrary purpose (both fortunately and unfortunately). Recently (with Season 2) they were expanded in use to be used as the \"gating\" for whether the plug can be inserted at all. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item's data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition's progressDescription property. Refer to the plug's itemHash and objective property for more information if you would like to display even more data.
    /// </summary>
    /// <value>Sometimes, Plugs may have objectives: these are often used for flavor and display purposes, but they can be used for any arbitrary purpose (both fortunately and unfortunately). Recently (with Season 2) they were expanded in use to be used as the \"gating\" for whether the plug can be inserted at all. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item's data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition's progressDescription property. Refer to the plug's itemHash and objective property for more information if you would like to display even more data.</value>
    [DataMember(Name="plugObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugObjectives")]
    public List<DestinyQuestsDestinyObjectiveProgress> PlugObjectives { get; set; }

    /// <summary>
    /// The hash identifier of the DestinyInventoryItemDefinition that represents this plug.
    /// </summary>
    /// <value>The hash identifier of the DestinyInventoryItemDefinition that represents this plug.</value>
    [DataMember(Name="plugItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugItemHash")]
    public int? PlugItemHash { get; set; }

    /// <summary>
    /// If true, this plug has met all of its insertion requirements. Big if true.
    /// </summary>
    /// <value>If true, this plug has met all of its insertion requirements. Big if true.</value>
    [DataMember(Name="canInsert", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canInsert")]
    public bool? CanInsert { get; set; }

    /// <summary>
    /// If true, this plug will provide its benefits while inserted.
    /// </summary>
    /// <value>If true, this plug will provide its benefits while inserted.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition's plug.insertionRules property, so you can show the reasons why it can't be inserted.  This list will be empty if the plug can be inserted.
    /// </summary>
    /// <value>If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition's plug.insertionRules property, so you can show the reasons why it can't be inserted.  This list will be empty if the plug can be inserted.</value>
    [DataMember(Name="insertFailIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insertFailIndexes")]
    public List<int?> InsertFailIndexes { get; set; }

    /// <summary>
    /// If a plug is not enabled, this will be populated with indexes into the plug item definition's plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled.
    /// </summary>
    /// <value>If a plug is not enabled, this will be populated with indexes into the plug item definition's plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled.</value>
    [DataMember(Name="enableFailIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableFailIndexes")]
    public List<int?> EnableFailIndexes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsItemsDestinyItemPlugComponent {\n");
      sb.Append("  PlugObjectives: ").Append(PlugObjectives).Append("\n");
      sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
      sb.Append("  CanInsert: ").Append(CanInsert).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  InsertFailIndexes: ").Append(InsertFailIndexes).Append("\n");
      sb.Append("  EnableFailIndexes: ").Append(EnableFailIndexes).Append("\n");
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
