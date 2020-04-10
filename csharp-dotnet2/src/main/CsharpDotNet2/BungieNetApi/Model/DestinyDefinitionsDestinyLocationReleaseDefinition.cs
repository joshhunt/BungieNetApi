using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A specific \&quot;spot\&quot; referred to by a location. Only one of these can be active at a time for a given Location.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyLocationReleaseDefinition {
    /// <summary>
    /// Sadly, these don't appear to be populated anymore (ever?)
    /// </summary>
    /// <value>Sadly, these don't appear to be populated anymore (ever?)</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// Gets or Sets SmallTransparentIcon
    /// </summary>
    [DataMember(Name="smallTransparentIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smallTransparentIcon")]
    public string SmallTransparentIcon { get; set; }

    /// <summary>
    /// Gets or Sets MapIcon
    /// </summary>
    [DataMember(Name="mapIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mapIcon")]
    public string MapIcon { get; set; }

    /// <summary>
    /// Gets or Sets LargeTransparentIcon
    /// </summary>
    [DataMember(Name="largeTransparentIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "largeTransparentIcon")]
    public string LargeTransparentIcon { get; set; }

    /// <summary>
    /// If we had map information, this spawnPoint would be interesting. But sadly, we don't have that info.
    /// </summary>
    /// <value>If we had map information, this spawnPoint would be interesting. But sadly, we don't have that info.</value>
    [DataMember(Name="spawnPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spawnPoint")]
    public int? SpawnPoint { get; set; }

    /// <summary>
    /// The Destination being pointed to by this location.
    /// </summary>
    /// <value>The Destination being pointed to by this location.</value>
    [DataMember(Name="destinationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationHash")]
    public int? DestinationHash { get; set; }

    /// <summary>
    /// The Activity being pointed to by this location.
    /// </summary>
    /// <value>The Activity being pointed to by this location.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// The Activity Graph being pointed to by this location.
    /// </summary>
    /// <value>The Activity Graph being pointed to by this location.</value>
    [DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityGraphHash")]
    public int? ActivityGraphHash { get; set; }

    /// <summary>
    /// The Activity Graph Node being pointed to by this location. (Remember that Activity Graph Node hashes are only unique within an Activity Graph: so use the combination to find the node being spoken of)
    /// </summary>
    /// <value>The Activity Graph Node being pointed to by this location. (Remember that Activity Graph Node hashes are only unique within an Activity Graph: so use the combination to find the node being spoken of)</value>
    [DataMember(Name="activityGraphNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityGraphNodeHash")]
    public int? ActivityGraphNodeHash { get; set; }

    /// <summary>
    /// The Activity Bubble within the Destination. Look this up in the DestinyDestinationDefinition's bubbles and bubbleSettings properties.
    /// </summary>
    /// <value>The Activity Bubble within the Destination. Look this up in the DestinyDestinationDefinition's bubbles and bubbleSettings properties.</value>
    [DataMember(Name="activityBubbleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityBubbleName")]
    public int? ActivityBubbleName { get; set; }

    /// <summary>
    /// If we had map information, this would tell us something cool about the path this location wants you to take. I wish we had map information.
    /// </summary>
    /// <value>If we had map information, this would tell us something cool about the path this location wants you to take. I wish we had map information.</value>
    [DataMember(Name="activityPathBundle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityPathBundle")]
    public int? ActivityPathBundle { get; set; }

    /// <summary>
    /// If we had map information, this would tell us about path information related to destination on the map. Sad. Maybe you can do something cool with it. Go to town man.
    /// </summary>
    /// <value>If we had map information, this would tell us about path information related to destination on the map. Sad. Maybe you can do something cool with it. Go to town man.</value>
    [DataMember(Name="activityPathDestination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityPathDestination")]
    public int? ActivityPathDestination { get; set; }

    /// <summary>
    /// The type of Nav Point that this represents. See the enumeration for more info.
    /// </summary>
    /// <value>The type of Nav Point that this represents. See the enumeration for more info.</value>
    [DataMember(Name="navPointType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "navPointType")]
    public int? NavPointType { get; set; }

    /// <summary>
    /// Looks like it should be the position on the map, but sadly it does not look populated... yet?
    /// </summary>
    /// <value>Looks like it should be the position on the map, but sadly it does not look populated... yet?</value>
    [DataMember(Name="worldPosition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "worldPosition")]
    public List<int?> WorldPosition { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyLocationReleaseDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  SmallTransparentIcon: ").Append(SmallTransparentIcon).Append("\n");
      sb.Append("  MapIcon: ").Append(MapIcon).Append("\n");
      sb.Append("  LargeTransparentIcon: ").Append(LargeTransparentIcon).Append("\n");
      sb.Append("  SpawnPoint: ").Append(SpawnPoint).Append("\n");
      sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  ActivityGraphHash: ").Append(ActivityGraphHash).Append("\n");
      sb.Append("  ActivityGraphNodeHash: ").Append(ActivityGraphNodeHash).Append("\n");
      sb.Append("  ActivityBubbleName: ").Append(ActivityBubbleName).Append("\n");
      sb.Append("  ActivityPathBundle: ").Append(ActivityPathBundle).Append("\n");
      sb.Append("  ActivityPathDestination: ").Append(ActivityPathDestination).Append("\n");
      sb.Append("  NavPointType: ").Append(NavPointType).Append("\n");
      sb.Append("  WorldPosition: ").Append(WorldPosition).Append("\n");
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
