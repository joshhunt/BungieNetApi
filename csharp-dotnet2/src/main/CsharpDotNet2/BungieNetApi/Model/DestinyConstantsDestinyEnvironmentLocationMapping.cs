using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DestinyConstantsDestinyEnvironmentLocationMapping {
    /// <summary>
    /// The location that is revealed on the director by this mapping.
    /// </summary>
    /// <value>The location that is revealed on the director by this mapping.</value>
    [DataMember(Name="locationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationHash")]
    public int? LocationHash { get; set; }

    /// <summary>
    /// A hint that the UI uses to figure out how this location is activated by the player.
    /// </summary>
    /// <value>A hint that the UI uses to figure out how this location is activated by the player.</value>
    [DataMember(Name="activationSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activationSource")]
    public string ActivationSource { get; set; }

    /// <summary>
    /// If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don't)
    /// </summary>
    /// <value>If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don't)</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// If this is populated, this is an objective related to the location.
    /// </summary>
    /// <value>If this is populated, this is an objective related to the location.</value>
    [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHash")]
    public int? ObjectiveHash { get; set; }

    /// <summary>
    /// If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don't)
    /// </summary>
    /// <value>If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don't)</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyConstantsDestinyEnvironmentLocationMapping {\n");
      sb.Append("  LocationHash: ").Append(LocationHash).Append("\n");
      sb.Append("  ActivationSource: ").Append(ActivationSource).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
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
