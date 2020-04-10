using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The properties of an individual checklist item. Note that almost everything is optional: it is *highly* variable what kind of data we&#39;ll actually be able to return: at times we may have no other relationships to entities at all.  Whatever UI you build, do it with the knowledge that any given entry might not actually be able to be associated with some other Destiny entity.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition {
    /// <summary>
    /// The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.
    /// </summary>
    /// <value>The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// Even if no other associations exist, we will give you *something* for display properties. In cases where we have no associated entities, it may be as simple as a numerical identifier.
    /// </summary>
    /// <value>Even if no other associations exist, we will give you *something* for display properties. In cases where we have no associated entities, it may be as simple as a numerical identifier.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Gets or Sets DestinationHash
    /// </summary>
    [DataMember(Name="destinationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationHash")]
    public int? DestinationHash { get; set; }

    /// <summary>
    /// Gets or Sets LocationHash
    /// </summary>
    [DataMember(Name="locationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationHash")]
    public int? LocationHash { get; set; }

    /// <summary>
    /// Note that a Bubble's hash doesn't uniquely identify a \"top level\" entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.  You can use this property if it is populated to look up the DestinyLocationDefinition's associated .locationReleases[].activityBubbleName property.
    /// </summary>
    /// <value>Note that a Bubble's hash doesn't uniquely identify a \"top level\" entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.  You can use this property if it is populated to look up the DestinyLocationDefinition's associated .locationReleases[].activityBubbleName property.</value>
    [DataMember(Name="bubbleHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bubbleHash")]
    public int? BubbleHash { get; set; }

    /// <summary>
    /// Gets or Sets ActivityHash
    /// </summary>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// Gets or Sets ItemHash
    /// </summary>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// Gets or Sets VendorHash
    /// </summary>
    [DataMember(Name="vendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHash")]
    public int? VendorHash { get; set; }

    /// <summary>
    /// Gets or Sets VendorInteractionIndex
    /// </summary>
    [DataMember(Name="vendorInteractionIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorInteractionIndex")]
    public int? VendorInteractionIndex { get; set; }

    /// <summary>
    /// The scope at which this specific entry can be computed.
    /// </summary>
    /// <value>The scope at which this specific entry can be computed.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public int? Scope { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition {\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
      sb.Append("  LocationHash: ").Append(LocationHash).Append("\n");
      sb.Append("  BubbleHash: ").Append(BubbleHash).Append("\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
      sb.Append("  VendorInteractionIndex: ").Append(VendorInteractionIndex).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
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
