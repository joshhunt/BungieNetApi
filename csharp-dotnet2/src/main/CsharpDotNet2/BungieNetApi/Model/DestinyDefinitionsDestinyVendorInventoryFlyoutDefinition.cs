using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The definition for an \&quot;inventory flyout\&quot;: a UI screen where we show you part of an otherwise hidden vendor inventory: like the Vault inventory buckets.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition {
    /// <summary>
    /// If the flyout is locked, this is the reason why.
    /// </summary>
    /// <value>If the flyout is locked, this is the reason why.</value>
    [DataMember(Name="lockedDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockedDescription")]
    public string LockedDescription { get; set; }

    /// <summary>
    /// The title and other common properties of the flyout.
    /// </summary>
    /// <value>The title and other common properties of the flyout.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// A list of inventory buckets and other metadata to show on the screen.
    /// </summary>
    /// <value>A list of inventory buckets and other metadata to show on the screen.</value>
    [DataMember(Name="buckets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buckets")]
    public List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition> Buckets { get; set; }

    /// <summary>
    /// An identifier for the flyout, in case anything else needs to refer to them.
    /// </summary>
    /// <value>An identifier for the flyout, in case anything else needs to refer to them.</value>
    [DataMember(Name="flyoutId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flyoutId")]
    public int? FlyoutId { get; set; }

    /// <summary>
    /// If this is true, don't show any of the glistening \"this is a new item\" UI elements, like we show on the inventory items themselves in in-game UI.
    /// </summary>
    /// <value>If this is true, don't show any of the glistening \"this is a new item\" UI elements, like we show on the inventory items themselves in in-game UI.</value>
    [DataMember(Name="suppressNewness", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressNewness")]
    public bool? SuppressNewness { get; set; }

    /// <summary>
    /// If this flyout is meant to show you the contents of the player's equipment slot, this is the slot to show.
    /// </summary>
    /// <value>If this flyout is meant to show you the contents of the player's equipment slot, this is the slot to show.</value>
    [DataMember(Name="equipmentSlotHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipmentSlotHash")]
    public int? EquipmentSlotHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition {\n");
      sb.Append("  LockedDescription: ").Append(LockedDescription).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  Buckets: ").Append(Buckets).Append("\n");
      sb.Append("  FlyoutId: ").Append(FlyoutId).Append("\n");
      sb.Append("  SuppressNewness: ").Append(SuppressNewness).Append("\n");
      sb.Append("  EquipmentSlotHash: ").Append(EquipmentSlotHash).Append("\n");
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
